using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            //[-0.62,-16.79,-17.77,-6.3,-5.04,-6.0,-7.85,-2.43,5.91,4.33,-11.82]
            int massLen = stopValue - startValue + 1;
            double[] result = new double[massLen];
            for (int i = 0; i < massLen; i++)
            {
                double fx = (Math.Sin(startValue) / (startValue + 1.7)) - Math.Cos(startValue) * (4 * startValue) - 6;
                result[i] = Math.Round(fx,2);
                startValue++;
            }
            return result;
        }
    }
}
