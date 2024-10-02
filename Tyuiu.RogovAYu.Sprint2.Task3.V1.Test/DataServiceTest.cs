using Tyuiu.RogovAYu.Sprint2.Task3.V1.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task3.V1
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
           
            Assert.AreEqual(ds.Calculate(1), Math.Round(Math.E - 12+Math.Cos(1), 3));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(ds.Calculate(2), Math.Round(Math.Exp(2) - 12 * 2 + Math.Cos(2), 3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(ds.Calculate(-1), -10.000);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(ds.Calculate(-10), -109.999);
        }
    }
}