using System;
using System.Windows.Forms;

namespace FrustrationBot
{
    partial class GUI
    {
        private System.ComponentModel.IContainer components = null;
        private Boolean isRunning;


        protected override void OnLoad(EventArgs e)
        {
            isRunning = false;
            base.OnLoad(e);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart pulseChart;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.consoleTBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pulseChart
            // 
            chartArea2.AxisY.Maximum = 650D;
            chartArea2.AxisY.Minimum = 450D;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pulseChart.Legends.Add(legend2);
            this.pulseChart.Location = new System.Drawing.Point(12, 12);
            this.pulseChart.Name = "pulseChart";
            this.pulseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Pulse";
            series2.YValuesPerPoint = 4;
            this.pulseChart.Series.Add(series2);
            this.pulseChart.Size = new System.Drawing.Size(486, 426);
            this.pulseChart.TabIndex = 0;
            this.pulseChart.Text = "Pulse Chart";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(420, 372);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // consoleTBox
            // 
            this.consoleTBox.Location = new System.Drawing.Point(12, 444);
            this.consoleTBox.Multiline = true;
            this.consoleTBox.Name = "consoleTBox";
            this.consoleTBox.Size = new System.Drawing.Size(918, 173);
            this.consoleTBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.bpmLabel);
            this.panel1.Location = new System.Drawing.Point(936, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 605);
            this.panel1.TabIndex = 3;
            // 
            // bpmLabel
            // 
            this.bpmLabel.AutoSize = true;
            this.bpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmLabel.Location = new System.Drawing.Point(3, 0);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(103, 37);
            this.bpmLabel.TabIndex = 0;
            this.bpmLabel.Text = "BPM: ";
            this.bpmLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bpmLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(504, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 426);
            this.panel2.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(313, 381);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 42);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consoleTBox);
            this.Controls.Add(this.pulseChart);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private TextBox consoleTBox;
        private Panel panel1;
        private Label bpmLabel;
        private Panel panel2;
        private Button startButton;
    }
}