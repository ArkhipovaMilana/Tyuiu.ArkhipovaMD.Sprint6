using Tyuiu.ArkhipovaMD.Sprint6.Task3.V28.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        int[,] matrix = new int[5, 5]
            {
                { -9, 8, 9, 16, -18 },
                { -13, -11, -20, -15, 9 },
                { 18, 13, -12, -15, -11 },
                { 10, -2, 19, -4, -10 },
                { 6, -20, -4, 13, -14 }
            };
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
