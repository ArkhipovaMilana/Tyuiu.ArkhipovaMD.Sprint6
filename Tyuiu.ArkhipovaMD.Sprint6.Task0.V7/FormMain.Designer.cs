
namespace Tyuiu.ArkhipovaMD.Sprint6.Task0.V7
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
            GroupBoxCondition_AMD = new GroupBox();
            PictureBoxCondition_AMD = new PictureBox();
            TextBoxCondition_AMD = new TextBox();
            groupBoxInput_AMD = new GroupBox();
            textBoxInput_AMD = new TextBox();
            inputBoxInput_AMD = new TextBox();
            groupBoxOutput_AMD = new GroupBox();
            buttonOutput_AMD = new Button();
            textBoxOutput_AMD = new TextBox();
            GroupBoxCondition_AMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCondition_AMD).BeginInit();
            groupBoxInput_AMD.SuspendLayout();
            groupBoxOutput_AMD.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxCondition_AMD
            // 
            GroupBoxCondition_AMD.Controls.Add(PictureBoxCondition_AMD);
            GroupBoxCondition_AMD.Controls.Add(TextBoxCondition_AMD);
            GroupBoxCondition_AMD.Location = new Point(12, 12);
            GroupBoxCondition_AMD.Name = "GroupBoxCondition_AMD";
            GroupBoxCondition_AMD.Size = new Size(479, 168);
            GroupBoxCondition_AMD.TabIndex = 0;
            GroupBoxCondition_AMD.TabStop = false;
            GroupBoxCondition_AMD.Text = "Условие";
            // 
            // PictureBoxCondition_AMD
            // 
            PictureBoxCondition_AMD.Image = Properties.Resources.unnamed;
            PictureBoxCondition_AMD.Location = new Point(325, 36);
            PictureBoxCondition_AMD.Name = "PictureBoxCondition_AMD";
            PictureBoxCondition_AMD.Size = new Size(133, 70);
            PictureBoxCondition_AMD.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxCondition_AMD.TabIndex = 1;
            PictureBoxCondition_AMD.TabStop = false;
            // 
            // TextBoxCondition_AMD
            // 
            TextBoxCondition_AMD.BorderStyle = BorderStyle.None;
            TextBoxCondition_AMD.Location = new Point(21, 36);
            TextBoxCondition_AMD.Name = "TextBoxCondition_AMD";
            TextBoxCondition_AMD.ReadOnly = true;
            TextBoxCondition_AMD.Size = new Size(260, 16);
            TextBoxCondition_AMD.TabIndex = 0;
            TextBoxCondition_AMD.Text = "программа вычисляет результат по формуле";
            // 
            // groupBoxInput_AMD
            // 
            groupBoxInput_AMD.Controls.Add(textBoxInput_AMD);
            groupBoxInput_AMD.Controls.Add(inputBoxInput_AMD);
            groupBoxInput_AMD.Location = new Point(18, 210);
            groupBoxInput_AMD.Name = "groupBoxInput_AMD";
            groupBoxInput_AMD.Size = new Size(281, 164);
            groupBoxInput_AMD.TabIndex = 1;
            groupBoxInput_AMD.TabStop = false;
            groupBoxInput_AMD.Text = "Ввод данных";
            // 
            // textBoxInput_AMD
            // 
            textBoxInput_AMD.BorderStyle = BorderStyle.None;
            textBoxInput_AMD.Location = new Point(15, 22);
            textBoxInput_AMD.Name = "textBoxInput_AMD";
            textBoxInput_AMD.ReadOnly = true;
            textBoxInput_AMD.Size = new Size(260, 16);
            textBoxInput_AMD.TabIndex = 1;
            textBoxInput_AMD.Text = "введите значение  x";
            // 
            // inputBoxInput_AMD
            // 
            inputBoxInput_AMD.Location = new Point(21, 53);
            inputBoxInput_AMD.Name = "inputBoxInput_AMD";
            inputBoxInput_AMD.Size = new Size(100, 23);
            inputBoxInput_AMD.TabIndex = 0;
            inputBoxInput_AMD.TextChanged += inputBoxInput_AMD_TextChanged_1;
            inputBoxInput_AMD.KeyPress += inputBoxInput_AMD_KeyPress;
            // 
            // groupBoxOutput_AMD
            // 
            groupBoxOutput_AMD.Controls.Add(buttonOutput_AMD);
            groupBoxOutput_AMD.Controls.Add(textBoxOutput_AMD);
            groupBoxOutput_AMD.Location = new Point(337, 210);
            groupBoxOutput_AMD.Name = "groupBoxOutput_AMD";
            groupBoxOutput_AMD.Size = new Size(208, 164);
            groupBoxOutput_AMD.TabIndex = 2;
            groupBoxOutput_AMD.TabStop = false;
            groupBoxOutput_AMD.Text = "Вывод Данных";
            // 
            // buttonOutput_AMD
            // 
            buttonOutput_AMD.Location = new Point(127, 135);
            buttonOutput_AMD.Name = "buttonOutput_AMD";
            buttonOutput_AMD.Size = new Size(75, 23);
            buttonOutput_AMD.TabIndex = 1;
            buttonOutput_AMD.Text = "button1";
            buttonOutput_AMD.UseVisualStyleBackColor = true;
            buttonOutput_AMD.Click += buttonOutput_AMD_Click;
            // 
            // textBoxOutput_AMD
            // 
            textBoxOutput_AMD.Location = new Point(63, 53);
            textBoxOutput_AMD.Name = "textBoxOutput_AMD";
            textBoxOutput_AMD.ReadOnly = true;
            textBoxOutput_AMD.Size = new Size(100, 23);
            textBoxOutput_AMD.TabIndex = 0;
            textBoxOutput_AMD.TextChanged += textBoxOutput_AMD_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 417);
            Controls.Add(groupBoxOutput_AMD);
            Controls.Add(groupBoxInput_AMD);
            Controls.Add(GroupBoxCondition_AMD);
            Name = "FormMain";
            Text = "Form1";
            GroupBoxCondition_AMD.ResumeLayout(false);
            GroupBoxCondition_AMD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCondition_AMD).EndInit();
            groupBoxInput_AMD.ResumeLayout(false);
            groupBoxInput_AMD.PerformLayout();
            groupBoxOutput_AMD.ResumeLayout(false);
            groupBoxOutput_AMD.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void inputBoxInput_AMD_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox GroupBoxCondition_AMD;
        private PictureBox PictureBoxCondition_AMD;
        private TextBox TextBoxCondition_AMD;
        private GroupBox groupBoxInput_AMD;
        private TextBox textBoxInput_AMD;
        private TextBox inputBoxInput_AMD;
        private GroupBox groupBoxOutput_AMD;
        private Button buttonOutput_AMD;
        private TextBox textBoxOutput_AMD;
    }
}
