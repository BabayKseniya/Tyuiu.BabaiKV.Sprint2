using Tyuiu.BabaiKV.Sprint2.Task5.V3.Lib;
namespace Tyuiu.BabaiKV.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь", ds.FindDayName(1));
            Assert.AreEqual("Февраль", ds.FindDayName(2));
            Assert.AreEqual("Март", ds.FindDayName(3));
            Assert.AreEqual("Апрель", ds.FindDayName(4));
            Assert.AreEqual("Май", ds.FindDayName(5));
            Assert.AreEqual("Июнь", ds.FindDayName(6));
            Assert.AreEqual("Июль", ds.FindDayName(7));
            Assert.AreEqual("Август", ds.FindDayName(8));
            Assert.AreEqual("Сентябрь", ds.FindDayName(9));
            Assert.AreEqual("Октябрь", ds.FindDayName(10));
            Assert.AreEqual("Ноябрь", ds.FindDayName(11));
            Assert.AreEqual("Декабрь", ds.FindDayName(12));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(13);
            });

        }
    }
}