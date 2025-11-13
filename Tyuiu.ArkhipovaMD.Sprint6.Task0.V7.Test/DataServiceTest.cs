using Tyuiu.ArkhipovaMD.Sprint6.Task0.V7.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double ans = 0;
            double res = ds.Calculate(0);
            Assert.AreEqual(ans, res);
        }
    }
}
