using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
               static void Main(string[] args)
        {
            
            string txt = "Digite sua idade: ";
            int idade = 0;

            Console.WriteLine (txt);

            string idadeEmString = Console.ReadLine();
            idade = Convert.ToInt32(idadeEmString);

                    
            if(idade >= 30) {
                Console.WriteLine($"VC ta velho");
           
            }
            else if (idade >=10 && idade <=15){
                Console.WriteLine ($"Voce é adolescente!!");

            }
            else if (idade <= 10){
                Console.WriteLine ($"vc é muito novo!");
            }

            Console.WriteLine($"VC Digitou: {idadeEmString}");
        }
    }

}
