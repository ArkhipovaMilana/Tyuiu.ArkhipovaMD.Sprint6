using Tyuiu.ArkhipovaMD.Sprint6.Task1.V17.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task1.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDO_AMD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {


                int startValue = Convert.ToInt32(textBoxCS_AMD.Text);
                int stopValue = Convert.ToInt32(textBoxCE_AMD.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startValue, stopValue);
                richTextBoxOutput_AMD.Text = "";
                richTextBoxOutput_AMD.AppendText("+---------------------------- +" + Environment.NewLine);
                richTextBoxOutput_AMD.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                richTextBoxOutput_AMD.AppendText("+-----------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", startValue, func[i]);
                    richTextBoxOutput_AMD.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                richTextBoxOutput_AMD.AppendText("+----------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_AMD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУб-25-1 Архипова М. Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
