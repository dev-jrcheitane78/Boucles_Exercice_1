using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle_Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int compteur = 0;

            while (compteur < 10)
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                compteur++;
            }

            Console.Read();
        }
    }
}
