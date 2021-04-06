using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace miniGame
{
    public partial class Form1 : Form
    {
        int velocidadeJogador = 10;
        int velocidadeInimigoVertical = 4, velocidadeInimigoHorizontal = -4;

        public Form1()
        {
            InitializeComponent();
        }

        public Boolean ColisaoParede() 
        {
            foreach (Control aux in Controls)
            {
                if ((string)aux.Tag == "wall")
                {
                    if (picJogador.Bounds.IntersectsWith(aux.Bounds))
                        return true;
                }
            }
            return false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            { 
                picJogador.Left += velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Left -= velocidadeJogador;   
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                picJogador.Left -= velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Left += velocidadeJogador; 
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                picJogador.Top -= velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Top += velocidadeJogador;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                picJogador.Top += velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Top -= velocidadeJogador;
            }
        }

        private void tmrMovimento_Tick(object sender, EventArgs e)
        {
            if (picJogador.Bounds.IntersectsWith(picInimigo.Bounds)) 
            {
                MessageBox.Show("GAME OVER! ");
            }
            picInimigo.Left += velocidadeInimigoHorizontal;
            picInimigo.Top += velocidadeInimigoVertical;

        }

        private void Verifica_Tick(object sender, EventArgs e)
        {
            if (picInimigo.Location.X >= picJogador.Location.X && velocidadeInimigoHorizontal > 0)
            {
                velocidadeInimigoHorizontal = -velocidadeInimigoHorizontal;
            }

            if (picInimigo.Location.X <= picJogador.Location.X && velocidadeInimigoHorizontal < 0)
            {
                velocidadeInimigoHorizontal = -velocidadeInimigoHorizontal;
            }

            if (picInimigo.Location.Y <= picJogador.Location.Y && velocidadeInimigoVertical < 0)
            {
                velocidadeInimigoVertical = -velocidadeInimigoVertical;
            }

            if (picInimigo.Location.Y >= picJogador.Location.Y && velocidadeInimigoVertical > 0)
            {
                velocidadeInimigoVertical = -velocidadeInimigoVertical;
            }
        }
    }
}
