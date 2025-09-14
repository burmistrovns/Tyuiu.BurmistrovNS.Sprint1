using Tyuiu.BurmistrovNS.Sprint1.Task4.V4.Lib;
namespace Tyuiu.BurmistrovNS.Sprint1.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                             *");
            Console.WriteLine("****************************************************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение  X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine(" (1 + x * y) / (|x + 2|) = " + Math.Round(ds.Calculate(x,y), 3));

            Console.ReadKey();




        }


    }
}