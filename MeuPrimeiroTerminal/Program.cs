using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string txt2 = "Elton, com idade de: ";
            string txt1 ="Hello World";
            int idade = 33;
            string txt3 = $"{txt1} {txt2} {idade}";
            string idadeEmString = idade.ToString();

            Console.WriteLine(txt3);
        }
    }

}
