namespace Tyuiu.ArkhipovaMD.Sprint6.Task5.V29
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
            buttonOpen_AMD = new Button();
            buttonDo_AMD = new Button();
            dataGridView_AMD = new DataGridView();
            data = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            chart_AMD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_AMD).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen_AMD
            // 
            buttonOpen_AMD.Location = new Point(12, 12);
            buttonOpen_AMD.Name = "buttonOpen_AMD";
            buttonOpen_AMD.Size = new Size(105, 23);
            buttonOpen_AMD.TabIndex = 0;
            buttonOpen_AMD.Text = "open";
            buttonOpen_AMD.UseVisualStyleBackColor = true;
            buttonOpen_AMD.Click += buttonOpen_AMD_Click;
            // 
            // buttonDo_AMD
            // 
            buttonDo_AMD.Location = new Point(116, 12);
            buttonDo_AMD.Name = "buttonDo_AMD";
            buttonDo_AMD.Size = new Size(105, 23);
            buttonDo_AMD.TabIndex = 1;
            buttonDo_AMD.Text = "do";
            buttonDo_AMD.UseVisualStyleBackColor = true;
            buttonDo_AMD.Click += buttonDo_AMD_Click;
            // 
            // dataGridView_AMD
            // 
            dataGridView_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AMD.Columns.AddRange(new DataGridViewColumn[] { data, id });
            dataGridView_AMD.Location = new Point(12, 41);
            dataGridView_AMD.Name = "dataGridView_AMD";
            dataGridView_AMD.RowHeadersVisible = false;
            dataGridView_AMD.Size = new Size(214, 397);
            dataGridView_AMD.TabIndex = 2;
            // 
            // data
            // 
            data.HeaderText = "id";
            data.Name = "data";
            data.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "data";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // chart_AMD
            // 
            chartArea2.Name = "ChartArea1";
            chart_AMD.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_AMD.Legends.Add(legend2);
            chart_AMD.Location = new Point(232, 12);
            chart_AMD.Name = "chart_AMD";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_AMD.Series.Add(series2);
            chart_AMD.Size = new Size(556, 426);
            chart_AMD.TabIndex = 3;
            chart_AMD.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart_AMD);
            Controls.Add(dataGridView_AMD);
            Controls.Add(buttonDo_AMD);
            Controls.Add(buttonOpen_AMD);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_AMD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_AMD;
        private Button buttonDo_AMD;
        private DataGridView dataGridView_AMD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AMD;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn id;
    }
}
