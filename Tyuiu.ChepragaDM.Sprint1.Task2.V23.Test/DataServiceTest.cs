using Tyuiu.ChepragaDM.Sprint1.Task2.V23.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMinutesToSeconds(x);
            Assert.AreEqual(120, res);

        }
    }
}
