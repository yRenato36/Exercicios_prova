using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_P1
{
    internal class Fatorial
    {
        static void Main(string[] args)
        {
            /*4) faça o fatorial de um número fonecido pelo usuário
            então apresente na tela somente os pares*/

            int num, fatorial, cont;
            num = 0;
            fatorial = 1;

            Console.WriteLine("Digite um número");
            num = Convert.ToInt16(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("número inválido");
            }
            else if ((num == 0) || (num == 1))
            {
                Console.WriteLine("Fatorial de {0} é igual a:", num);
            }
            else
            {                               //cont = cont - 1
                for (cont = num; cont >= 1; cont--)
                {
                    //fatorial = fatorial * cont;
                    /* a variável fatorial armazena e multiplica o valor de cont, 
                    assim vai acumulando os resultados*/
                    fatorial *= cont;
                }
                if(fatorial % 2 == 0)
                {
                    Console.WriteLine($"O fatorial = {fatorial} é par");
                }
                else
                {
                    Console.WriteLine($"O fatorial = {fatorial} é impar");
                }
            }
            Console.ReadKey();

        }
    }
}
