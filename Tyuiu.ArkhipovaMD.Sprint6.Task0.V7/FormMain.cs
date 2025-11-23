using Tyuiu.ArkhipovaMD.Sprint6.Task0.V7.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void inputBoxInput_AMD_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void buttonOutput_AMD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutput_AMD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(inputBoxInput_AMD.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputBoxInput_AMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true; return;
            }
        }

        private void textBoxOutput_AMD_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_AMD_Enter(object sender, EventArgs e)
        {

        }
    }
}
