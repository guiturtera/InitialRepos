using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using FtdAdapter;
using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;
using System.IO;


namespace NOVOTESTECOM
{
    public partial class Form1 : Form
    {

        public Boolean ativaLeitura = false;
        public Form1()
        {
            InitializeComponent();
            lblHorario.Text = (DateTime.Now.ToString("HH:mm:ss"));
            lblData.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Boolean validaCom = TesteComunicacao();
        }

        public Boolean TesteComunicacao() 
        {
            try
            {
                using (SerialPort port = new SerialPort(cmbComunicacao.Text))
                {
                    port.BaudRate = 9600;
                    port.DataBits = 8;
                    port.Parity = Parity.None;
                    port.StopBits = StopBits.One;
                    port.Open();
                }
                lblConectado.Visible = true;
                chkLeitura.Visible = true;
                lblDesconectado.Visible = false;
                cmbComunicacao.Enabled = false;

                return true;
            }
            catch 
            {
                MessageBox.Show("ERRO AO CONECTAR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                lblConectado.Visible = false;
                chkLeitura.Visible = false;
                lblDesconectado.Visible = true;

                return false;
            }
        }

        private void Data_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = (DateTime.Now.ToString("HH:mm:ss"));
            lblData.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
            if (ativaLeitura)
                ModbusSerialMasterReadInputsEspecial();
        }

        public void ModbusSerialMasterReadInputsEspecial() 
        {
            using (SerialPort port = new SerialPort(cmbComunicacao.Text))
            {
                // configure serial port
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Open();

                // create modbus master
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                byte slaveId = 1;
                ushort startAddress = 0;
                ushort numRegisters = 8;

                // read five registers		
                ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);

                lblCanal1.Text = registers[0].ToString();
                lblCanal2.Text = registers[1].ToString();
                lblCanal3.Text = registers[2].ToString();
                lblCanal4.Text = registers[3].ToString();
                lblCanal5.Text = registers[4].ToString();
                lblCanal6.Text = registers[5].ToString();
                lblCanal7.Text = registers[6].ToString();
                lblCanal8.Text = registers[7].ToString();
            }

        }

        private void chkLeitura_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeitura.Checked)
                ativaLeitura = true;
            else
                ativaLeitura = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chkLeitura.Checked = false;
            chkLeitura.Visible = false;
            lblDesconectado.Visible = true;
            lblConectado.Visible = false;
            cmbComunicacao.Enabled = true;
        }

        private void chkSalvamento_CheckedChanged(object sender, EventArgs e)
        {   try
            {
                if (chkSalvamento.Checked)
                {
                    timerSave.Interval = int.Parse(txtTempoSalvar.Text) * 1000;
                    timerSave.Enabled = true;
                }
                
                else
                {
                    timerSave.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Digite um tempo de salvamento válido. ", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            fldArquivo.Description = "Local de Salvamento";
            fldArquivo.ShowNewFolderButton = true;
            if (fldArquivo.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = fldArquivo.SelectedPath;
            } 

        }

        private void timerSave_Tick(object sender, EventArgs e)
        {

            string arquivo;
            if (txtArquivo.Text != "" && (cmbExtensao.Text == ".txt" || cmbExtensao.Text == ".csv"))
                arquivo = txtArquivo + "\\" + txtNomeArquivo.Text + lblData +  cmbExtensao.Text;
            else
                MessageBox.Show("Escreva o nome do arquivo! ", "Nome inexistente", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}