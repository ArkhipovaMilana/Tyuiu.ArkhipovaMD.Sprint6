namespace Tyuiu.ArkhipovaMD.Sprint6.Task6.V29
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpen_AMD = new Button();
            panel1 = new Panel();
            buttonInfo_AMD = new Button();
            buttonDo_AMD = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            textBoxOut_AMD = new RichTextBox();
            groupBox_AMD = new GroupBox();
            textBoxIn_AMD = new RichTextBox();
            openFileDialogTask_AMD = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox_AMD.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen_AMD
            // 
            buttonOpen_AMD.Image = (Image)resources.GetObject("buttonOpen_AMD.Image");
            buttonOpen_AMD.Location = new Point(3, 3);
            buttonOpen_AMD.Name = "buttonOpen_AMD";
            buttonOpen_AMD.Size = new Size(85, 63);
            buttonOpen_AMD.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpen_AMD, "open file");
            buttonOpen_AMD.UseVisualStyleBackColor = true;
            buttonOpen_AMD.Click += buttonOpen_AMD_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonInfo_AMD);
            panel1.Controls.Add(buttonDo_AMD);
            panel1.Controls.Add(buttonOpen_AMD);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 75);
            panel1.TabIndex = 1;
            // 
            // buttonInfo_AMD
            // 
            buttonInfo_AMD.Image = (Image)resources.GetObject("buttonInfo_AMD.Image");
            buttonInfo_AMD.Location = new Point(714, 3);
            buttonInfo_AMD.Name = "buttonInfo_AMD";
            buttonInfo_AMD.Size = new Size(66, 63);
            buttonInfo_AMD.TabIndex = 2;
            buttonInfo_AMD.UseVisualStyleBackColor = true;
            buttonInfo_AMD.Click += buttonInfo_AMD_Click;
            // 
            // buttonDo_AMD
            // 
            buttonDo_AMD.Enabled = false;
            buttonDo_AMD.Image = (Image)resources.GetObject("buttonDo_AMD.Image");
            buttonDo_AMD.Location = new Point(94, 3);
            buttonDo_AMD.Name = "buttonDo_AMD";
            buttonDo_AMD.Size = new Size(85, 63);
            buttonDo_AMD.TabIndex = 1;
            toolTip1.SetToolTip(buttonDo_AMD, "run program");
            buttonDo_AMD.UseVisualStyleBackColor = true;
            buttonDo_AMD.Click += buttonDo_AMD_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 82);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox_AMD);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(787, 411);
            panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxOut_AMD);
            groupBox2.Location = new Point(399, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 399);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // textBoxOut_AMD
            // 
            textBoxOut_AMD.Location = new Point(6, 19);
            textBoxOut_AMD.Name = "textBoxOut_AMD";
            textBoxOut_AMD.ReadOnly = true;
            textBoxOut_AMD.Size = new Size(369, 374);
            textBoxOut_AMD.TabIndex = 0;
            textBoxOut_AMD.Text = "";
            // 
            // groupBox_AMD
            // 
            groupBox_AMD.Controls.Add(textBoxIn_AMD);
            groupBox_AMD.Location = new Point(12, 6);
            groupBox_AMD.Name = "groupBox_AMD";
            groupBox_AMD.Size = new Size(381, 402);
            groupBox_AMD.TabIndex = 1;
            groupBox_AMD.TabStop = false;
            groupBox_AMD.Text = "Ввод";
            // 
            // textBoxIn_AMD
            // 
            textBoxIn_AMD.Location = new Point(6, 22);
            textBoxIn_AMD.Name = "textBoxIn_AMD";
            textBoxIn_AMD.ReadOnly = true;
            textBoxIn_AMD.Size = new Size(369, 374);
            textBoxIn_AMD.TabIndex = 0;
            textBoxIn_AMD.Text = "";
            // 
            // openFileDialogTask_AMD
            // 
            openFileDialogTask_AMD.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 566);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox_AMD.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_AMD;
        private Panel panel1;
        private Button buttonDo_AMD;
        private Button buttonInfo_AMD;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private RichTextBox textBoxOut_AMD;
        private GroupBox groupBox_AMD;
        private RichTextBox textBoxIn_AMD;
        private OpenFileDialog openFileDialogTask_AMD;
        private ToolTip toolTip1;
    }
}
