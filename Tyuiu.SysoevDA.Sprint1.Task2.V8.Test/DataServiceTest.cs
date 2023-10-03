using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.SysoevDA.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 2;
            var res = ds.CalculatePerimetr(x, y);
            Assert.AreEqual(8, res);
        }
    }
}
