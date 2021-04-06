using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = 0;

            Console.Write("Digite um número inteiro: ");

            try
            {
                entrada = Convert.ToInt32(Console.ReadLine().Trim());
            }
            catch
            {
                Console.Write("\n Você digitou incorretamente!");
            }

            char option = ' ';

            Console.WriteLine("\nP - Converte de POLEGADAS para CENTÍMETROS");
            Console.WriteLine("G - Converte de GALÕES para LITROS");
            Console.WriteLine("M - Converte de MILHAS para QUILOMETROS \n");


            try
            {
                option = Convert.ToChar(Console.ReadLine().Trim().ToUpper());
            }
            catch
            {
                Console.Write("\n Você digitou incorretamente!");
            }

            switch (option)
            {
                case 'P':
                    Console.WriteLine("\nConvertido para metros: {0:F3}", (entrada / 2.54));
                    break;
                case 'G':
                    Console.WriteLine("\nConvertido para Litros: {0:F3}", (entrada / 3.78));
                    break;
                case 'M':
                    Console.WriteLine("\nConvertido para Quilometros: {0:F3}", (entrada / 1.609));
                    break;
                default:
                    Console.WriteLine("\nCaracter digitado incorretamente!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
