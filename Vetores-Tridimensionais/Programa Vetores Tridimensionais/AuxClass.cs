using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Vetores_Tridimensionais
{
    class AuxClass
    {        
        //
        // Declaração de dados
        //
        public static double forcaFa;
        public static double forcaFb;
        public static double forcaFc;
        public static double diagonalFb;
        public static double diagonalFc;
        public static double anguloFbZemXY;
        public static double anguloFcZemXY;
        public static double forcaFbxy;
        public static double forcaFcxy;
        public static int cont = 0;
        public static Boolean dadosPreenchidos;
        //
        // Dado, sendo que a linha 0 é a coordenada de Fb e a linha 1 é a de Fc. A Fa é a linha 2
        //
        public static double[,] distancias = new double[2, 3];
        public static double[,] forcasDecompostas = new double[3, 3];
        //
        // Para os ângulos diretores de Fa, temos que vetor 0 = cos em relação ao x, 1 - y, 2 - z
        //
        public static double[] angulosDiretoresFa = new double[3];
    }
}
