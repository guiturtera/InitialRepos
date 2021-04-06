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
using System.IO;
using System.Security.Cryptography;

namespace Criptografia
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        public byte[] iv = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

        public Window1()
        {
            InitializeComponent();
        }

        private void btnCriptografa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileStream myStream = new FileStream("Criptografado.txt", FileMode.OpenOrCreate);

                Aes aes = Aes.Create();

                CryptoStream cryptStream = new CryptoStream(
                    myStream,
                    aes.CreateEncryptor(key, iv),
                    CryptoStreamMode.Write);

                StreamWriter sWriter = new StreamWriter(cryptStream);

                sWriter.Write(txtEntrada.Text);

                sWriter.Close();
                cryptStream.Close();
                myStream.Close();
                
                MessageBox.Show("Sucesso ao Criptografar arquivo. ");
                
            }
            catch
            {  
                MessageBox.Show("Falha ao Criptografar arquivo. ");
            }
        }

        private void btnDescriptografa_Click(object sender, RoutedEventArgs e)
        {
            FileStream myStream = new FileStream("Criptografado.txt", FileMode.OpenOrCreate);

            Aes aes = Aes.Create();

            CryptoStream decryptStream = new CryptoStream(
                    myStream,
                    aes.CreateDecryptor(key, iv),
                    CryptoStreamMode.Read);

            StreamReader sReaderDecrypted = new StreamReader(decryptStream);
            StreamReader sReaderEncrypted = new StreamReader(myStream);

            txtDescriptografado.Text = sReaderDecrypted.ReadToEnd();

            decryptStream.Close();
            sReaderDecrypted.Close();
            myStream.Close();

            txtCriptografado.Text = File.ReadAllText("Criptografado.txt");

        }
    }
}
