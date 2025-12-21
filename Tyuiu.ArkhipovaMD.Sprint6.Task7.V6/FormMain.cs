using Tyuiu.ArkhipovaMD.Sprint6.Task7.V6.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogSave_AMD.Filter = "Значения разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialog_AMD.Filter = "Значения разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string path;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_AMD_Click(object sender, EventArgs e)
        {
            openFileDialog_AMD.ShowDialog();
            path = openFileDialog_AMD.FileName;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = LoadFromFileData(path);
            dataGridViewInput_AMD.RowCount = rows;
            dataGridViewInput_AMD.ColumnCount = cols;
            dataGridViewOutput_AMD.RowCount = rows;
            dataGridViewOutput_AMD.ColumnCount = cols;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewInput_AMD.Columns[i].Width = 25;
                dataGridViewOutput_AMD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewInput_AMD.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(path);
            buttonApply_AMD.Enabled = true;
        }

        private void buttonApply_AMD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOutput_AMD.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }

        private void buttonSave_AMD_Click(object sender, EventArgs e)
        {
            openFileDialogSave_AMD.FileName = "OutputFileTask7.csv";
            openFileDialogSave_AMD.InitialDirectory= Directory.GetCurrentDirectory();
            openFileDialogSave_AMD.ShowDialog();
            
            string path = openFileDialogSave_AMD.FileName;
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            if (fileexists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_AMD.RowCount;
            int cols = dataGridViewOutput_AMD.ColumnCount;

            string str = "";

            for (int i = 0;i < rows;i++)
            {
                for ( int j = 0; j < cols;j++)
                {
                    if (j!=cols-1)
                    {
                        str = str + dataGridViewOutput_AMD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_AMD.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path,str+ Environment.NewLine);
            str = "";
        }
    }
}
