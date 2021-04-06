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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TesteComReal
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void menuAjuda_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autores: André Cini / Guilherme Turtera\n"
                + "Empresa: Presys Instrumentos e Sistemas Ltda.\n"
                + "Versão: 1.0", "AJUDA", MessageBoxButton.OK);
        }

        private void menuConectar_Click(object sender, RoutedEventArgs e) 
        {
            Window2 conectar = new Window2();
            conectar.ShowDialog();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menuEscreverRegistros_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void menuEscreverCoils_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
