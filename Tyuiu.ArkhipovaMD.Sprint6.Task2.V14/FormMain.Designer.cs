namespace Tyuiu.ArkhipovaMD.Sprint6.Task2.V14
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
            groupBox1 = new GroupBox();
            textBoxC_AMD = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStop_AMD = new TextBox();
            textBoxStart_AMD = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView_AMD = new DataGridView();
            buttonHelp_AMD = new Button();
            buttonDo_AMD = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxC_AMD);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 357);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBoxC_AMD
            // 
            textBoxC_AMD.BorderStyle = BorderStyle.None;
            textBoxC_AMD.Location = new Point(6, 22);
            textBoxC_AMD.Name = "textBoxC_AMD";
            textBoxC_AMD.ReadOnly = true;
            textBoxC_AMD.Size = new Size(100, 16);
            textBoxC_AMD.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStop_AMD);
            groupBox2.Controls.Add(textBoxStart_AMD);
            groupBox2.Location = new Point(12, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 63);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStop_AMD
            // 
            textBoxStop_AMD.Location = new Point(112, 22);
            textBoxStop_AMD.Name = "textBoxStop_AMD";
            textBoxStop_AMD.Size = new Size(100, 23);
            textBoxStop_AMD.TabIndex = 1;
            // 
            // textBoxStart_AMD
            // 
            textBoxStart_AMD.Location = new Point(6, 22);
            textBoxStart_AMD.Name = "textBoxStart_AMD";
            textBoxStart_AMD.Size = new Size(100, 23);
            textBoxStart_AMD.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView_AMD);
            groupBox3.Location = new Point(443, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(633, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // dataGridView_AMD
            // 
            dataGridView_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AMD.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridView_AMD.Location = new Point(6, 22);
            dataGridView_AMD.Name = "dataGridView_AMD";
            dataGridView_AMD.RowHeadersVisible = false;
            dataGridView_AMD.Size = new Size(140, 398);
            dataGridView_AMD.TabIndex = 0;
            // 
            // buttonHelp_AMD
            // 
            buttonHelp_AMD.Location = new Point(255, 384);
            buttonHelp_AMD.Name = "buttonHelp_AMD";
            buttonHelp_AMD.Size = new Size(75, 54);
            buttonHelp_AMD.TabIndex = 3;
            buttonHelp_AMD.Text = "Справка";
            buttonHelp_AMD.UseVisualStyleBackColor = true;
            buttonHelp_AMD.Click += buttonHelp_AMD_Click;
            // 
            // buttonDo_AMD
            // 
            buttonDo_AMD.Location = new Point(336, 384);
            buttonDo_AMD.Name = "buttonDo_AMD";
            buttonDo_AMD.Size = new Size(101, 54);
            buttonDo_AMD.TabIndex = 4;
            buttonDo_AMD.Text = "Выполнить";
            buttonDo_AMD.UseVisualStyleBackColor = true;
            buttonDo_AMD.Click += buttonDo_AMD_Click;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 70;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.ReadOnly = true;
            F.Width = 70;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 450);
            Controls.Add(buttonDo_AMD);
            Controls.Add(buttonHelp_AMD);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonHelp_AMD;
        private Button buttonDo_AMD;
        private TextBox textBoxC_AMD;
        private TextBox textBoxStop_AMD;
        private TextBox textBoxStart_AMD;
        private DataGridView dataGridView_AMD;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
