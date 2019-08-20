using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {int idade = 0;

        Console.Write ("Digite sua idade: ");
        string idadeEmString = Console.ReadLine();
        idade = Convert.ToInt32 (idadeEmString);

        if (idade >= 13 && idade < 19)
        {
            Console.WriteLine ("Voce eh adolescente");
        }
        else if (idade >= 19 && idade <= 60)
        {
            Console.WriteLine ("Voce eh Adulto");
        }
        else if (idade > 60)
        {
            Console.WriteLine ("Voce eh idoso");
        }
        else
        {
            Console.WriteLine ("Voce eh crianca");
        }
        }
    }

}
