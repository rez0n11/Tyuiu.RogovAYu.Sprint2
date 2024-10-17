using Tyuiu.RogovAYu.Sprint2.Task5.V2.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(ds.FindMonthSeason(1), "зима");
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new();
            Assert.AreEqual(ds.FindMonthSeason(3), "весна");
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new();
            Assert.AreEqual(ds.FindMonthSeason(8), "лето");
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new();
            Assert.AreEqual(ds.FindMonthSeason(10), "осень");
        }
    }
}