using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaFigureLib;
namespace TestArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Area.TiangleArea.GetArea(4, 2, 3), 2, 9047375096555625);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Area.CircleArea.GetArea(5), 78.53981633974483);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Area.TiangleArea.IsRightTriangle(3,4,5), true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Area.TiangleArea.IsRightTriangle(2, 4, 5), false);
        }
    }
}
