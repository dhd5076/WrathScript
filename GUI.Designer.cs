using System;
using System.Windows.Forms;

namespace FrustrationBot
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pulseChart
            // 
            chartArea1.AxisY.Maximum = 650D;
            chartArea1.AxisY.Minimum = 450D;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pulseChart.Legends.Add(legend1);
            this.pulseChart.Location = new System.Drawing.Point(12, 12);
            this.pulseChart.Name = "pulseChart";
            this.pulseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Pulse";
            series1.YValuesPerPoint = 4;
            this.pulseChart.Series.Add(series1);
            this.pulseChart.Size = new System.Drawing.Size(1059, 225);
            this.pulseChart.TabIndex = 0;
            this.pulseChart.Text = "Pulse Chart";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 450);
            this.Controls.Add(this.pulseChart);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pulseChart;

        public void UpdateChart(int pulseData)
        {
            pulseChart.Invoke((MethodInvoker)(() =>
            {
                if(pulseChart.Series["Pulse"].Points.Count > 300)
                {
                    pulseChart.Series["Pulse"].Points.RemoveAt(0);
                }
                if(pulseData > 400 && pulseData < 650) 
                pulseChart.Series["Pulse"].Points.Add(pulseData);
            }));

        }
    }
}