using Tyuiu.ArkhipovaMD.Sprint6.Task1.V17.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int endValue = 5;
            double[] res = ds.GetMassFunction(startValue, endValue);
            double exp = 4.34;
            Assert.AreEqual(exp, res[0]);
        }
    }
}
