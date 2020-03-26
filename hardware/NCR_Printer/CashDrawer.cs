using System;
using System.IO.Ports;

namespace NCR_Printer
{
    public class CashDrawer : SerialPort
    {

        readonly Byte[] OPEN = { 0x1B, 0x70, 0x0, 0x10, 0xFA };

        public CashDrawer() : base("COM3", 9600, Parity.None, 8, StopBits.One)
        {
        }

        public void openDrawer()
        {
            Open();
            Write(OPEN, 0, OPEN.Length);
            Close();
        }
    }
}
