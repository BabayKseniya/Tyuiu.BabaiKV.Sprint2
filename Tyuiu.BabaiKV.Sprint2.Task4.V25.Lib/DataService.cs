using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabaiKV.Sprint2.Task4.V25.Lib
{
    public class DataService : ISprint2Task4V25
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 20 * 2 < y / 4) ? Math.Pow((1 + (2 / Math.Pow(x, 2))), y) : (Math.Round(y + Math.Pow((x + 1) / (y + 2), x), 3));
            return Math.Round(z, 3);
        }
    }
}
