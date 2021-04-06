using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace TesteComReal
{
    public static class Comunicacao
    {
        public static Boolean leitura;
        public static Parity paridade;
        public static StopBits stopBit;
        public static ushort ID, adress, length, baudRate;
        public static ushort wordLength;
        public static int scan, timeOut;
        public static string COM;

        /*public void Comunica()
        {
            using (SerialPort port = new SerialPort(cmbComunicacao.Text))
            {
                try
                {
                    port.BaudRate = 9600;
                    port.DataBits = 8;
                    port.Parity = Parity.None;
                    port.StopBits = StopBits.One;

                    port.Open();

                    IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                    byte slaveId = 1;
                    //ushort startAddress = 0;
                    ushort numRegisters = 8;


                    master.Transport.ReadTimeout = 500;

                    ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);

                    return registers;
                }
                catch
                {
                    return null;
                }
            }
        }*/
    }
}
