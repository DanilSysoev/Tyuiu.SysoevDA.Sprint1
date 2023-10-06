using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SysoevDA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 86;

            var res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(30, res);
        }
    }
}
