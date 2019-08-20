using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {   float imc, peso, altura;
            Console.WriteLine("Digite o Seu peso: ");
            peso = float.Parse (Console.ReadLine());
            
            
            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse (Console.ReadLine());

            imc = (peso /(altura * altura));

            Console.WriteLine("Seu IMC é:" + imc);

            if (imc<18.5)
            {
                Console.Write ("Peso Abaixo do Normal");
            }
            else if (imc >18.5 && imc < 25)
            {
                Console.WriteLine ("Peso Normal");
            }
            else if (imc > 25 && imc <30)
            {
                Console.WriteLine ("Sobrepeso.");
            }
            else if (imc >30 && imc <35)
            {
                Console.WriteLine ("Obesidade Grau 1");
            }
            else if (imc>35 && imc<40)
            {
                Console.WriteLine("Obesidade Grau 2");
            }
            else if (imc>40)
            {
                Console.WriteLine("Obesidade Grau 3");
            }
        }
    }

}
