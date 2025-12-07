using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task3.V28.Lib
{
    public class DataService : ISprint6Task3V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (Convert.ToInt32(matrix[3,i])%2==0)
                {
                    matrix[3, i] = 0;
                }
            }
            return matrix;
        }
    }
}
