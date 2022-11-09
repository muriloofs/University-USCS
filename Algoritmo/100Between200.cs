using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Escreva um número e lhe mostro se ele está entre 100 e 200: ");
            num = double.Parse(Console.ReadLine());

            if (num > 100 && num < 200)
            {
                Console.WriteLine("Está entre 100 e 200");
            }
            else
            {
                Console.WriteLine("Não está entre 100 e 200");
            }
            Console.ReadKey();
        }
    }
}
