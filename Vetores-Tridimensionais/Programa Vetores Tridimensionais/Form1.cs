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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        //
        // Botão para dar a introdução à aplicação
        //
        private void btnIntro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo!" +
                "\nPor favor preecha os dados com as distâncias equivalentes em metros na figura" +
                " e preecha as forças que ambas as cordas produzem na bandeira.\n" +
                "Caso se interesse, há uma breve explicação sobre vetores no botão ao lado.", "Introdução", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }
        
        //
        // Botão de encerramento do programa
        //
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //
        // Quando o Form carraga
        //
        private void frmMain_Load(object sender, EventArgs e)
        {
        }
        
        //
        // Criação de um novo Form explicativo de vetores   
        //
        private void btnComeco_Click(object sender, EventArgs e)
        {
            Form frmVetores = new frmVetores();
            frmVetores.Visible = true;
        }

        //
        // Força b sendo declarada
        //
        private void txtFb_TextChanged(object sender, EventArgs e)
        {
            if (txtFb.Text == "0")
            {
                txtFb.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuxClass.forcaFb = entradaDados(txtFb.Text);
            }
        }
        
        //
        // Força c sendo declarada
        //
        private void txtFc_TextChanged(object sender, EventArgs e)
        {
            if (txtFc.Text == "0")
            {
                txtFc.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuxClass.forcaFc = entradaDados(txtFc.Text);
            }
        }
        
        //
        // Distância Z sendo declarada
        // 
        private void txtDistanciaZ_TextChanged(object sender, EventArgs e)
        {
            if (txtDistanciaZ.Text == "0")
            {
                txtDistanciaZ.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuxClass.distancias[0, 2] = entradaDados(txtDistanciaZ.Text);
                AuxClass.distancias[1, 2] = entradaDados(txtDistanciaZ.Text);
            }
        }

        //
        // Distância x de Fb sendo declarada
        // 
        private void txtDistanciaFbX_TextChanged(object sender, EventArgs e)
        {
           AuxClass.distancias[0, 0] = entradaDados(txtDistanciaFbX.Text);
            if (AuxClass.distancias[0, 0] != 0 && AuxClass.distancias[0, 1] != 0 && AuxClass.distancias[0, 2] != 0)
            {
                dadosFb();
                decomposicaoFa();
                calculoAngulosDiretoresFa();
            }
            if (txtDistanciaFbX.Text == "0")
            {
                txtDistanciaFbX.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //
        // Distância y de Fb sendo declarada
        // 
        private void txtDistanciaFbY_TextChanged(object sender, EventArgs e)
        {
            AuxClass.distancias[0, 1] = entradaDados(txtDistanciaFbY.Text);
            if (AuxClass.distancias[0, 0] != 0 && AuxClass.distancias[0, 1] != 0 && AuxClass.distancias[0, 2] != 0)
            {
                dadosFb();
                decomposicaoFa();
                calculoAngulosDiretoresFa();
            }
            if (txtDistanciaFbY.Text == "0")
            {
                txtDistanciaFbY.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //
        // Distância y de Fc sendo declarada
        // 
        private void txtDistanciaFcY_TextChanged(object sender, EventArgs e)
        {
            AuxClass.distancias[1, 1] = entradaDados(txtDistanciaFcY.Text);
            if (AuxClass.distancias[1, 0] != 0 && AuxClass.distancias[1, 1] != 0 && AuxClass.distancias[1, 2] != 0)
            {
                dadosFc();
                decomposicaoFa();
                calculoAngulosDiretoresFa();
            }
            if (txtDistanciaFcY.Text == "0")
            {
                txtDistanciaFcY.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //
        // Distância x de Fc sendo declarada
        // 
        private void txtDistanciaFcX_TextChanged(object sender, EventArgs e)
        {
            AuxClass.distancias[1, 0] = entradaDados(txtDistanciaFcX.Text);
            if (AuxClass.distancias[1, 0] != 0 && AuxClass.distancias[1, 1] != 0 && AuxClass.distancias[1, 2] != 0)
            {
                dadosFc();
                decomposicaoFa();
                calculoAngulosDiretoresFa();
            }
            if (txtDistanciaFcX.Text == "0")
            {
                txtDistanciaFcX.Text = "";
                MessageBox.Show("Insira um número diferente de 0.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picExercicio_Click(object sender, EventArgs e)
        {
            
        }

        //
        // Método para entrada de dados
        //
        private double entradaDados(string dados)
        {
            double dadosNum = 0;
            try
            {
                if (dados != "")
                    dadosNum = Convert.ToDouble(dados);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Escreva um número válido", "Número válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            return dadosNum;
        }

        //
        // Método para obtenção do ângulo em relação z no plano xy
        //
        private double obterAngulo(double distanciaZ, double diagonal)
        {
            double anguloRad, anguloGrau;
            anguloRad = Math.Atan2(distanciaZ, diagonal);
            anguloGrau = ((anguloRad*180)/Math.PI);
            return anguloGrau;
        }

        //
        // Método para checagem de dados
        //
        private Boolean checagemDados()
        {
            Boolean checagem;
            if (txtFb.Text == "" || txtFc.Text == "" || txtDistanciaFbX.Text == "" || txtDistanciaFbY.Text == "" ||
                txtDistanciaFcX.Text == "" || txtDistanciaFcY.Text == "" || txtDistanciaZ.Text == "")
            {
                MessageBox.Show("Termine de preencher os dados.", "Dados faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checagem = false;
            }
            else
            {
                checagem = true;
            }
            return checagem;
        }

        //
        // Método para vetor a
        //
        private void decomposicaoFa()
        {
            AuxClass.forcaFa = 0;
            AuxClass.forcasDecompostas[2, 0] = AuxClass.forcasDecompostas[0, 0] + AuxClass.forcasDecompostas[1, 0];
            AuxClass.forcasDecompostas[2, 1] = AuxClass.forcasDecompostas[0, 1] + AuxClass.forcasDecompostas[1, 1];
            AuxClass.forcasDecompostas[2, 2] = AuxClass.forcasDecompostas[0, 2] + AuxClass.forcasDecompostas[1, 2];
            for (int i = 0; i < 3; i++)
            {
                AuxClass.forcaFa += Math.Pow(AuxClass.forcasDecompostas[2, i], 2);
            }
            AuxClass.forcaFa = Math.Pow(AuxClass.forcaFa, 0.5);
        }

        //
        // Decomposição de forças de Fb
        //
        private void dadosFb()
        {
            //Diagonais
            //Angulo em relacao ao plano xy
            //Achando as forças decompostas
            AuxClass.diagonalFb = Math.Pow((AuxClass.distancias[0, 0] * AuxClass.distancias[0, 0])
                  + (AuxClass.distancias[0, 1] * AuxClass.distancias[0, 1]), 0.5);
            AuxClass.anguloFbZemXY = obterAngulo(AuxClass.distancias[0, 2], AuxClass.diagonalFb);
            AuxClass.forcasDecompostas[0, 2] = -(AuxClass.forcaFb * (Math.Sin(AuxClass.anguloFbZemXY * Math.PI / 180)));
            AuxClass.forcaFbxy = AuxClass.forcaFb * (Math.Cos(AuxClass.anguloFbZemXY * Math.PI / 180));
            AuxClass.forcasDecompostas[0, 0] = (AuxClass.distancias[0, 0] * AuxClass.forcaFbxy) / AuxClass.diagonalFb;
            AuxClass.forcasDecompostas[0, 1] = -(AuxClass.distancias[0, 1] * AuxClass.forcaFbxy) / AuxClass.diagonalFb;
        }

        //
        // Decomposição de forças de Fc
        //
        private void dadosFc()
        {
            //Diagonais
            //Angulo em relacao ao plano xy
            //Decomposição de Fc
            AuxClass.diagonalFc = Math.Pow((AuxClass.distancias[1, 0] * AuxClass.distancias[1, 0])
                  + (AuxClass.distancias[1, 1] * AuxClass.distancias[1, 1]), 0.5);
            AuxClass.anguloFcZemXY = obterAngulo(AuxClass.distancias[1, 2], AuxClass.diagonalFc);
            AuxClass.forcasDecompostas[1, 2] = -(AuxClass.forcaFc * (Math.Sin(AuxClass.anguloFcZemXY * Math.PI / 180)));
            AuxClass.forcaFcxy = AuxClass.forcaFc * (Math.Cos(AuxClass.anguloFcZemXY * Math.PI / 180));
            AuxClass.forcasDecompostas[1, 0] = (AuxClass.distancias[1, 0] * AuxClass.forcaFcxy) / AuxClass.diagonalFc;
            AuxClass.forcasDecompostas[1, 1] = (AuxClass.distancias[1, 1] * AuxClass.forcaFcxy) / AuxClass.diagonalFc;
        }

        //
        // Calcular os ângulos diretores de Fa
        //
        private void calculoAngulosDiretoresFa()
        {
            double anguloAuxiliarRadiano;
            for (int i = 0; i < 3; i++)
            {
                anguloAuxiliarRadiano = Math.Acos(AuxClass.forcasDecompostas[2, i] / AuxClass.forcaFa);
                AuxClass.angulosDiretoresFa[i] = (anguloAuxiliarRadiano * 180 / Math.PI);
            }
        }

        //
        // Método para Limpeza dos dados
        //
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDistanciaFbX.Text = "";
            txtDistanciaFbY.Text = "";
            txtDistanciaFcX.Text = "";
            txtDistanciaFcY.Text = "";
            txtDistanciaZ.Text = "";
            txtFb.Text = "";
            txtFc.Text = "";
        }

        //
        // Botão para começar a explicação
        //
        public void btnComecar_Click(object sender, EventArgs e)
        {
            Boolean comecar = checagemDados();
            if (comecar)
            {
                Form frmResolucao = new frmResolucao();
                Form frmMain = new frmMain();
                frmMain.Visible = false;
                frmResolucao.Show();
            }
        }

    }
}
