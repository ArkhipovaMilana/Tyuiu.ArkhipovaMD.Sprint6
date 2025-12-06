using Tyuiu.ArkhipovaMD.Sprint6.Task2.V14.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double exp = 3;
            Assert.AreEqual(res[5],exp);
        }
    }
}
