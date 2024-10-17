using Tyuiu.RogovAYu.Sprint2.Task6.V6.Lib;
namespace Tyuiu.RogovAYu.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(ds.FindCardNameAndValue(1, 12), "дама пик");
        }
    }
}