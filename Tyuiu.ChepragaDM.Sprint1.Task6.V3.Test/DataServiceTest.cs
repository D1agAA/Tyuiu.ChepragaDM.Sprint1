using Tyuiu.ChepragaDM.Sprint1.Task6.V3.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            string x = "Привет, я Дима";
            var res = ds.SymbolCode(x);
            Assert.AreEqual("тяа", res);
        }
    }
}
