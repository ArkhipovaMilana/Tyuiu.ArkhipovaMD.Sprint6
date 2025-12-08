namespace Tyuiu.ArkhipovaMD.Sprint6.Task4.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            richTextBoxResult_AMD = new RichTextBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            buttonSave_AMD = new Button();
            textBoxStop_AMD = new TextBox();
            textBoxStart_AMD = new TextBox();
            buttonInfo_AMD = new Button();
            buttonDo_AMD = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(207, 28);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(563, 298);
            chart1.TabIndex = 0;
            chart1.Text = "график";
            // 
            // richTextBoxResult_AMD
            // 
            richTextBoxResult_AMD.Location = new Point(6, 28);
            richTextBoxResult_AMD.Name = "richTextBoxResult_AMD";
            richTextBoxResult_AMD.ReadOnly = true;
            richTextBoxResult_AMD.Size = new Size(195, 298);
            richTextBoxResult_AMD.TabIndex = 1;
            richTextBoxResult_AMD.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(buttonSave_AMD);
            groupBox1.Controls.Add(textBoxStop_AMD);
            groupBox1.Controls.Add(textBoxStart_AMD);
            groupBox1.Controls.Add(buttonInfo_AMD);
            groupBox1.Controls.Add(buttonDo_AMD);
            groupBox1.Location = new Point(219, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 94);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(112, 22);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 16);
            textBox4.TabIndex = 6;
            textBox4.Text = "Конец :";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 5;
            textBox3.Text = "Старт :";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonSave_AMD
            // 
            buttonSave_AMD.BackColor = Color.FromArgb(255, 255, 192);
            buttonSave_AMD.Location = new Point(312, 22);
            buttonSave_AMD.Name = "buttonSave_AMD";
            buttonSave_AMD.Size = new Size(88, 53);
            buttonSave_AMD.TabIndex = 0;
            buttonSave_AMD.Text = "Сохранить";
            buttonSave_AMD.UseVisualStyleBackColor = false;
            buttonSave_AMD.Click += buttonSave_AMD_Click;
            // 
            // textBoxStop_AMD
            // 
            textBoxStop_AMD.Location = new Point(112, 44);
            textBoxStop_AMD.Name = "textBoxStop_AMD";
            textBoxStop_AMD.Size = new Size(100, 23);
            textBoxStop_AMD.TabIndex = 4;
            // 
            // textBoxStart_AMD
            // 
            textBoxStart_AMD.Location = new Point(6, 44);
            textBoxStart_AMD.Name = "textBoxStart_AMD";
            textBoxStart_AMD.Size = new Size(100, 23);
            textBoxStart_AMD.TabIndex = 3;
            // 
            // buttonInfo_AMD
            // 
            buttonInfo_AMD.BackColor = Color.FromArgb(192, 192, 255);
            buttonInfo_AMD.Location = new Point(406, 22);
            buttonInfo_AMD.Name = "buttonInfo_AMD";
            buttonInfo_AMD.Size = new Size(88, 53);
            buttonInfo_AMD.TabIndex = 2;
            buttonInfo_AMD.Text = "Справка";
            buttonInfo_AMD.UseVisualStyleBackColor = false;
            buttonInfo_AMD.Click += buttonInfo_AMD_Click;
            // 
            // buttonDo_AMD
            // 
            buttonDo_AMD.BackColor = Color.FromArgb(192, 255, 192);
            buttonDo_AMD.Location = new Point(218, 22);
            buttonDo_AMD.Name = "buttonDo_AMD";
            buttonDo_AMD.Size = new Size(88, 53);
            buttonDo_AMD.TabIndex = 1;
            buttonDo_AMD.Text = "Выполнить";
            buttonDo_AMD.UseVisualStyleBackColor = false;
            buttonDo_AMD.Click += buttonDo_AMD_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxResult_AMD);
            groupBox2.Controls.Add(chart1);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(785, 340);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(201, 94);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "условие";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 109);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 255);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(7, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 340);
            panel2.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 462);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(500, 200);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6, таск 4, вариант 17";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RichTextBox richTextBoxResult_AMD;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxStop_AMD;
        private TextBox textBoxStart_AMD;
        private Button buttonInfo_AMD;
        private Button buttonDo_AMD;
        private Button buttonSave_AMD;
        private TextBox textBox4;
        private TextBox textBox3;
        private Panel panel1;
        private Panel panel2;
    }
}
