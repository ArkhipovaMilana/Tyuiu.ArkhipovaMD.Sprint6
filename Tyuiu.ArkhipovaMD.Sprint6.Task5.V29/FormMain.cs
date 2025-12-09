using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ArkhipovaMD.Sprint6.Task5.V29.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine(@"C:\DataSprint", "InPutDataFileTask5V29.txt");
        private void buttonOpen_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();

                process.StartInfo.FileName = path;

                process.StartInfo.UseShellExecute = true;

                process.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonDo_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_AMD.Rows.Clear();

                double[] func = ds.LoadFromDataFile(path);

                if (func == null || func.Length == 0)
                {
                    MessageBox.Show("Файл не содержит чисел больше 10", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                for (int i = 0; i < func.Length; i++)
                {
                    dataGridView_AMD.Rows.Add(i + 1, func[i]);
                }

                this.chart_AMD.ChartAreas[0].AxisX.Title = "X";

                this.chart_AMD.ChartAreas[0].AxisY.Title = "Y";

                chart_AMD.Series[0].Points.Clear();
                for (int i = 0; i < func.Length; i++)
                {
                    this.chart_AMD.Series[0].Points.AddXY(i+1, func[i]);
                }

                MessageBox.Show($"Загружено {func.Length} значений", "Успешно",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
