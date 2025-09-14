using Tyuiu.BurmistrovNS.Sprint1.Task3.V7.Lib;
namespace Tyuiu.BurmistrovNS.Sprint1.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                             *");
            Console.WriteLine("****************************************************************************************************************");

            double x;

            Console.WriteLine("Введите количество километров X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine("Количество вёрст = " + Math.Round(ds.VerstsToKilometers(x),3));

            Console.ReadLine();




        }


    }
}