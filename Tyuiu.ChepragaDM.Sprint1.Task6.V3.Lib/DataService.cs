using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChepragaDM.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
               

                value = value.Replace(",", "");
                string[] words = value.Split(' ');

                
                string result = "";
                foreach (string word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        result += word[word.Length - 1];
                    }
                }

               return result;
            
        }
    }
}
