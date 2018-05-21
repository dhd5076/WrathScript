using FrustrationBot.Input;
using FrustrationBot.Posts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrustrationBot
{
    /// <summary>
    /// The class responsible for displaying all the data being processed to the user
    /// </summary>
    public partial class GUI : Form
    {
        const string SUBREDDIT = "comedy";

        private Boolean isRunning;
        private HRComReader hrComReader;
        private TextWriter textWriter;
        private PostTracker postTracker;  

        /// <summary>
        /// Create a new GUI Instance
        /// </summary>
        public GUI()
        {
            isRunning = false;
            InitializeComponent();
            this.hrComReader = new HRComReader(this);
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            textWriter = new ConsoleWriter(consoleTBox);
            postTracker = new PostTracker(SUBREDDIT);
            Console.SetOut(textWriter);
            new Thread(hrComReader.Start).Start();
        }

        /// <summary>
        /// Called when the start button is clicked.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                new Thread(postTracker.Start).Start();
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
            }
            isRunning = !isRunning;
            startButton.Invoke((MethodInvoker)(() =>
            {
                if (isRunning)
                {
                    startButton.Text = "Reset";
                }else
                {
                    postTracker.Reset();
                    startButton.Text = "Start";
                }
            }));
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
            postTracker.getCurrentPost().AddBPM_Data(BPM);
        }

        private void titleText_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var processedPost = new ListViewItem(new string[] { postTracker.getCurrentPost().title, ((int)(postTracker.getCurrentPost().avgBPM)).ToString() });
            processedPosts.Items.Add(processedPost);
            this.postTracker.Next();
            try
            {
                titleText.Text = postTracker.getCurrentPost().title;
                textBox.Text = postTracker.getCurrentPost().text;
            }
            catch (Exception) { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void processedPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void processedPosts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
