using Tyuiu.BabaiKV.Sprint2.Task4.V25.Lib;
namespace Tyuiu.BabaiKV.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x =10;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait =1.082;
            Assert.AreEqual(wait,res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x =42;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 4.033;
            Assert.AreEqual(wait, res);
        }
    }
}