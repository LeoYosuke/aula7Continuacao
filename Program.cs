using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07Continuaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorte = new Random();
            int number;
            int random = sorte.Next(1,11);

            Console.WriteLine("Bem-Vindo a blase\n");

            Console.WriteLine("Adivinhe o numero entre 1 e 10");
            Console.WriteLine("Digite o numero");
            Console.WriteLine($"{random}");
            number = Int32.Parse(Console.ReadLine());

            if (number > 10 || number<1) 
            {
                Console.WriteLine("DIGITE UM NUMERO VALIDO");
                Main(null);
                return;
                
            }
            if(number == random) 
            {
                Console.WriteLine("PARABENS VOCÊ GANHOU 100000 DE REAIS");
                 Console.ReadKey();
                Main(null);
                return;



            }


            Console.WriteLine("VOCE ERROU, TENTE NOVAMENTE");
                Main(null);
                return;





             
                
        }
    }
}
