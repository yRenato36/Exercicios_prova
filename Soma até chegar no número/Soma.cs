using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_até_chegar_no_número
{
    internal class Soma
    {
        static void Main(string[] args)
        {
            /* 2) faça um programa que peça ao usuário um número
            e some todas até esse número
            EX: o usuário digitou 4 então a soma é (1+2+3+4=10)b */
            float somando = 0;

            // o número que o usuário digita é utilizado para delimitar a
            // quantidade de repetições do laço for()
            Console.WriteLine("Digite um número");
            float num = float.Parse(Console.ReadLine());

            for (float cont = 0; cont <= num; cont++)
            {
                somando += cont;
            }
            Console.WriteLine("Resultado {0}", somando);

            Console.ReadKey();
        }
    }
}
