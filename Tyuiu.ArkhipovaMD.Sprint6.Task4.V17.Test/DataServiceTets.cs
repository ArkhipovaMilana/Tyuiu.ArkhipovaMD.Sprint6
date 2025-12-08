using Tyuiu.ArkhipovaMD.Sprint6.Task4.V17.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTets
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] expectedRes = [-6];
            int startValue = 0;
            int endValue = 0;
            double[] result = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(result,expectedRes);
        }
    }
}
