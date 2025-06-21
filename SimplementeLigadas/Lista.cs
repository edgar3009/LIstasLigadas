using System.Text;

namespace SimplementeLigadas
{
    internal class Lista
    {
        private Nodo _inicial;

        public Lista()
        {
            _inicial = new Nodo();
        }

        public void Agregar(string dato)
        {
            Nodo actual = _inicial;

            while (actual.Enlace != null)
            {
                actual = actual.Enlace;
            }

            Nodo nuevoNodo = new Nodo(dato);
            actual.Enlace = nuevoNodo;
        }

        public string ObtenerValores()
        {
            StringBuilder datos = new StringBuilder();

            Nodo actual = _inicial;
            while (actual.Enlace != null)
            {
                actual = actual.Enlace;
                datos.AppendLine(actual.Valor);
            }
            return datos.ToString();
        }

        public Nodo Buscar(string valor)
        {
            Nodo actual = _inicial;

            while (actual.Enlace != null)
            {
                actual = actual.Enlace;

                if (actual.Valor == valor)
                {
                    return actual;
                }
            }
            return null;
        }

        private Nodo BuscarAnterior(string valor)
        {

            Nodo actual = _inicial;
            while (actual.Enlace != null)
            {
                if (actual.Enlace.Valor == valor)
                {
                    return actual;
                }
                actual = actual.Enlace;
            }
            return null;
        }

        public void Eliminar(string valor)
        {
            Nodo nodoActual = Buscar(valor);
            if (nodoActual is not null)
            {
                Nodo nodoAnterior = BuscarAnterior(valor);

                if (nodoAnterior is null)
                {
                    throw new Exception("No se encontró el nodo anterior");
                } 

                nodoAnterior.Enlace = nodoActual.Enlace;
                nodoActual.Enlace = null;
            }
        }
    }
}
