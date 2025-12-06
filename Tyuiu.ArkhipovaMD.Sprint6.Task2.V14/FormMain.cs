using Tyuiu.ArkhipovaMD.Sprint6.Task2.V14.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDo_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_AMD.Text);
                int stopValue = Convert.ToInt32(textBoxStop_AMD.Text);
                double[] func = ds.GetMassFunction(startValue, stopValue);

                for (int i = 0; i < func.Length; i++)
                {

                    this.dataGridView_AMD.Rows.Add(Convert.ToString(startValue), Convert.ToString(func[i]));
                    startValue++;
                }
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void buttonHelp_AMD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Архипова Милана АСОиУб-25-1","Справка",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }
    }
}
