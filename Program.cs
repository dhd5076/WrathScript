using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace FrustrationBot
{
    class Program
    {

        //Code to read serial data. Find out more at http://www.therobotlab.co.uk/2011/read-serial-c-sharp-arduino-tutorial/.
        //-------------------------------------------------------------------------------------------------------------------------------------
        //Set up the serial port. Use the following values for an Arduino, changing "COM3" to your own Serial Port.
        SerialPort sp = new SerialPort("COM3", 115200, Parity.None, 8, StopBits.One);
        GUI guiForm = new GUI();
        static void Main(string[] args)
        {
            new Program();
        }

        private Program()
        {
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            sp.Open();
            Application.Run(guiForm);
            Console.Read();
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int i = 0;
            try
            {
                Int32.TryParse(sp.ReadExisting().Split(',')[2], out i);
                guiForm.UpdateChart(i);
            }catch (Exception)
            {

            }
            
            Console.Write(sp.ReadExisting());
            Console.Write(sp.ReadExisting());
        }
    }
}
