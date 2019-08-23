using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Escreva um número");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            
        }
    }

}
