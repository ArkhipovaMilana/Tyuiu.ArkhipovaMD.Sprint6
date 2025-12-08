using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int massLen = stopValue - startValue + 1;
            double[] result = new double[massLen];
            for (int i = 0; i < massLen; i++)
            {
                result[i] = Math.Round(((Math.Sin(startValue)/(startValue+1.7))-Math.Cos(startValue))*(4*startValue)-6,2);
                startValue++;
            }
            return result;
        }
    }
}
