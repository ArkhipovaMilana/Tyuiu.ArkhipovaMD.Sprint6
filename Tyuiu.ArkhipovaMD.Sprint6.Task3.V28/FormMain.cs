using Tyuiu.ArkhipovaMD.Sprint6.Task3.V28.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        //int[,] matrix = new int[5, 5]
        //    {
        //        { -9, 8, 9, 16, -18 },
        //        { -13, -11, -20, -15, 9 },
        //        { 18, 13, -12, -15, -11 },
        //        { 10, -2, 19, -4, -10 },
        //        { 6, -20, -4, 13, -14 }
        //    };
        public FormMain()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -9,   8,   9,  16, -18 },
{ -13, -11, -20, -15,   9 },
 { 18 , 13 ,-12 ,-15, -11 },
  {10,  -2 , 19 , -4 ,-10 },
   {6 ,-20 , -4 , 13 ,-14 } };

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУб-25-1 Архипова М. Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matr = ds.Calculate(matrix);
            int rows = matr.GetUpperBound(0) + 1;
            int columns = matr.Length / rows;

            dataGridView_AMD.ColumnCount = columns;
            dataGridView_AMD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_AMD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_AMD.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridView_AMD.ColumnCount = columns;
            dataGridView_AMD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_AMD.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_AMD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
