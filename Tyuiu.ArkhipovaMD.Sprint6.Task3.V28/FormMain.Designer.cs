namespace Tyuiu.ArkhipovaMD.Sprint6.Task3.V28
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
            groupBoxC_AMD = new GroupBox();
            label1 = new Label();
            buttonInfo_AMD = new Button();
            dataGridView_AMD = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBoxO_AMD = new GroupBox();
            textBoxRes_AMD = new TextBox();
            buttonDo_AMD = new Button();
            groupBoxC_AMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).BeginInit();
            groupBoxO_AMD.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxC_AMD
            // 
            groupBoxC_AMD.Controls.Add(label1);
            groupBoxC_AMD.Location = new Point(12, 12);
            groupBoxC_AMD.Name = "groupBoxC_AMD";
            groupBoxC_AMD.Size = new Size(201, 310);
            groupBoxC_AMD.TabIndex = 0;
            groupBoxC_AMD.TabStop = false;
            groupBoxC_AMD.Text = "Условие";
            // 
            // label1
            // 
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(189, 177);
            label1.TabIndex = 0;
            label1.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0.\r\n-9   8   9  16 -18\r\n\r\n -13 -11 -20 -15   9\r\n\r\n  18  13 -12 -15 -11\r\n\r\n  10  -2  19  -4 -10\r\n\r\n   6 -20  -4  13 -14\r\n";
            // 
            // buttonInfo_AMD
            // 
            buttonInfo_AMD.Location = new Point(579, 299);
            buttonInfo_AMD.Name = "buttonInfo_AMD";
            buttonInfo_AMD.Size = new Size(75, 23);
            buttonInfo_AMD.TabIndex = 1;
            buttonInfo_AMD.Text = "Инфо";
            buttonInfo_AMD.UseVisualStyleBackColor = true;
            buttonInfo_AMD.Click += button1_Click;
            // 
            // dataGridView_AMD
            // 
            dataGridView_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AMD.ColumnHeadersVisible = false;
            dataGridView_AMD.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView_AMD.Location = new Point(233, 34);
            dataGridView_AMD.Name = "dataGridView_AMD";
            dataGridView_AMD.RowHeadersVisible = false;
            dataGridView_AMD.Size = new Size(324, 288);
            dataGridView_AMD.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // groupBoxO_AMD
            // 
            groupBoxO_AMD.Controls.Add(textBoxRes_AMD);
            groupBoxO_AMD.Location = new Point(563, 12);
            groupBoxO_AMD.Name = "groupBoxO_AMD";
            groupBoxO_AMD.Size = new Size(201, 131);
            groupBoxO_AMD.TabIndex = 1;
            groupBoxO_AMD.TabStop = false;
            groupBoxO_AMD.Text = "Вывод";
            // 
            // textBoxRes_AMD
            // 
            textBoxRes_AMD.Location = new Point(50, 59);
            textBoxRes_AMD.Name = "textBoxRes_AMD";
            textBoxRes_AMD.Size = new Size(100, 23);
            textBoxRes_AMD.TabIndex = 0;
            // 
            // buttonDo_AMD
            // 
            buttonDo_AMD.Location = new Point(689, 299);
            buttonDo_AMD.Name = "buttonDo_AMD";
            buttonDo_AMD.Size = new Size(75, 23);
            buttonDo_AMD.TabIndex = 2;
            buttonDo_AMD.Text = "Выполнить";
            buttonDo_AMD.UseVisualStyleBackColor = true;
            buttonDo_AMD.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 335);
            Controls.Add(buttonDo_AMD);
            Controls.Add(buttonInfo_AMD);
            Controls.Add(dataGridView_AMD);
            Controls.Add(groupBoxO_AMD);
            Controls.Add(groupBoxC_AMD);
            Name = "FormMain";
            Text = "Form1";
            groupBoxC_AMD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).EndInit();
            groupBoxO_AMD.ResumeLayout(false);
            groupBoxO_AMD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxC_AMD;
        private DataGridView dataGridView_AMD;
        private Button buttonInfo_AMD;
        private GroupBox groupBoxO_AMD;
        private TextBox textBoxRes_AMD;
        private Button buttonDo_AMD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
