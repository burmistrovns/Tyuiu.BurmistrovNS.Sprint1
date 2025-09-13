using Tyuiu.BurmistrovNS.Sprint1.Task1.V5.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#1 | Выполнил: Бурмистров Н.С. | ИСТНб-25-1";
            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* Спринт#1                                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                             *");
            Console.WriteLine("* Задание#1                                                                                                    *");
            Console.WriteLine("* Вариант#5                                                                                                    *");
            Console.WriteLine("* Выполнил: Бурмистров Николай Сергеевич | ИСТНб-25-1                                                          *");
            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ                                                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                                      *");
            Console.WriteLine("* вычисляет результат по формуле 5 + (x * y / 3) и печатает его на экране.                                     *");
            Console.WriteLine("*                                                                                                              *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                             *");
            Console.WriteLine("****************************************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();




        }


    }
}