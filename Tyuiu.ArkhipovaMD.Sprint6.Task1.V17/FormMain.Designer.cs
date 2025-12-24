namespace Tyuiu.ArkhipovaMD.Sprint6.Task1.V17
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
            textBox_AMD = new GroupBox();
            textBoxC_AMD = new GroupBox();
            textBoxCE_AMD = new TextBox();
            textBoxCS_AMD = new TextBox();
            richTextBoxOutput_AMD = new RichTextBox();
            buttonDO_AMD = new Button();
            buttonInfo_AMD = new Button();
            textBoxC_AMD.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_AMD
            // 
            textBox_AMD.Location = new Point(12, 76);
            textBox_AMD.Name = "textBox_AMD";
            textBox_AMD.Size = new Size(304, 301);
            textBox_AMD.TabIndex = 0;
            textBox_AMD.TabStop = false;
            textBox_AMD.Text = "Условие";
            // 
            // textBoxC_AMD
            // 
            textBoxC_AMD.Controls.Add(textBoxCE_AMD);
            textBoxC_AMD.Controls.Add(textBoxCS_AMD);
            textBoxC_AMD.Location = new Point(12, 383);
            textBoxC_AMD.Name = "textBoxC_AMD";
            textBoxC_AMD.Size = new Size(223, 55);
            textBoxC_AMD.TabIndex = 1;
            textBoxC_AMD.TabStop = false;
            textBoxC_AMD.Text = "Данные";
            // 
            // textBoxCE_AMD
            // 
            textBoxCE_AMD.Location = new Point(112, 22);
            textBoxCE_AMD.Name = "textBoxCE_AMD";
            textBoxCE_AMD.Size = new Size(100, 23);
            textBoxCE_AMD.TabIndex = 1;
            // 
            // textBoxCS_AMD
            // 
            textBoxCS_AMD.Location = new Point(6, 22);
            textBoxCS_AMD.Name = "textBoxCS_AMD";
            textBoxCS_AMD.Size = new Size(100, 23);
            textBoxCS_AMD.TabIndex = 0;
            // 
            // richTextBoxOutput_AMD
            // 
            richTextBoxOutput_AMD.HideSelection = false;
            richTextBoxOutput_AMD.Location = new Point(328, 12);
            richTextBoxOutput_AMD.Name = "richTextBoxOutput_AMD";
            richTextBoxOutput_AMD.ReadOnly = true;
            richTextBoxOutput_AMD.Size = new Size(460, 426);
            richTextBoxOutput_AMD.TabIndex = 2;
            richTextBoxOutput_AMD.Text = "";
            // 
            // buttonDO_AMD
            // 
            buttonDO_AMD.Location = new Point(241, 404);
            buttonDO_AMD.Name = "buttonDO_AMD";
            buttonDO_AMD.Size = new Size(75, 23);
            buttonDO_AMD.TabIndex = 3;
            buttonDO_AMD.Text = "Compile";
            buttonDO_AMD.UseVisualStyleBackColor = true;
            buttonDO_AMD.Click += buttonDO_AMD_Click;
            // 
            // buttonInfo_AMD
            // 
            buttonInfo_AMD.Location = new Point(18, 12);
            buttonInfo_AMD.Name = "buttonInfo_AMD";
            buttonInfo_AMD.Size = new Size(65, 58);
            buttonInfo_AMD.TabIndex = 4;
            buttonInfo_AMD.Text = "Info";
            buttonInfo_AMD.UseVisualStyleBackColor = true;
            buttonInfo_AMD.Click += buttonInfo_AMD_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_AMD);
            Controls.Add(buttonDO_AMD);
            Controls.Add(richTextBoxOutput_AMD);
            Controls.Add(textBoxC_AMD);
            Controls.Add(textBox_AMD);
            Name = "FormMain";
            Text = "Sprint1 | Task1 | V17 | ArkhipovaMD";
            textBoxC_AMD.ResumeLayout(false);
            textBoxC_AMD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox textBox_AMD;
        private GroupBox textBoxC_AMD;
        private TextBox textBoxCS_AMD;
        private TextBox textBoxCE_AMD;
        private RichTextBox richTextBoxOutput_AMD;
        private Button buttonDO_AMD;
        private Button buttonInfo_AMD;
    }
}
