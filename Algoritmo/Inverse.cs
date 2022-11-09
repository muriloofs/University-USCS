using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] v = new string[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                v[i] = Console.ReadLine();
            }
            for (i = 9; i >= 0; i--)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
