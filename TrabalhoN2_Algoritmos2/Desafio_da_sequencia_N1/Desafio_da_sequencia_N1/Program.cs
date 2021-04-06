using System;

namespace Ex_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            int primeiroNumero = CapturaInteiro("Digite o primeiro número: ");
            int repeticoes = CapturaInteiro("Digite o número de repetições: ");

            // Saída de dados e processamento
            RetornaSequencia(primeiroNumero, repeticoes);
        }

        /// <summary>
        /// Este método capta e retorna um inteiro do usuário
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Um número inteiro especificado pelo usuário</returns>
        static int CapturaInteiro(string texto)
        {
            int num = 0;
            do
            {
                try
                {
                    Console.Write(texto);
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                        break;
                }
                catch
                {
                    Console.WriteLine("Escreva um dado válido. ");
                }
            } while (true);

            return num;
        }

        /// <summary>
        /// Este método retorna para o usuário toda a sequência "Eduardo Rosalém"
        /// </summary>
        /// <param name="primeiroNumero"></param>
        /// <param name="repeticoes"></param>
        static void RetornaSequencia(int primeiroNumero, int repeticoes)
        {
            string numeroStr = Convert.ToString(primeiroNumero);
            string auxStr = "";

            Console.WriteLine(primeiroNumero);
            for (int i = 1; i < repeticoes; i++)
            {
                int qntNum = 0; // Vai de 0 a 9
                for (int j = 0; j < numeroStr.Length; j++)
                {
                    qntNum += 1;

                    // Caso o número seguinte não existir ou forem diferentes
                    if (j == numeroStr.Length - 1)
                    {
                        auxStr += qntNum + "" + numeroStr[j];
                        qntNum = 0;
                    }
                    else if (numeroStr[j] != numeroStr[j + 1])
                    {
                        auxStr += qntNum + "" + numeroStr[j];
                        qntNum = 0;
                    }
                }
                numeroStr = auxStr;
                auxStr = "";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(numeroStr + "\n");
                Console.ResetColor();
            }
        }
    }
}
