using System;

namespace Operadores_Binários
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Binários Explicação
            //Para números binários, temos os seguintes operadores Binários:
            // O operador ou (|) --> Ele chega a relação entre binários. Ex: 110 | 011 = 111
            // O operador and (&) --> Ele checa a relação entre binários. Ex: 110 & 011 = 010
            // O operador xor (^) --> Ele checa a relação entre binários. Ex: 110 ^ 011 = 101
            // O operador (>>) --> Ele divide o número pela sua base. Ex em binário: 110(6d) >> 1(quantas casas muda, ou quantas vezes divide) = 011(3d)
            // O operador (<<) --> Ele multiplica o número pela sua base. Ex em binário: 110(6d) <<(quantas casas muda, ou quantas vezes multiplica) 1 = 1100(12d)          
            #endregion

            // Algoritmos para calcular quantos 1 tem dentro do número binário
            int a = 0b111001101; 
            int cont = 0;
            for (int i = 0;; i++)
            { 
                cont += (a >> i) & 1;
                if (a >> i == 0)
                    break;
            }
            Console.WriteLine(cont);

        }
    }
}
