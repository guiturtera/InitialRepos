using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Vetores_Tridimensionais
{
    public partial class frmResolucao : Form
    {
        public frmResolucao()
        {
            InitializeComponent();
        }

        private void frmResolucao_Load(object sender, EventArgs e)
        {
            //forças iniciais (N)
            lblFb.Text = Convert.ToString(AuxClass.forcaFb) + "N";
            lblFc.Text = Convert.ToString(AuxClass.forcaFc) + "N";
            //distâncias iniciais (m)
            lblz.Text = Convert.ToString(AuxClass.distancias[0, 2]) + "m";
            lblbx.Text = Convert.ToString(AuxClass.distancias[0, 0]) + "m";
            lblby.Text = Convert.ToString(AuxClass.distancias[0, 1]) + "m";
            lblcx.Text = Convert.ToString(AuxClass.distancias[1, 0]) + "m";
            lblcy.Text = Convert.ToString(AuxClass.distancias[1, 1]) + "m";
            //diagonais
            lblDiagb.Text = Convert.ToString(Math.Round(AuxClass.diagonalFb, 3) + "m");
            lblDiagb.Visible = false;
            lblDiagc.Text = Convert.ToString(Math.Round(AuxClass.diagonalFc, 3) + "m");
            lblDiagc.Visible = false;
            lblAngZ.Text = Convert.ToString(Math.Round(AuxClass.anguloFcZemXY, 3) + "º");
            lblAngZ.Visible = false;
        }

        //
        //volta uma página se não estiver na página 0
        //
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(AuxClass.cont > 0)
            {
                AuxClass.cont--;
                checaPagina();
            }
        }

        //
        //avança uma página se não estiver na última delas
        //
        private void btnProxima_Click(object sender, EventArgs e)
        {
            if(AuxClass.cont < 19)
            {
                AuxClass.cont++;
                checaPagina();
            }
        }


        //
        //os textos farão referência à página na qual se encontram, numerada pelo cont
        //
        private void checaPagina()
        {
            //forças decompostas
            //seguem a mesma lógica que os valores originais
            //(linha 0 = B, linha 1 = C, linha 2 = A)
            //(coluna 0 = x, coluna 1 = y, coluna 2 = z)
            string[,] fbd = new string[3, 3];
            //decomposição da força B
            fbd[0, 0] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[0, 0]) + "N");
            fbd[0, 1] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[0, 1], 3) + "N");
            fbd[0, 2] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[0, 2], 3) + "N");
            //decomposição da força C
            fbd[1, 0] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[1, 0], 3) + "N");
            fbd[1, 1] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[1, 1], 3) + "N");
            fbd[1, 2] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[1, 2], 3) + "N");
            //decomposição da força A
            fbd[2, 0] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[2, 0], 3) + "N");
            fbd[2, 1] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[2, 1], 3) + "N");
            fbd[2, 2] = Convert.ToString(Math.Round(AuxClass.forcasDecompostas[2, 2], 3) + "N");
            //ângulos
            string grausB = Convert.ToString(Math.Round(AuxClass.anguloFbZemXY, 3) + "º");
            string grausC = Convert.ToString(Math.Round(AuxClass.anguloFcZemXY, 3) + "º");
            //sombras
            string sombraFb = Convert.ToString(Math.Round(AuxClass.forcaFbxy, 3) + "N");
            string sombraFc = Convert.ToString(Math.Round(AuxClass.forcaFcxy, 3) + "N");
            //força resultante
            string forcaResultante = Convert.ToString(Math.Round(AuxClass.forcaFa, 3) + "N");
            //ângulos diretores
            string dirx = Convert.ToString(Math.Round(AuxClass.angulosDiretoresFa[0], 2)) + "º";
            string diry = Convert.ToString(Math.Round(AuxClass.angulosDiretoresFa[1], 2)) + "º";
            string dirz = Convert.ToString(Math.Round(AuxClass.angulosDiretoresFa[2], 2)) + "º";

            switch (AuxClass.cont)
            {
                case 0:
                    lblResolucao.Text = ("Primeiramente, precisa-se ter em mente o que o exercício\n" +
                                     "pede e, depois, como se pode chegar a isso. Em segundo lugar,\n" +
                                     "é necessário colocar 'na mesa' todos os dados disponíveis. No\n" +
                                     "caso, tem-se as medidas trigonométricas das cordas, bem como\n" +
                                     "as forças que agem sobre as mesmas.\n" +
                                     "No caso desse exercício, pede-se a força resultante e os ângulos\n" +
                                     "diretores da mesma com cada eixo.");
                    break;
                case 1:
                    lblResolucao.Text = ("Com os dados inseridos, tem-se que:\n" +
                                         "A força B (de A a B) vale: " + lblFb.Text + "\n" +
                                         "A força C (de A a C) vale: " + lblFc.Text + "\n" +
                                         "A distância, no eixo Z, entre o ponto A e o chão vale: " + lblz.Text + "\n" +
                                         "A distância, no eixo X, entre os pontos A e B vale: " + lblbx.Text + "\n" + 
                                         "A distância, no eixo Y, entre os pontos A e B vale: " + lblby.Text + "\n" +
                                         "A distância, no eixo X, entre os pontos A e C vale: " + lblcx.Text + "\n" +
                                         "A distância, no eixo Y, entre os pontos A e C vale: " + lblcy.Text + "\n");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.Captura_de_Tela__87_;
                    break;
                case 2:
                    lblResolucao.Text = ("Com todos os dados em mente, é preciso ir atrás da força\n" +
                                         "resultante. Para isso, será feita a soma das forças B e C.\n" +
                                         "A natureza dos vetores é de que haja um valor escalar para\n" +
                                         "cada dimensão do mesmo. Neste caso, como temos um vetor tri-\n" +
                                         "dimensional, é preciso encontrar os três valores (x, y e z)\n" +
                                         "tanto do vetor da força B quanto do vetor da força C. Uma vez\n" +
                                         "encontrados, poderemos somá-los.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.Captura_de_Tela__87_;
                    break;
                case 3:
                    lblResolucao.Text = ("Perceba que a corda B, junto ao mastro e à sombra dela,\n" +
                                         "forma um triângulo retângulo, cuja hipotenusa é a corda.\n" +
                                         "Desta maneira, torna-se evidente a possibilidade de\n" +
                                         "encontrar os valores decompostos da força B por Pitágoras.\n" +
                                         "Assim, basta achar o ângulo que se forma entre o chão e a\n" +
                                         "corda. Surge, porém, um problema: não se sabe o valor da\n" +
                                         "sombra da corda, nem o valor do mastro em N, o que\n" +
                                         "significa que não é possível encontrar o ângulo\n" +
                                         "tendo-se em vista que só temos uma hipotenusa.\n");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgSombra1;
                    break;
                case 4:
                    lblDiagb.Visible = false;
                    lblResolucao.Text = ("Para resolver isso, serão utilizados os valores das\n" +
                                         "distâncias. Uma vez que as distâncias são diretamente\n" +
                                         "proporcionais às forças no que se diz respeito ao\n" +
                                         "triângulo retângulo, podemos encontrar valores em\n" +
                                         "metros e, depois, usar regras de três para encontrar\n" +
                                         "as forças. Logo, o primeiro passo será encontrar a\n" +
                                         "sombra da corda, que, se observarmos bem, também é\n" +
                                         "uma hipotenusa de um triângulo, o qual está projetado\n" + 
                                         "no chão e cujos catetos são " + lblbx.Text + " (distância entre A e B\n" +
                                         "no eixo X), e " + lblby.Text + " (distância entre A e B no eixo Y).\n" +
                                         "");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloDiagonal1;
                    break;
                case 5:
                    lblDiagb.Visible = true;
                    lblResolucao.Text = ("Aplicando-se o teorema de Pitágoras nesse novo\n" +
                                         "triângulo, tem-se que a diagonal, isto é, a sombra\n" + 
                                         "da corda possui um valor, em metros de " + lblDiagb.Text + ".\n" +
                                         "Essa 'sombra' servirá como cateto adjacente, ao passo que\n" +
                                         "a altura entre B e o chão, a qual vale " + lblz.Text + ", atuará\n" +
                                         "como cateto oposto. Com cateto oposto e cateto adjacente,\n" +
                                         "pode-se descobrir um ângulo através da tangente.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloDiagonal1;
                    break;
                case 6:
                    lblDiagb.Visible = false;
                    lblResolucao.Text = ("Considerando-se que se trata de uma tangente,\n" +
                                         "podemos dizer que o valor da mesma será o resultado\n" +
                                         "da divisão da altura do matro pelo tamanho da chamada\n" +
                                         "'sombra' da corda. Neste caso, tem-se que:\n" +
                                         lblz.Text + " ÷ " + lblDiagb.Text + " = o valor esperado da tangente.\n" +
                                         "Uma vez descoberto esse valor, podemos chegar à\n" +
                                         "conclusão de que seu ângulo, em graus, deve valer\n" + "por volta de: " + grausB);
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgAnguloTgt;
                    break;
                case 7:
                    lblResolucao.Text = ("Agora, é possível decompor a força B. Antes de\n" +
                                         "mais nada, o mais fácil no cenário atual é encontrar\n" + 
                                         "Fbz, pois, como temos a hipotenusa (" + lblFb.Text + ")\n" +
                                         "e um ângulo (" + grausB + "), pode-se descobrí-lo pela\n" +
                                         "razão trigonométrica do seno, sendo Fbz o cateto oposto. Se:\n" +
                                         "Fbz ÷ " + lblFb.Text + " = " + "sen" + grausB + "\nEntão:\n" + 
                                         "Fbz = " + lblFb.Text + " x sen" + grausB + "\nLogo:\n" +
                                         "Fbz = " + fbd[0, 2] + "\n" +
                                         "Lembrando que a força B em z é negativa por\n" +
                                         "convenção, de modo que o sinal apenas representa\n" +
                                         "a direção do vetor no plano apresentado. Como Fb\n" +
                                         "está apontada para baixo, Fbz é negativa.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgAnguloTgt;
                    break;
                case 8:
                    lblResolucao.Text = ("Agora é hora de achar Fbx e Fby. Há mais de um caminho\n" +
                                         "para se fazer isso. Aqui, faremos uma regra de três.\n" +
                                         "Sabe-se que:\n" +
                                         "A 'sombra' da corda em metros vale:\n" + lblDiagb.Text + "\n" +
                                         "Pela mesma lógica que usamos para descobrir Fbz, pode-se\n" + 
                                         "dizer que, em Newton, ela vale:\n" +
                                         lblFb.Text + " x cos" + grausB + " = " + sombraFb + "\n" +
                                         "Enquanto isso, sabemos também que:\n" +
                                         "O valor de x em metros é: " + lblbx.Text + "\n" +
                                         "Assim, temos quatro termos proporcionais: x em metros,\n" +
                                         "a sombra em metros, a sombra em Newton e x em Newton que\n" +
                                         "iremos descobrir.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloDiagonal1;
                    break;
                case 9:
                    lblResolucao.Text = ("Agora que temos três valores e uma incógnita,\n" +
                                         "basta fazer regra de três e teremos Fbx:\n" +
                                         lblDiagb.Text + " está para " + sombraFb + " assim como\n" +
                                         lblbx.Text + " está para Fbx N\n" +
                                         lblDiagb.Text + " x Fbx N = " + sombraFb + " x " + lblbx.Text + "\n" +
                                         "Fbx N = " + "(" + sombraFb + " x " + lblbx.Text + ") ÷ " + lblDiagb.Text + "\n" +
                                         "Fbx N = " + fbd[0, 0] + "\n" +
                                         "Tem-se, então, Fbx e Fbz. Falta apenas o Fby.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloDiagonal1;
                    break;
                case 10:
                    lblResolucao.Text = ("O Fby será encontrado da mesma forma que o.\n" +
                                         "Fbx. Nesse caso, temos:\n" +
                                         "Sombra (m): " + lblDiagb.Text + "\n" +
                                         "Sombra (N): " + sombraFb + "\n" +
                                         "Distância y (m): " + lblby.Text + "\n" +
                                         "Força B em y (N): ?\n" +
                                         "Logo:\n" +
                                         lblDiagb.Text + " está para " + sombraFb + " assim como\n" +
                                         lblby.Text + " está para Fby N\n" +
                                         "Fby N = " + "(" + sombraFb + " x " + lblby.Text + ") ÷ " + lblDiagb.Text + "\n" +
                                         "Fby N = " + fbd[0, 1] + "\n" +
                                         "Tem-se, então, Fbx, Fby e Fbz.\n" + 
                                         "Lembrando que Fby só é negativo por convenção.\n" +
                                         "O sinal representa que ele está à esquerda do\n" +
                                         "mastro, que é o ponto de referência.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloDiagonal1;
                    break;
                case 11:
                    lblDiagc.Visible = false;
                    lblResolucao.Text = ("Agora, vamos fazer exatamente o mesmo com a\n" +
                                         "força C. Começando pela 'sombra' da corda C,\n" +
                                         "apesar de não parecer do ângulo em que estamos\n" +
                                         "vendo, ela também é a hipotenusa de um triângulo.\n" +
                                         "Nesse caso, os catetos são:\n" +
                                         lblcx.Text + " em x;\n" +
                                         lblcy.Text + " em y.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgSombra2;
                    break;
                case 12:
                    lblDiagc.Visible = true;
                    lblAngZ.Visible = false;
                    lblResolucao.Text = ("Ao aplicarmos o teorema de Pitagóras, temos\n" +
                                         "que a sombra de C vale " + lblDiagc.Text + " e serve como\n" +
                                         "cateto adjacente.\n" +
                                         "Sendo " + lblz.Text + " (altura do mastro) o cateto oposto,\n" +
                                         "encontraremos o ângulo " + grausC);
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgSombra2;
                    break;
                case 13:
                    lblDiagc.Visible = false;
                    lblAngZ.Visible = true;
                    lblResolucao.Text = ("Agora, podemos decompor Fc.\n" +
                                         "Se Fc = " + lblFc.Text + "\n" +
                                         "e o ângulo vale " + grausC + ",\n" +
                                         "Fcz (em azul), que vale Fc x seno do ângulo, valerá:\n" +
                                         fbd[0, 2] + "\n" +
                                         "Lembrando, mais uma vez, que Fcz é\n" +
                                         "negativo simplesmente por estar\n" +
                                         "apontado para baixo.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloZ;
                    break;
                case 14:
                    lblAngZ.Visible = false;
                    lblResolucao.Text = ("Em sequência, o mesmo processo realizado\n" +
                                         "na força B será realizado na força C. Temos:\n" +
                                         "Sombra C em m = " + lblDiagc.Text + "\n" +
                                         "Sombra C em N = " + lblDiagc.Text + " x cos" + grausC + "\n" +
                                         "Sombra C em N = " + sombraFc + "\n" +
                                         "Valor de x em m = " + lblcx.Text + "\n" +
                                         "Valor de y em m = " + lblcy.Text + "\n" +
                                         "O próximo passo é a regra de três para achar\n" +
                                         "Fcx e Fcy.");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgSombra2;
                    break;
                case 15:
                    lblResolucao.Text = ("Se:\n" +
                                         "Sombra de C em metros está para x em metros assim como\n" +
                                         "Sombra de C em Newton está para x em Newton. Assim:\n" +
                                         lblDiagc.Text + " está para " + lblcx.Text + " assim como\n" +
                                         sombraFc + " está para Fcx\n" +
                                         "Fcx N = (" + lblcx.Text + " x " + sombraFc + ") ÷ " + lblDiagc.Text + "\n" +
                                         "Fcx N = " + fbd[1, 0]);
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgSombra2;
                    break;
                case 16:
                    lblResolucao.Text = ("Para encerrar a decomposição da força C, vamos\n" +
                                         "descobrir Fcy.\n" +
                                         "Sombra de C em metros está para y em metros assim como\n" +
                                         "Sombra de C em Newton está para y em Newton. Logo:\n" +
                                         lblDiagc.Text + " está para " + lblcy.Text + " assim como\n" +
                                         sombraFc + " está para Fcy\n" +
                                         "Fcy N = (" + lblcy.Text + " y " + sombraFc + ") ÷ " + lblDiagc.Text + "\n" +
                                         "Fcy N = " + fbd[1, 1]);
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgSombra2;
                    break;
                case 17:
                    lblResolucao.Text = ("Agora que as forças foram decompostas, é possível\n" +
                                         "encontrar a força resultante. A mesma será a soma\n" +
                                         "das forças B e C. Logo:\n" +
                                         "Frx = (" + fbd[0, 0] + ") + (" + fbd[1, 0] + ")\n" +
                                         "Frx = " + fbd[2, 0] + "\n" +
                                         "Fry = (" + fbd[0, 1] + ") + (" + fbd[1, 1] + ")\n" +
                                         "Fry = " + fbd[2, 1] + "\n" +
                                         "Frz = (" + fbd[0, 2] + ") + (" + fbd[1, 2] + ")\n" +
                                         "Frz = " + fbd[2, 2]);
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.Fr;
                    break;
                case 18:
                    lblResolucao.Text = ("Sabe-se que a intensidade de um vetor tridimensional\n" +
                                         "é a raiz soma dos quadrados dos três valores escalares\n" +
                                         "que ele tem. Portanto:\n" +
                                         "Fr² = Frx² + Fry² + Frz²\n" +
                                         "Fr² = " + fbd[2, 0] + "² + " + fbd[2, 1] + "² + " + fbd[2, 2] + "²\n" +
                                         "Fr = " + forcaResultante);
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.Fr;
                    break;
                case 19:
                    lblResolucao.Text = ("Por fim, o exercício também pediu os ângulos diretores\n" +
                                         "da força resultante. Para isso, é preciso utilizar os\n" +
                                         "valores de Fr em cada eixo. No fim, os resultados serão:\n" +
                                         "Para cosα (eixo x), temos que, o ângulo α é o ArcCos da\n" +
                                         "intensidade do vetor em x, dividido pela intensidade do vetores:\n" +
                                         "α = arccos(" + fbd[2, 0] + " / " + forcaResultante + ") = " + dirx + "\n" +
                                         "Aplicando-se o mesmo conceito nos eixos y e z,\n" +
                                         "temos que, α, β e Ω são:\n" +
                                         dirx + " em x\n" +
                                         diry + " em y\n" +
                                         dirz + " em z");
                    pictureBox1.Image = Programa_Vetores_Tridimensionais.Properties.Resources.Fr;
                    break;
            }
        }
    }
}