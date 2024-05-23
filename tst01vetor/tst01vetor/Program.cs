using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst01vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomes = new[] { "Joaquim", "Eduardo", "vinicius" };
            foreach (var nome in nomes)
            {
                Console.WriteLine($" Olá {nome} ");
            }
            Console.ReadKey();

            string nom = nomes[0];
            string nom1 = nomes[1];
            string nom2 = nomes[2];
            Console.WriteLine(nom);
            Console.WriteLine(nom1);
            Console.WriteLine(nom2);
            Console.ReadKey();
        }
    }
}
