
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {
        public double[] LoadFromDataFile(string path)
        {
            int rows;
            int columns;
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            double[,] arrayValues = new double[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToDouble(line_r[c]);
                }
            }

            int xRow = 6;

            for (int c = 0; c < columns; c++)
            {
                for (int r = xRow; r <= xRow; c++)
                {
                    if (arrayValues[c, r] !=6)
                    {
                        arrayValues[r, c] = 0;
                    }
                }
            }
            double[] ans = new double[rows*columns];
            int i = 0;
            for (int c = 0;c<columns;c++)
            {
                for (int r = 0;r < rows; r++)
                {
                    ans[i] = arrayValues[r, c];
                    i++;
                }
            }

            return ans;
        }
    }
}
