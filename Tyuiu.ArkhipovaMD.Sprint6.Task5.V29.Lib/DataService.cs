
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {
        public double[] LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] sdata = text.Split(new char[] { ' ', '\t', '\n', '\r' },
                                StringSplitOptions.RemoveEmptyEntries);
            List<double> data = new List<double>();
            for (int i = 0; i < sdata.Length; i++)
            {
                if (double.TryParse(sdata[i], out double value))
                {
                    if (value >= 10)
                    {
                        data.Add(value);
                    }
                }
            }
            return data.ToArray();
        }
    }
}
