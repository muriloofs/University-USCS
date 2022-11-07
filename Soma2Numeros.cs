using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, soma;
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine(soma);
        }
    }
}
