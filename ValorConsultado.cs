using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1___Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------------- Início do Programa --------------- ");
            int i, valor;
            int[] array = new int[10];
            Console.WriteLine("Entre com 10 valores numéricos inteiros: ");

            for (i = 0; i < 10; i++)
                array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Entre com o valor a ser consultado no array: ");
                valor = int.Parse(Console.ReadLine());

            for (i = 0; i < 10; i++)
            {
                if (array[i] == valor)
                {
                    Console.WriteLine("Valor {0} existente no array!", valor);
                    Console.WriteLine("-------------- Fim do Programa --------------");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Valor {0} NÃO existente no array!", valor);
            Console.WriteLine("-------------- Fim de Programa ---------------");
            Console.ReadKey();
            return;
        }
    }
}
