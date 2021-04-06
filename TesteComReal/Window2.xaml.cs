using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO.Ports;

namespace TesteComReal
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] vetor = SerialPort.GetPortNames();
            foreach (string aux in vetor)
                cmbCOM.Items.Add(aux);
            
            // Padrão para teste
            cmbCOM.Text = "COM4";

            // Valores padrão
            cmbTransmissao.Text = "9600";
            rbtn8bits.IsChecked = true;
            rbtnStopBit1.IsChecked = true;
            rbtnSemParidade.IsChecked = true;
            rbtnRTU.IsChecked = true;
            txtTempoLimite.Text = "300";
        }

        private void rbtnRTU_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void rbtnAscii_Checked(object sender, RoutedEventArgs e)
        {
            rbtnRTU.IsChecked = true;
            MessageBox.Show("LEITURA ASCII NÃO DISPONÍVEL! ", "INDISPONÍVEL");
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (ChecaCampos() && AtualizaDados())
                this.Close();
            else 
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CORRETAMENTE!", "PREENCHA CORRETAMENTE", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        public Boolean ChecaCampos() 
        {
            if (cmbTransmissao.Text != "" && cmbCOM.Text != "" && txtTempoLimite.Text != "")
                return true;

            return false;
        }

        public Boolean AtualizaDados()
        {
            try
            {
                Comunicacao.COM = cmbCOM.Text;
                Comunicacao.baudRate = ushort.Parse(cmbTransmissao.Text);

                if (rbtn8bits.IsChecked == true) Comunicacao.wordLength = 8;
                else Comunicacao.wordLength = 7;

                if (rbtnStopBit1.IsChecked == true) Comunicacao.stopBit = StopBits.One;
                else Comunicacao.stopBit = StopBits.Two;

                if (rbtnParidadeImpar.IsChecked == true) Comunicacao.paridade = Parity.Odd;
                else if (rbtnParidadePar.IsChecked == true) Comunicacao.paridade = Parity.Even;
                else Comunicacao.paridade = Parity.None;

                Comunicacao.timeOut = int.Parse(txtTempoLimite.Text);

                if (Comunicacao.timeOut < 100) 
                {
                    txtTempoLimite.Text = "300";
                    return false; 
                } 

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
