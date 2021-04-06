using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaizesReaisMetodos
{
    public partial class Form1 : Form
    {
        public string escolha;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EvalCSCode.Eval(txtFuncao.Text).ToString());

        }

        private void cmbSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += ".";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "-";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "÷";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "*";
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtFuncao.Text = "";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (txtFuncao.Text != "")
                txtFuncao.Text = txtFuncao.Text.Substring(0, txtFuncao.Text.Length - 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    btn0.PerformClick();
                    break;

                case Keys.NumPad1:
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                    
                case Keys.NumPad2:
                case Keys.D2:
                    btn2.PerformClick();
                    break;

                case Keys.NumPad3:
                case Keys.D3:
                    btn3.PerformClick();
                    break;

                case Keys.NumPad4:
                case Keys.D4:
                    btn4.PerformClick();
                    break;

                case Keys.NumPad5:
                case Keys.D5:
                    btn5.PerformClick();
                    break;

                case Keys.NumPad6:
                case Keys.D6:
                    btn6.PerformClick();
                    break;

                case Keys.NumPad7:
                case Keys.D7:
                    btn7.PerformClick();
                    break;

                case Keys.NumPad8:
                case Keys.D8:
                    btn8.PerformClick();
                    break;

                case Keys.NumPad9:
                case Keys.D9:
                    btn9.PerformClick();
                    break;

                case Keys.Multiply:
                    btnMultiplicacao.PerformClick();
                    break;

                case Keys.Add:
                    btnSoma.PerformClick();
                    break;

                case Keys.Subtract:
                    btnSubtracao.PerformClick();
                    break;

                case Keys.Divide:
                    btnDivisao.PerformClick();
                    break;

                case Keys.Back:
                    btnDEL.PerformClick();
                    break;

                case Keys.Delete:
                    btnAC.PerformClick();
                    break;

                case Keys.X:
                    btnx.PerformClick();
                    break;

                case Keys.Oemplus:
                    btnIgual.PerformClick();
                    break;

                case Keys.Oem102:
                    btnPAberto.PerformClick();
                    break;
                
            }

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "x";
        }

        private void btnPFechado_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += ")";
        }

        private void btnPAberto_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "(";
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Pow(";
            lblDicas.Text = "Math.Pow(Base, Expoente)";
            lblDicas.Visible = true;

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Sin(";
            lblDicas.Text = "Math.Sin(Número em RADIANO)";
            lblDicas.Visible = true;       
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Cos(";
            lblDicas.Text = "Math.Cos(Número em RADIANO)";
            lblDicas.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Tan(";
            lblDicas.Text = "Math.Tan(Número em RADIANO)";
            lblDicas.Visible = true;
        }

        private void btnArcsin_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Asin(";
            lblDicas.Text = "Math.Asin(Valor de sin)";
            lblDicas.Visible = true;
        }

        private void btnArccos_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Acos(";
            lblDicas.Text = "Math.Acos(Valor de cos)";
            lblDicas.Visible = true;
        }

        private void btnArctan_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Atan(";
            lblDicas.Text = "Math.Atan(Valor de tan)";
            lblDicas.Visible = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Boolean sai = false;
            string aux;
            double maior=0, menor=0, resultado=0, fmenor=0, fmaior=0, fresultado=0;
            try
            {
                menor = double.Parse(txtIntervalo1.Text);
                maior = double.Parse(txtIntervalo2.Text);
            }
            catch
            {
                sai = true;
                MessageBox.Show("DIGITE UM NÙMERO VÁLIDO!! ", "NÚMEROS INVÁLIDOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (!sai)
            {
                aux = DevolveFuncao(menor, txtFuncao.Text);
                fmenor = double.Parse(EvalCSCode.Eval(aux).ToString());
                aux = DevolveFuncao(maior, txtFuncao.Text);
                fmaior = double.Parse(EvalCSCode.Eval(aux).ToString());
                resultado = ((menor * fmaior) - (maior * fmenor)) / (fmaior-fmenor);
                aux = DevolveFuncao(resultado, txtFuncao.Text);
                fmaior = double.Parse(EvalCSCode.Eval(aux).ToString());

            }
        }

        static string DevolveFuncao(double valor, string texto) 
        {       
                string textoPronto = "";
                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto[i] != 'x')
                    {
                        textoPronto += texto[i];
                    }
                    else
                    {
                        textoPronto += valor.ToString();
                    }
                }

            return textoPronto;
        }

        private void btnNeperiano_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.E";
            lblDicas.Text = "Math.E --> já é o número neperiano";
            lblDicas.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.Exp(";
            lblDicas.Text = "Math.Exp(Expoente do número neperiano, que será a base. ";
            lblDicas.Visible = true;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtFuncao.Text += "Math.PI";
            lblDicas.Text = "Math.PI --> já é o próprio PI";
            lblDicas.Visible = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
                
        }

        

        
    }
}
