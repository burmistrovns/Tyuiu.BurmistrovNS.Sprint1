using Tyuiu.BurmistrovNS.Sprint1.Task6.V3.Lib;
namespace Tyuiu.BurmistrovNS.Sprint1.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                             *");
            Console.WriteLine("****************************************************************************************************************");

            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();
            
            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine(ds.LastLetterWord(str));

            Console.ReadKey();




        }


    }
}