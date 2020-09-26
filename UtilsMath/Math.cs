using System;
using System.Collections.Generic;
using System.Text;

namespace UtilsMath
{
    public class Math
    {
        /// <summary>
        /// Retorna todos os divisores de um numero.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public List<int> GetDivisores(int numero)
        {
            List<int> divisores = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores;
        }

        /// <summary>
        /// Retorna os divisores primos de um determinado numero.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public List<int> GetDivisoresPrimo(int numero)
        {
            List<int> divisores = GetDivisores(numero);
            List<int> divisoresPrimo = new List<int>();

            foreach (var itemDivivisel in divisores)
            {
                if (VerificaNumeroPrimo(itemDivivisel))
                    divisoresPrimo.Add(itemDivivisel);
            }
            return divisoresPrimo;
        }

        /// <summary>
        /// Imprime na Tela os divisores do numero.
        /// </summary>
        /// <param name="divisiveis"></param>
        /// <param name="numero"></param>
        public void ImprimeDivisores(List<int> divisiveis, int numero)
        {
            Console.WriteLine("\r\n Os divisores do " + numero + " são: ");
            Console.WriteLine();

            foreach (var itemDivivisel in divisiveis)
            {
                Console.WriteLine("\r\r" + itemDivivisel);
            }
        }

        /// <summary>
        /// Imprime na tela o resultado dos numeros primos.
        /// </summary>
        /// <param name="divisiveis"></param>
        /// <param name="numero"></param>
        public void ImprimeDivisoresPrimo(List<int> divisiveis, int numero)
        {
            Console.WriteLine("\r\n Os divisores primo do " + numero + " são: ");
            Console.WriteLine();

            foreach (var itemDivivisel in divisiveis)
            {
                if (VerificaNumeroPrimo(itemDivivisel))
                    Console.WriteLine("\r\r" + itemDivivisel + " " + "É Primo.");
                //else
                //{
                //    Console.WriteLine("\r\r" + itemDivivisel);
                //}
            }
        }

        /// <summary>
        /// Função que retorna se o numero é primo ou nao.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool VerificaNumeroPrimo(int numero)
        {
            bool ehNumeroPrimo = true;
            for (int i = 0; i <= numero; i++)
            {
                if ((i == 0) || (i == numero) || (i == 1))
                {
                    continue;
                }
                else
                {
                    for (int j = i; j < numero; j++)
                    {
                        if (numero % j == 0)
                        {
                            ehNumeroPrimo = false;
                            break;
                        }
                        else
                            break;
                    }
                }
            }
            return ehNumeroPrimo;
        }
    }
}
