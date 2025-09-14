using Tyuiu.BurmistrovNS.Sprint1.Task2.V11.Lib;

namespace Tyuiu.BurmistrovNS.Sprint1.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                             *");
            Console.WriteLine("****************************************************************************************************************");

            int x;
           
            Console.WriteLine("Введите количество часов X:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите количество минут Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine("Количество секунд = " + ds.ConvertHoursMinutesToSeconds(x, y));

            Console.ReadLine();




        }


    }
}