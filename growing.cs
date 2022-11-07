using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace growing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Primeiro Número: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Número: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro Número: ");
            c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c) Console.WriteLine($"{c},{b},{a}");
                else if (a > c) Console.WriteLine($"{b},{c},{a}");
                else Console.WriteLine($"{b},{a},{c}");
            }
            else if (b > c)
            {
                if (a > c) Console.WriteLine($"{c},{a},{b}");
                else Console.WriteLine($"{a},{c},{b}");
            }
            else Console.WriteLine($"{a},{b},{c}");
        }
    }
}
