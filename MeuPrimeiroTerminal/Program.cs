using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
               static void Main(string[] args)
        {
            Console.WriteLine ("Qual time ganhou a ultima Copa?");
            string[] times = new string[4];
            times [0] = "Brasil";
            times [1] = "Franca";
            times [2] = "México";
            times [3] = "Alemanha";
            for(int i = 0; i<4;i++)
            {
                Console.WriteLine (times[i]);
            }

            Console.WriteLine ("Resposta: ");
            
            String opcaoDoUsuario = Console.ReadLine();
            bool ehVencedor = EhVencedor(opcaoDoUsuario);

            if(ehVencedor)
                Console.WriteLine ("Venceu");
            else
                Console.WriteLine ("Perdeu");            
        }

        public static bool EhVencedor(string opcaoDoUsuario)
        {
            string vencedor = "Franca";
            // if(opcaoDoUsuario == vencedor)
            //{
            //    return true;
            //}

            //return false;

            return opcaoDoUsuario == vencedor;
        }
    }

}
