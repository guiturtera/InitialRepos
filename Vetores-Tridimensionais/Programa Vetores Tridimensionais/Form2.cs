using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Vetores_Tridimensionais
{
    public partial class frmVetores : Form
    {
        //
        // Começo do código
        //
        public frmVetores()
        {
            InitializeComponent();
        }

        //
        // Quando o forms carrega, a Imagem que carrega é determinada
        //
        private void frmComeco_Load(object sender, EventArgs e)
        {
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgComecoVetores;
        }

        //
        // Botão que explica a definição de um vetor
        //
        private void lblDefinicaoVetor_Click(object sender, EventArgs e)
        {
            lblTextoVetores.Text = "Vetor é um segmento de reta orientado que apresenta módulo (tamanho),\n" +
                "direção e sentido. Os vetores são usados para expressar grandezas físicas\n" +
                "vetoriais, ou seja, aquelas que só podem ser completamente definidas se\n" +
                "conhecemos o seu valor numérico, a direção em que atuam (horizontal\n" +
                "e vertical), bem como o seu o sentido (para cima, para baixo).";
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgDefinicaoVetor;
        }

        //
        // Botão que explica as características de um vetor
        //
        private void btnCaracteristicasVetor_Click(object sender, EventArgs e)
        {
            lblTextoVetores.Text = "O módulo é o valor numérico do vetor seguido da unidade de medida que\n" +
                "define a grandeza vetorial. A direção é a reta onde o vetor está localizado,\n" +
                "e as direções possíveis são: diagonal, horizontal e vertical. O sentido\n" +
                "trata-se de para onde o vetor atua de acordo com sua direção. Assim,\n" +
                "os sentidos podem ser para a direita, para a esquerda, para cima, para\n" +
                "baixo, para o leste, para o norte, etc.";
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgExVetor;
        }

        //
        // Botão que explica o cálculo de um vetor
        //
        private void btnCalculoVetor_Click(object sender, EventArgs e)
        {
            lblTextoVetores.Text = "Sempre levando em conta as coordenadas do espaço em que está\n" +
                "trabalhando (Bi / Tri - dimensional), temos que um vetor, para seu módulo,\n" +
                "obedece à lei do arco trigonométrico, sempre formando um triângulo\n" +
                "retângulo com seus respectivos eixos (x, y e z).\n" +
                "Clique nos botões Vetor Bidimensional ou Tridimensional para continuar.";
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgTrianguloRetangulo;
        }

        //
        // Botão que explica sobre vetor tridimensional
        //
        private void btnVetorTridimensional_Click(object sender, EventArgs e)
        {
            lblTextoVetores.Text = "Os vetores tridimensionais funcionam da mesma forma, porém\n" +
                "com a diferença que formam triângulos com os próprios eixos.\n" +
                "O ângulo desse vetor com o respectivo eixo é chamado de\n" +
                "ÂNGULO DIRETOR. O cosseno deste ângulo é o tamanho do vetor\n" +
                "no determinado eixo.\n" +
                "Para achar o módulo deste vetor, basta fazer a soma de seus eixos\n" +
                "ao quadrado e igualar à intensidade ao quadrado: I² = x² + y² + z²\n" +
                "Temos uma lei que diz: cos²α + cos²β + cos²Ω = 1";
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgAngulosDiretores;
        }

        //
        // Botão que explica sobre vetor Bidimensional
        //
        private void btnVetorBidimensional_Click(object sender, EventArgs e)
        {
            lblTextoVetores.Text = "Um vetor bidimensional possui dois valores de intensidade.\n" +
                "Um representado na horizontal (x) e outro na vertical (y)\n" +
                "Podemos dizer que estes valores são catetos que formam um\n" +
                "triângulo com esse vetor.\n" +
                "Agora, a direção e o sentido são definidos pelos valores x e y.\n" +
                "Por convenção, a direção se baseia no círculo trigonométrico,\n" +
                "portanto valores à esquerda significam x negativo, e valores para\n" +
                "baixo, um y negativo, e vice-versa.";
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgVetorBidimensional;
        }

        //
        // Botão que explica sobre o método matemático IJK
        //
        private void btnIjk_Click(object sender, EventArgs e)
        {
            lblTextoVetores.Text = "Quando temos os termos x, y e z de um vetor, dizemos que\n" +
                "ele está decomposto. Para facilidade de cálculo, existe\n" +
                "um método que transforma esses termos em números para facilitar\n" +
                "na álgebra. Tome como exemplo:\n" +
                "Calcule a soma dos vetores de A = (2, -2, 1) e B = (2, 2, -1).\n" +
                "A imagem a seguir ilustra com precisão o método. Para calcular, basta\n" +
                "Dizer que i = x, j = y e k = z. Equacionando, tem-se:\n" +
                "A + B   =   2i - 2j + 1k + 2i + 2j - 1k  =  4i.      A + B = (4, 0, 0)";
            picComeco.Image = Programa_Vetores_Tridimensionais.Properties.Resources.imgIjk;
        }

    }
}
