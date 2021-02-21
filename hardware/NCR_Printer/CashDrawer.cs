using System;
using System.IO.Ports;
using System.Linq;

namespace NCR_Printer
{
    public class CashDrawer : SerialPort
    {

        public Byte[] OPEN = { 0x1B, 0x70, 0x0, 0x10, 0xFA };

        public CashDrawer() : base("COM3", 9600, Parity.None, 8, StopBits.One) {}
        public CashDrawer(string portName) : base(portName, 9600, Parity.None, 8, StopBits.One) {}

        public CashDrawer(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) 
            : base(portName, baudRate, parity, dataBits, stopBits) {}

        public Byte[] OpenCode
        {
            get
            {
                return OPEN;
            }
           set
            {
                OPEN = value;
            }
        }

        public string OpenCodeHexString
        {
            get
            {
                string result = "";

                for (int i = 0; i < OPEN.Length; i++)
                    result += OPEN[i].ToString();

                return result;
            }
            set
            {
                value.Replace(" ", "");
                OPEN = Enumerable.Range(0, value.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(value.Substring(x, 2), 16))
                                 .ToArray();
            }
        }

        public int[] OpenCodeIntArray
        {
            get
            {
                int[] result = new int[OPEN.Length]; 
                for (int i = 0; i < OPEN.Length; i++)
                    result[i] = OPEN[i];

                return result;
            }
            set
            {
                OPEN = new byte[value.Length * sizeof(int)];
                Buffer.BlockCopy(value, 0, OPEN, 0, OPEN.Length);
            }
        }

        public void OpenDrawer()
        {
            try
            {
                Open();
                Write(OPEN, 0, OPEN.Length);
                Close();
            }
            catch (System.IO.IOException e)
            {
                // COM3 is disconnected.
                // Can't connect to the cash drawer, but may still be able to print.
                throw (new Exception("Can't connect to the cash drawer, but may still be able to print. Check the Cable", e));
            }
            catch (UnauthorizedAccessException e)
            {
                // Something must be printing because the COM port is busy.
                // The door must already be open, so do nothing.
                throw (new Exception("Something must be printing because the COM port is busy.  The door must already be open, so do nothing.", e));
            }
            catch(Exception e)
            {
                throw (e);
            }
        }
    }
}
