using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task7.V6.Lib
{
    public class DataService : ISprint6Task7V6
    {
        public int[,] GetMatrix(string path)
        {
            string data = File.ReadAllText(path);
            string[] data1 = data.Split('\n');
            foreach (string line in data1)
            {
                line.Split(";");
            }
            return data1;
        }
    }
}
