﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.SysoevDA.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.75, res);
        }
    }
}