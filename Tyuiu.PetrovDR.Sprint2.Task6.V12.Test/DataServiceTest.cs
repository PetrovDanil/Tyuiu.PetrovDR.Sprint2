using Tyuiu.PetrovDR.Sprint2.Task6.V12.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("29.02.1984", ds.FindDateOfPreviousDay(1984, 03, 1));
        }
    }
}
