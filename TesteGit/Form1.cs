using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoIncerteza
{
    public partial class Form1 : Form
    {
        List<float> numeros = new List<float>();
        Calculos calcula = new Calculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtNum_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float aux;
            if (float.TryParse(txtNum.Text, out aux))
            {
                numeros.Add(aux);
                if (numeros.Count == 1)
                    txtVetor.Text += aux.ToString();
                else
                    txtVetor.Text += " ; " + aux.ToString();
            }
            else
                MessageBox.Show("Número inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            
        }

        private void btnInterpola_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(txtEngLow.Text) > float.Parse(txtEngHi.Text) || (float.Parse(txtMedidaLow.Text)) > (float.Parse(txtMedidaHi.Text)) ||
                    (float.Parse(txtMedida.Text)) > (float.Parse(txtMedidaHi.Text)) || (float.Parse(txtMedida.Text)) < (float.Parse(txtMedidaLow.Text)))
                    MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                else
                    txtResposta.Text = calcula.Interpolacao(float.Parse(txtMedidaHi.Text), float.Parse(txtMedidaLow.Text), float.Parse(txtEngHi.Text),
                        float.Parse(txtEngLow.Text), float.Parse(txtMedida.Text)).ToString();
            }
            catch 
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(calcula.Media(numeros.ToArray()).ToString());
            }
            catch 
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnLimparVetor_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            txtVetor.Text = "";
        }

        private void btnMediana_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(calcula.Mediana(numeros.ToArray()).ToString());
            }
            catch 
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auxStr = "";
            try
            {
                float[] aux = calcula.Moda(numeros.ToArray());
                if (aux.Length == 0)
                    MessageBox.Show("Não existe moda para seu grupo. ");
                else
                {
                    foreach (float a in aux)
                        auxStr += a.ToString() + ", ";
                    auxStr = auxStr.Substring(0, auxStr.Length - 2);
                    MessageBox.Show("Moda do vetor:\n" + auxStr);
                }

            }
            catch
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnDesvioPadrao_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(calcula.DesvioPadrao(numeros.ToArray()).ToString());
            }
            catch
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnTaxa_Click(object sender, EventArgs e)
        {
            try
            {
                txtTaxa.Text = calcula.Taxa(float.Parse(txtVP.Text), float.Parse(txtVF.Text), int.Parse(txtMeses.Text)).ToString();
            }
            catch 
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            txtVP.BackColor = System.Drawing.Color.WhiteSmoke;
            txtVF.BackColor = System.Drawing.Color.WhiteSmoke;
            txtMeses.BackColor = System.Drawing.Color.WhiteSmoke;
            txtTaxa.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtMeses.Text = calcula.Meses(float.Parse(txtTaxa.Text), float.Parse(txtVP.Text), float.Parse(txtVF.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            txtVP.BackColor = System.Drawing.Color.WhiteSmoke;
            txtVF.BackColor = System.Drawing.Color.WhiteSmoke;
            txtTaxa.BackColor = System.Drawing.Color.WhiteSmoke;
            txtMeses.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void btnVF_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtVF.Text = calcula.VF(float.Parse(txtTaxa.Text), float.Parse(txtVP.Text), int.Parse(txtMeses.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            txtVP.BackColor = System.Drawing.Color.WhiteSmoke;
            txtTaxa.BackColor = System.Drawing.Color.WhiteSmoke;
            txtMeses.BackColor = System.Drawing.Color.WhiteSmoke;
            txtVF.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void btnVP_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtVP.Text = calcula.VP(float.Parse(txtTaxa.Text), float.Parse(txtVF.Text), int.Parse(txtMeses.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("ERRO! Digite números válidos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            txtTaxa.BackColor = System.Drawing.Color.WhiteSmoke;
            txtVF.BackColor = System.Drawing.Color.WhiteSmoke;
            txtMeses.BackColor = System.Drawing.Color.WhiteSmoke;
            txtVP.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtVetor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedida_TextChanged(object sender, EventArgs e)
        {

        }

      

    }
}
