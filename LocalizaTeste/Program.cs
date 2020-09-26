using System;
using System.Collections.Generic;
using UtilsMath;

namespace LocalizaTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            UtilsMath.Math math = new UtilsMath.Math();
            string valor = string.Empty;

            Console.Clear();
            Console.WriteLine("Escolha as opções:");
            Console.WriteLine("1) Calcular todos os divisores que compõem o número.");
            Console.WriteLine("2) Calcular todos os divisores primos que compõem o número. ");
            Console.WriteLine("9) Sair");
            Console.Write("\r\nSelecione a opção: ");

            switch (Console.ReadLine())
            {  
                case "1":
                  
                    Console.Clear();
                    Console.Write("\r\n Digite um numero: ");
                    valor = Console.ReadLine();

                    if (int.TryParse(valor, out int numero))
                    {
                        math.ImprimeDivisores(math.GetDivisores(Convert.ToInt32(numero)), Convert.ToInt32(numero));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\r\n Valor Digitado não é valido. Tente Novamente");
                        Console.ReadKey();
                    }                     
                    return true;
                case "2":
                    Console.Clear();
                    Console.Write("\r\n Digite um numero: ");
                    valor = Console.ReadLine();

                    if (int.TryParse(valor, out numero))
                    {
                        math.ImprimeDivisoresPrimo(math.GetDivisores(Convert.ToInt32(numero)), Convert.ToInt32(numero));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("\r\n Valor Digitado não é valido. Tente Novamente");
                        Console.ReadKey();
                    }
                    return true;
                case "3":
                    return true;
                case "9":
                    return false;
                default:
                    return true;
            }
        }


    }

    
    
}
