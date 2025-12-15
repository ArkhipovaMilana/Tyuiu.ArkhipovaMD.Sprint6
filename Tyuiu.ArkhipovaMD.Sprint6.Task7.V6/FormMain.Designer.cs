namespace Tyuiu.ArkhipovaMD.Sprint6.Task7.V6
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
            dataGridViewInput_AMD = new DataGridView();
            dataGridViewOutput_AMD = new DataGridView();
            buttonOpen_AMD = new Button();
            buttonApply_AMD = new Button();
            buttonSave_AMD = new Button();
            openFileDialog_AMD = new OpenFileDialog();
            openFileDialogSave_AMD = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_AMD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_AMD).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInput_AMD
            // 
            dataGridViewInput_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_AMD.Location = new Point(12, 50);
            dataGridViewInput_AMD.Name = "dataGridViewInput_AMD";
            dataGridViewInput_AMD.Size = new Size(342, 388);
            dataGridViewInput_AMD.TabIndex = 0;
            // 
            // dataGridViewOutput_AMD
            // 
            dataGridViewOutput_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_AMD.Location = new Point(364, 50);
            dataGridViewOutput_AMD.Name = "dataGridViewOutput_AMD";
            dataGridViewOutput_AMD.Size = new Size(342, 388);
            dataGridViewOutput_AMD.TabIndex = 1;
            // 
            // buttonOpen_AMD
            // 
            buttonOpen_AMD.Location = new Point(12, 12);
            buttonOpen_AMD.Name = "buttonOpen_AMD";
            buttonOpen_AMD.Size = new Size(75, 23);
            buttonOpen_AMD.TabIndex = 2;
            buttonOpen_AMD.Text = "open";
            buttonOpen_AMD.UseVisualStyleBackColor = true;
            buttonOpen_AMD.Click += buttonOpen_AMD_Click;
            // 
            // buttonApply_AMD
            // 
            buttonApply_AMD.Enabled = false;
            buttonApply_AMD.Location = new Point(93, 12);
            buttonApply_AMD.Name = "buttonApply_AMD";
            buttonApply_AMD.Size = new Size(75, 23);
            buttonApply_AMD.TabIndex = 3;
            buttonApply_AMD.Text = "apply";
            buttonApply_AMD.UseVisualStyleBackColor = true;
            buttonApply_AMD.Click += buttonApply_AMD_Click;
            // 
            // buttonSave_AMD
            // 
            buttonSave_AMD.Location = new Point(183, 12);
            buttonSave_AMD.Name = "buttonSave_AMD";
            buttonSave_AMD.Size = new Size(75, 23);
            buttonSave_AMD.TabIndex = 4;
            buttonSave_AMD.Text = "save";
            buttonSave_AMD.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_AMD
            // 
            openFileDialog_AMD.FileName = "openFileDialog1";
            // 
            // openFileDialogSave_AMD
            // 
            openFileDialogSave_AMD.FileName = "openFileDialog2";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 450);
            Controls.Add(buttonSave_AMD);
            Controls.Add(buttonApply_AMD);
            Controls.Add(buttonOpen_AMD);
            Controls.Add(dataGridViewOutput_AMD);
            Controls.Add(dataGridViewInput_AMD);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_AMD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_AMD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewInput_AMD;
        private DataGridView dataGridViewOutput_AMD;
        private Button buttonOpen_AMD;
        private Button buttonApply_AMD;
        private Button buttonSave_AMD;
        private OpenFileDialog openFileDialog_AMD;
        private OpenFileDialog openFileDialogSave_AMD;
    }
}
