using Tyuiu.ChepragaDM.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ChepragaDM.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {

            DataService ds = new DataService();
            int x = 150;
            var res = ds.ConvertMinutesToHours(x);

            Assert.AreEqual(2.5, res);

        }
    }
}
