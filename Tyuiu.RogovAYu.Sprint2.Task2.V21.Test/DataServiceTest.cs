using Tyuiu.RogovAYu.Sprint2.Task2.V21.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(new DataService().CheckDotInShadedArea(3, 3));
        }
    }
}