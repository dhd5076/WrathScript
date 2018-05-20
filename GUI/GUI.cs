using FrustrationBot.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrustrationBot
{
    public partial class GUI : Form
    {
        private Boolean isRunning;
        private HRComReader hrComReader;

        public GUI()
        {
            isRunning = false;
            InitializeComponent();
            this.hrComReader = new HRComReader(this);
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            new Thread(hrComReader.Start).Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Updates the GUI with new heart rate data 
        /// </summary>
        /// <param name="pulseData">New pulse data points to plot</param>
        /// <param name="BPM">The current calculated BPM of the user</param>
        public void UpdateHeartDisplay(int pulseData, int BPM)
        {
            pulseChart.Invoke((MethodInvoker)(() =>
            {
                if (pulseChart.Series["Pulse"].Points.Count > 300)
                {
                    pulseChart.Series["Pulse"].Points.RemoveAt(0);
                }
                if (pulseData > 400 && pulseData < 650)
                    pulseChart.Series["Pulse"].Points.Add(pulseData);

                bpmLabel.Text = "BPM: " + BPM;
            }));
        }
    }
}
