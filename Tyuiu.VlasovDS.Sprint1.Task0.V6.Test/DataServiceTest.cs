﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasovDS.Sprint1.Task0.V6.Lib;

namespace Tyuiu.VlasovDS.Sprint1.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            int wait = 15;
            Assert.AreEqual(res, wait);
        }
    }
}
