using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notas, media;
            double[] array = new double[10];
            Console.WriteLine("Escreva as notas dos 10 alunos");

            for (notas = 0; notas < array.Length; notas++)
                array[(int)notas] = double.Parse(Console.ReadLine());

        }
    }
}
