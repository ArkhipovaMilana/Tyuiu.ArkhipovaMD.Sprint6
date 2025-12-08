using System;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ArkhipovaMD.Sprint6.Task4.V17.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task4.V17
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
                int startStep = Convert.ToInt32(textBoxStart_AMD.Text);
                int stopStep = Convert.ToInt32(textBoxStop_AMD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] Array = ds.GetMassFunction(startStep, stopStep);

                this.chart1.ChartAreas[0].AxisX.Title = "X";

                this.chart1.ChartAreas[0].AxisY.Title = "Y";

                richTextBoxResult_AMD.Text = "";

                chart1.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chart1.Series[0].Points.AddXY(startStep, Array[i]);
                    richTextBoxResult_AMD.AppendText(Array[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch { MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonInfo_AMD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Архипова Милана АСОиУб-25-1", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void buttonSave_AMD_Click(object sender, EventArgs e)
        {
            try 
            { 
                string path =Path.Combine(Directory.GetCurrentDirectory(),"CalculationResult.txt");
                File.WriteAllText(path, richTextBoxResult_AMD.Text);
                DialogResult dialogresult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Хотите открыть файл в текстовом редакторе?","", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    //System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    //txt.StartInfo.FileName = "CalculationResult.txt";
                    //txt.StartInfo.Arguments = path;
                    //txt.Start();
                    System.Diagnostics.Process process = new System.Diagnostics.Process();

                    process.StartInfo.FileName = path;

                    process.StartInfo.UseShellExecute = true;

                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка : {ex.Message}");
            }
        }
    }
}
