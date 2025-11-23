using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task1.V17.Lib
{
    public class DataService : ISprint6Task1V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] function = new double[stopValue-startValue+1];
            for (int i = 0; i < function.Length; i++)
            {
                function[i] = Math.Round((3*startValue)/(Math.Sin(startValue)-3+startValue)+2,2);
            }
            return function;
        }
    }
}
