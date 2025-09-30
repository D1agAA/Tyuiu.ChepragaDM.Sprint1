using Tyuiu.ChepragaDM.Sprint1.Task0.V7.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();

            Assert.AreEqual(5, res);
        }
    }
}

