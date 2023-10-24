using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main()
        {
            bool error = false;
            int i = 0;
            Console.Write("Insere um número inteiro: ");

            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine($"Foi pedido um int");
                error = true;
            }
            catch(OverflowException)
            {
                Console.WriteLine($"O número é demasiado grande ou pequeno para int.");
                error = true;
            }
            catch(Exception)
            {
                Console.WriteLine($"Ocorreu um erro desconhecido.");
                error = true;
            }

            if(!error)
                Console.WriteLine($"Número inserido: {i}");
        }
    }
}