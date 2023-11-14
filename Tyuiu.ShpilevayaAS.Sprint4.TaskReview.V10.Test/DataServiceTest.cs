using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint4.TaskReview.V10.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint4.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "695847142536";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
