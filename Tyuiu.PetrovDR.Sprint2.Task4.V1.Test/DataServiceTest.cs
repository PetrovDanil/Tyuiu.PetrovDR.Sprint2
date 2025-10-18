using Tyuiu.PetrovDR.Sprint2.Task4.V1.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 6;
            double z = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, z);
        }
    }
}
