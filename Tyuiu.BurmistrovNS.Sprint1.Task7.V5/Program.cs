using Tyuiu.BurmistrovNS.Sprint1.Task7.V5.Lib;
namespace Tyuiu.BurmistrovNS.Sprint1.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                             *");
            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("    ln|cos x|    ");
            Console.WriteLine("z=---------------");
            Console.WriteLine("    ln(1+x^2)    ");

            double x;

            Console.WriteLine("Введите значение  X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                   *");
            Console.WriteLine("****************************************************************************************************************");


            Console.WriteLine(Math.Round(ds.Calculate(x), 3));

            Console.ReadKey();




        }


    }
}