using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint1.Task4.V6.Lib;

namespace Tyuiu.SysoevDA.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}
