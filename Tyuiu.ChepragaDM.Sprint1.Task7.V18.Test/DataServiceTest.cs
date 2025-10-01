using Tyuiu.ChepragaDM.Sprint1.Task7.V18.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.392, res);
        }
    }
}
