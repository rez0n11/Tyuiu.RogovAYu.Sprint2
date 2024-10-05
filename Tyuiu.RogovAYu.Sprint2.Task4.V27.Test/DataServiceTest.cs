using Tyuiu.RogovAYu.Sprint2.Task4.V27.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            Assert.AreEqual(ds.Calculate(0, -13),0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(1, 0), -2);
        }
    }
}