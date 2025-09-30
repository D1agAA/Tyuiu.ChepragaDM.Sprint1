using Tyuiu.ChepragaDM.Sprint1.Task4.V8.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();
            var x = 1;
            var y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);

        }
    }
}
