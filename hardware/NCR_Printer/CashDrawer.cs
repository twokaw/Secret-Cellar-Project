using System;
using System.IO.Ports;

namespace NCR_Printer
{
    public class CashDrawer
    {
        SerialPort port;

        readonly Byte[] BEEP = { 0x1B, 0x07 };
        readonly Byte[] OPEN = { 0x1B, 0x70, 0x0, 0x10, 0xFA };

        public CashDrawer()
        {
            port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);

        }

        public void open()
        {
            port.Open();
            port.Write(BEEP, 0, BEEP.Length);
            port.Write(OPEN, 0, OPEN.Length);
            port.Close();
        }
    }
}
