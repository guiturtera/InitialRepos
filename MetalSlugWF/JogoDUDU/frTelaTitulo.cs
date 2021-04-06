﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JogoDUDU
{
    public partial class frTelaTitulo : Form
    {
        Boolean configOk;
        public frTelaTitulo()
        {
            InitializeComponent();
            string conteudo = "dinheiro\n0";
            configOk = false;
            PadraoAliados();

            if (!File.Exists("dados.txt"))
            { 
                File.WriteAllText("dados.txt", conteudo);
            }

            string[] dados = File.ReadAllLines("dados.txt");
            if (dados.Length <= 1)
            {
                File.WriteAllText("dados.txt", conteudo);
                dados = File.ReadAllLines("dados.txt");
            }

            int aux;

            if (!int.TryParse(dados[1], out aux))
            {
                File.WriteAllText("dados.txt", conteudo);
                dados = File.ReadAllLines("dados.txt");
                MessageBox.Show("O arquivo de dados aparenta estar corrompido. Portanto, ele será refeito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GlobalConfig.dinheiro = int.Parse(dados[1]);
        }

        public void PadraoAliados()
        {
            DadosSkin.chaveBala = "machado2";
            DadosSkin.chaveInimigo = "darthVader";
            DadosSkin.chaveJogador = "loki";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que já quer sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picAjuda_Click(object sender, EventArgs e)
        {
            frAjuda telaAjuda = new frAjuda();
            telaAjuda.ShowDialog();
        }

        private void picLoja_Click(object sender, EventArgs e)
        {
            frLoja telaLoja = new frLoja();
            telaLoja.ShowDialog();
        }

        private void btnConfigs_Click(object sender, EventArgs e)
        {
            frConfigs telaConfigs = new frConfigs();
            telaConfigs.ShowDialog();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            configOk = true;
            if (!configOk) MessageBox.Show("Escolha suas configurações! ","Configurações inválidas" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                frJogoPrincipal jogo = new frJogoPrincipal();
                Hide();
                jogo.ShowDialog();
                Show();
            }
        }

        private void btnApostas_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.dinheiro >= 10)
            {
                frAposta aposta = new frAposta();
                Hide();
                aposta.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Junte mais de 10 moedas para apostar na corrida de cavalos! ", "Dinheiro Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
