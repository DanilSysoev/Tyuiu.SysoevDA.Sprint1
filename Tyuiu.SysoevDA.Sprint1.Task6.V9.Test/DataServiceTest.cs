using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.SysoevDA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Название проектов";

            var res = ds.MoveLetterToStart(value);
            Assert.AreEqual("еНазвани впроекто", res);
        }
    }
}