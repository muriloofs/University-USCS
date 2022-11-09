using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            n3 = double.Parse(Console.ReadLine());

            if (n1 <= n2 && n1 <= n3)
            {
                Console.WriteLine("O menor número é: " + n1);
            }
            else
            {
               if (n2 <= n1 && n2 <= n3)
                {
                    Console.WriteLine("O menor número é: " + n2);
                }
                else
                {
                    Console.WriteLine("O menor número é: " + n3);
                }
            }
        }
    }
}
