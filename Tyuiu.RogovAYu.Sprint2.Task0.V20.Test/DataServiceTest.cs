using Tyuiu.RogovAYu.Sprint2.Task0.V20.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            Assert.AreEqual(ds.GetCompareOperations(1075, 275), [false,true, false, true, false, true]);
        }
    }
}