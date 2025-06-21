namespace SimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Lista lista = new Lista();
            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Agregar("E");
            lista.Agregar("F");
            lista.Agregar("G");

            Console.WriteLine(lista.ObtenerValores());

            lista.Eliminar("C");

            Console.WriteLine();
            Console.WriteLine(lista.ObtenerValores());

        }
    }
}
