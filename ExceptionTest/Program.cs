using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insere um número inteiro: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero inserido: {i}");
        }
    }
}
