namespace ejercicios4JDPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] t = new int[2, 3];
            int total = 0;
            int totalF = 0;
            for (int fila=0; fila< t.GetLength(0);fila++)
            {
                Console.WriteLine("Las filas son "+fila);
                totalF++;
              //  Console.WriteLine("fila " + fila);
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    //  Console.Write(t[fila, columna]+ " ");
                   Console.WriteLine("Las columnas son " + columna);
                    //  Console.WriteLine("Las filas son "+fila);
                    total++;
                }
            }
            Console.WriteLine("El total de columnas son "+total);
            Console.WriteLine("El total de Filas son "+totalF);

        }
    }
}