using Tyuiu.RogovAYu.Sprint2.Task1.V26.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual([true, true, true, false, false, false], ds.GetLogicOperations(651, 671, 874, 137));
        }
    }
}