using Tyuiu.ArkhipovaMD.Sprint6.Task6.V29.Lib;

namespace Tyuiu.ArkhipovaMD.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        string filepath;
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonOpen_AMD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AMD.ShowDialog();
            filepath = openFileDialogTask_AMD.FileName;
            groupBox_AMD.Text = groupBox_AMD.Text + " " + openFileDialogTask_AMD.FileName;
            textBoxIn_AMD.Text = File.ReadAllText(filepath);
            buttonDo_AMD.Enabled = true;
        }

        private void buttonDo_AMD_Click(object sender, EventArgs e)
        {
            textBoxOut_AMD.Text = ds.CollectTextFromFile(filepath);
        }
    }
}
