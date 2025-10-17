using Tyuiu.PetrovDR.Sprint2.Task3.V8.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -4.588;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 0.25;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -13;
            double wait = -142.615;
            Assert.AreEqual(wait, ds.Calculate(x));
        }
    }
}
