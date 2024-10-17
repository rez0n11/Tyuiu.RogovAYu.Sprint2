using Tyuiu.RogovAYu.Sprint2.Task7.V14.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(ds.CheckDotInShadedArea(0, 1), true);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new();
            Assert.AreEqual(ds.CheckDotInShadedArea(-0.7, -0.1), false);
        }
    }
}