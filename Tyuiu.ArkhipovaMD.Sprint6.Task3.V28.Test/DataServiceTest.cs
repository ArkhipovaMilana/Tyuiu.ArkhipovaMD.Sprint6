using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ArkhipovaMD.Sprint6.Task3.V28.Lib;

namespace Tyuiu.ArkhipovaMD.Sprint6.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -9, 8, 9, 16, -18 },
                { -13, -11, -20, -15, 9 },
                { 18, 13, -12, -15, -11 },
                { 10, -2, 19, -4, -10 },
                { 6, -20, -4, 13, -14 }
            };

            int[,] expectedRes = new int[5, 5]
            {
                { -9, 8, 9, 16, -18 },
                { -13, -11, -20, -15, 9 },
                { 18, 13, -12, -15, -11 },
                { 0, 0, 19, 0, 0 },
                { 6, -20, -4, 13, -14 }
            };

            // Act
            int[,] result = ds.Calculate(matrix); // Предполагаем, что есть метод Calculate

            // Assert
            CollectionAssert.AreEqual(expectedRes, result);
        }
    }
}