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
            Assert.AreEqual("������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(2));
            Assert.AreEqual("����", ds.FindDayName(3));
            Assert.AreEqual("������", ds.FindDayName(4));
            Assert.AreEqual("���", ds.FindDayName(5));
            Assert.AreEqual("����", ds.FindDayName(6));
            Assert.AreEqual("����", ds.FindDayName(7));
            Assert.AreEqual("������", ds.FindDayName(8));
            Assert.AreEqual("��������", ds.FindDayName(9));
            Assert.AreEqual("�������", ds.FindDayName(10));
            Assert.AreEqual("������", ds.FindDayName(11));
            Assert.AreEqual("�������", ds.FindDayName(12));
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