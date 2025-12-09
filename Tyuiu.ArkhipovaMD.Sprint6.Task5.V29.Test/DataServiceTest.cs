using Tyuiu.ArkhipovaMD.Sprint6.Task5.V29.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutputFileTask5.txt");
            bool file = File.Exists(path);
            Assert.IsTrue(file);
        }
    }
}
