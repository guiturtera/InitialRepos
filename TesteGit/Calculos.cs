using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoIncerteza
{
    public class Calculos
    {
        /// <summary>
        /// Calcula a média de uma vetor de float
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Retorna uma média float do vetor</returns>
        public float Media(float[] valores) 
        {
            float soma = 0;
            for (int i = 0; i < valores.Length; i++)
                soma += valores[i];

            return (soma / valores.Length);


        }

        /// <summary>
        /// Retorna a mediana de um vetor de float
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Retorna um float referente à mediana do vetor</returns>
        public float Mediana(float[] valores) 
        {
            if (valores.Length == 2)
                return Media(valores);
            Array.Sort(valores);
            if (valores.Length % 2 == 1)
                return valores[(valores.Length / 2)];
            else
            {
                    float[] aux = { valores[valores.Length / 2] - 1, valores[(valores.Length / 2)] };
                    return Media(aux);
            }
                
        }

        /// <summary>
        /// Retorna a(s) moda(s) de um vetor de float. Caso seja amodal, retornará null
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Um vetor de float, possuindo sua moda</returns>
        public float[] Moda(float[] valores) 
        {
            int maiorNumero = 0;
            int aux = 1;
            Array.Sort(valores);
            List<int> contador = new List<int>();
            List<float> val = new List<float>();
            
            val.Add(valores[0]);
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i - 1] == valores[i])
                {
                    aux++;
                    
                    if (i == valores.Length - 1)
                        contador.Add(aux);
                    
                }
                else
                {
                    if (aux > maiorNumero)
                        maiorNumero = aux;
                    val.Add(valores[i]);
                    contador.Add(aux);
                    aux = 1;
                }
            }

            if (aux > maiorNumero)
                maiorNumero = aux;



            bool existe = false;
            List<float> moda = new List<float>();
            for (int i = 0; i < contador.Count; i++) 
            {
                if (contador[i] == maiorNumero)
                    moda.Add(val[i]);

                else
                    existe = true;
            }

            if (existe)
                return moda.ToArray();
            else
                return null;

        }

        /// <summary>
        /// Calcula o desvio padrão de um vetor de floats
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Retorna um float referente ao desvio padrão do vetor de parâmetro</returns>
        public float DesvioPadrao(float[] valores) 
        {
            float media = Media(valores);
            float desvioPadrao = 0;

            for (int i = 0; i < valores.Length; i++) 
            {
                desvioPadrao += (float)(Math.Pow((valores[i] - media), 2));
            }
            desvioPadrao = (float)(Math.Pow(desvioPadrao, 0.5));
            return (float)(desvioPadrao / Math.Pow(valores.Length - 1, 0.5));
        }

        /// <summary>
        /// Recebe a taxa, o montante e a quantidade de meses e retorna o valor final.
        /// É necessário que a taxa esteja em porcentagem.
        /// </summary>
        /// <param name="taxa"></param>
        /// <param name="VP"></param>
        /// <param name="meses"></param>
        /// <returns>Retorna um double referente ao valor final</returns>
        public double VF(double taxa, double VP, int meses) 
        {
            taxa /= 100.0;
            return VP * Math.Pow((1 + taxa), meses); 
        }

        /// <summary>
        /// Calcula através da taxa, Valor final e qnt meses, o valor inicial aplicado
        /// É necessário que a taxa esteja em porcentagem.
        /// </summary>
        /// <param name="taxa"></param>
        /// <param name="VF"></param>
        /// <param name="meses"></param>
        /// <returns>Retorna um double referente ao valor inicial</returns>
        public double VP(double taxa, double VF, int meses) 
        {
            taxa /= 100.0;
            return (VF / Math.Pow(1 + taxa, meses));
        }

        /// <summary>
        /// Recebe o valor inicial, final e qnt de meses.
        /// Devolve a taxa em porcentagem
        /// </summary>
        /// <param name="VP"></param>
        /// <param name="VF"></param>
        /// <param name="meses"></param>
        /// <returns>Um double referente à taxa em porcentagem</returns>
        public double Taxa(double VP, double VF, int meses) 
        {
            return (Math.Pow((VF / VP), (1.0 / meses)) - 1) * 100.0;
        }

        /// <summary>
        /// Recebe taxa, valor inicial e final, e calcula a quantidade de meses arredondada.
        /// </summary>
        /// <param name="taxa"></param>
        /// <param name="VP"></param>
        /// <param name="VF"></param>
        /// <returns>Retorna um inteiro referente à quantidade de meses</returns>
        public int Meses(double taxa, double VP, double VF) 
        {
            taxa /= 100.0;
            return (int)(Math.Round(Math.Log((VF / VP), (1 + taxa))));
        }

        /// <summary>
        /// Recebe um vetor de valores float e devolve a soma de seus quadrados
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Um float com a soma dos quadrados do vetor</returns>
        public float Sqrt(float[] valores) 
        {
            float somaQuadrados = 0;
            for (int i = 0; i < valores.Length; i++) 
            {
                somaQuadrados += (float)(Math.Pow(valores[i], 2));
            }
            return somaQuadrados;
        }

        /// <summary>
        /// Recebe valores para uma regra de 3 e devolve a medida relacionada ao eng
        /// </summary>
        /// <param name="medidaHi"></param>
        /// <param name="medidaLow"></param>
        /// <param name="engHi"></param>
        /// <param name="engLow"></param>
        /// <param name="medida"></param>
        /// <returns>Retorna um float referente à medida em proporção ao engLo e Hi</returns>
        public float Interpolacao(float medidaHi, float medidaLow, float engHi, float engLow, float medida) 
        {
            float tg = (engHi - engLow) / (medidaHi - medidaLow);
            return (-tg * (medidaHi - medida)) + engHi;
        }

    }
}
