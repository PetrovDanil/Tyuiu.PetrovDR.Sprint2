using Tyuiu.PetrovDR.Sprint2.Task5.V8.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("15.08", ds.FindDateOfPreviousDay(8, 16));
            Assert.AreEqual("28.02", ds.FindDateOfPreviousDay(3, 1));
            Assert.AreEqual("31.12", ds.FindDateOfPreviousDay(1, 1));
        }
    }
}
