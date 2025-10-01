using Tyuiu.ChepragaDM.Sprint1.Task7.V18.Lib;
namespace Tyuiu.ChepragaDM.Sprint1.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов в класс Convert                              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                    2                                                    *");
            Console.WriteLine("*             1 + sin (x + y)                                             *");
            Console.WriteLine("*    z = ----------------------- + x                                      *");
            Console.WriteLine("*            |         2x     |                                           *");
            Console.WriteLine("*        2 + |x - ----------- |                                           *");
            Console.WriteLine("*            |         2    2 |                                           *");
            Console.WriteLine("*            |    1 + x  * y  |                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение переменной Х: ");
            x = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
