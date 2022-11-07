using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_Trapézio_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, B, h, area;
            b = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            area = ((B + b) * h)/2 ;
            Console.WriteLine(area);
        }
    }
}
