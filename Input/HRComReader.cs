using System;
using System.IO.Ports;

namespace FrustrationBot.Input
{
    class HRComReader
    {
        const string COM_PORT = "COM3";
        SerialPort sp = new SerialPort(COM_PORT, 115200, Parity.None, 8, StopBits.One);
        GUI guiForm; 

        /// <summary>
        /// Makes a new heart rate serial port reader
        /// </summary>
        /// <param name="guiForm"></param>
        public HRComReader(GUI guiForm)
        {
            this.guiForm = guiForm;
            sp.DataReceived += new SerialDataReceivedEventHandler(Sp_DataReceived);
            sp.Open();
            Console.Read();
        }

        /// <summary>
        /// The method called when new data is received on the Serial Port
        /// Calls the GUI's update method with the new heart rate data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var pulseData = 0;
            var bpmData = 0;
            try
            {
                var rawData = sp.ReadExisting();
                Int32.TryParse(rawData.Split(',')[2], out pulseData);
                Int32.TryParse(rawData.Split(',')[0], out bpmData);
                guiForm.UpdateHeartDisplay(pulseData, bpmData);
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
            Console.Write(sp.ReadExisting());
        }
    }
}
