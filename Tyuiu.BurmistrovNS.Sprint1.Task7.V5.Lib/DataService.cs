using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BurmistrovNS.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double res = ((Math.Log(Math.Abs(Math.Cos(x))))) / ((Math.Log(1 + (Math.Pow(x,2)))));
            return res;
        }
    }
}
