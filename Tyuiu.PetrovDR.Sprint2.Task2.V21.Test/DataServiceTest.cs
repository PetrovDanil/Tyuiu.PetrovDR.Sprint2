﻿using Tyuiu.PetrovDR.Sprint2.Task2.V21.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 9;
            int y = 11;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
