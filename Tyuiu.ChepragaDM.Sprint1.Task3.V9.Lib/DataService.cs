using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChepragaDM.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {


            double x = minutes * 60;
            return Math.Round((x / 3600) + ((x % 60) % 60), 3);



        }
    }
}