namespace SimplementeLigadas
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo Enlace { get; set; }
        public Nodo Anterior { get; set; }

        public Nodo(string valor = "", Nodo enlace = null, Nodo anterior = null)
        {
            Valor = valor;
            Enlace = enlace;
            Anterior = anterior;
        }
    }
}