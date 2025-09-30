using Tyuiu.ChepragaDM.Sprint1.Task5.V1.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x1 = 1.0;
            double y1 = 1.0;
            double x2 = 5.0;
            double y2 = 4.0;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(5, res);
        }
    }
}
