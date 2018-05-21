using System;
using System.Windows.Forms;

namespace FrustrationBot
{
    partial class GUI
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataVisualization.Charting.Chart pulseChart;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Title 1 Here",
            "120"}, -1);
            this.pulseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.consoleTBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.processedPosts = new System.Windows.Forms.ListView();
            this.postHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BPMHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pulseChart
            // 
            this.pulseChart.BackColor = System.Drawing.Color.Black;
            this.pulseChart.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            this.pulseChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisY.Maximum = 650D;
            chartArea3.AxisY.Minimum = 450D;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.pulseChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pulseChart.Legends.Add(legend3);
            this.pulseChart.Location = new System.Drawing.Point(12, 12);
            this.pulseChart.Name = "pulseChart";
            this.pulseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Pulse";
            series3.YValuesPerPoint = 4;
            this.pulseChart.Series.Add(series3);
            this.pulseChart.Size = new System.Drawing.Size(486, 426);
            this.pulseChart.TabIndex = 0;
            this.pulseChart.Text = "Pulse Chart";
            // 
            // consoleTBox
            // 
            this.consoleTBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.consoleTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.consoleTBox.Location = new System.Drawing.Point(12, 444);
            this.consoleTBox.Multiline = true;
            this.consoleTBox.Name = "consoleTBox";
            this.consoleTBox.ReadOnly = true;
            this.consoleTBox.Size = new System.Drawing.Size(486, 495);
            this.consoleTBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.processedPosts);
            this.panel1.Controls.Add(this.bpmLabel);
            this.panel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(1245, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 927);
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
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.titleText);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(504, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 927);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 554);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox.Location = new System.Drawing.Point(8, 29);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(717, 845);
            this.textBox.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Enabled = false;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.nextButton.Location = new System.Drawing.Point(8, 880);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(110, 42);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.ForestGreen;
            this.titleText.Location = new System.Drawing.Point(3, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(141, 25);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "[TITLE TEXT]";
            this.titleText.Click += new System.EventHandler(this.titleText_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.startButton.Location = new System.Drawing.Point(615, 880);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(110, 42);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // processedPosts
            // 
            this.processedPosts.BackColor = System.Drawing.SystemColors.MenuText;
            this.processedPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.postHeader,
            this.BPMHeader});
            this.processedPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processedPosts.ForeColor = System.Drawing.Color.ForestGreen;
            this.processedPosts.FullRowSelect = true;
            this.processedPosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.processedPosts.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            this.processedPosts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.processedPosts.Location = new System.Drawing.Point(10, 40);
            this.processedPosts.MultiSelect = false;
            this.processedPosts.Name = "processedPosts";
            this.processedPosts.ShowGroups = false;
            this.processedPosts.Size = new System.Drawing.Size(356, 882);
            this.processedPosts.TabIndex = 1;
            this.processedPosts.UseCompatibleStateImageBehavior = false;
            this.processedPosts.View = System.Windows.Forms.View.Details;
            this.processedPosts.SelectedIndexChanged += new System.EventHandler(this.processedPosts_SelectedIndexChanged_1);
            // 
            // postHeader
            // 
            this.postHeader.Text = "Post";
            this.postHeader.Width = 241;
            // 
            // BPMHeader
            // 
            this.BPMHeader.Text = "Average BPM";
            this.BPMHeader.Width = 110;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1628, 951);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consoleTBox);
            this.Controls.Add(this.pulseChart);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI";
            this.Text = "WrathScript 0.2.5 - Dylan Dunn";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulseChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox consoleTBox;
        private Panel panel1;
        private Label bpmLabel;
        private Panel panel2;
        private Button startButton;
        private Label titleText;
        private Button nextButton;
        private TextBox textBox;
        private PictureBox pictureBox1;
        private ListView processedPosts;
        private ColumnHeader postHeader;
        private ColumnHeader BPMHeader;
    }
}