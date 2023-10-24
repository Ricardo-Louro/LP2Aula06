using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            Console.Write("Insere um número inteiro: ");

            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {e.Message}");
            }

            Console.WriteLine($"Número inserido: {i}");
        }
    }
}