using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gf, gc;
            Console.WriteLine("Digite o valor em graus Celsius: ");
            gc = double.Parse(Console.ReadLine());
            gf = (9 * gc + 160)/5;
            Console.WriteLine("O valor em graus Fahrenheit é: " + gf);
            Console.ReadKey();
        }
    }
}
