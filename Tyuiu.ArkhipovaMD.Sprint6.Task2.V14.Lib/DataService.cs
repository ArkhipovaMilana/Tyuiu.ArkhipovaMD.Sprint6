using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ans = new double[stopValue-startValue+1];
            for (int i = startValue; i <= stopValue; i++)
            {
                double function = 5 - 3 * startValue + (1 + Math.Sin(startValue))/(2*startValue-0.5);
                ans[i] = function;
                startValue++;
            }
            return ans;
        }
    }
}
