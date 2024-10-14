using Tyuiu.BabaiKV.Sprint2.Task2.V5.Lib;
namespace Tyuiu.BabaiKV.Sprint2.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной Х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ВВедите значение переменной У:");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области:");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области:");
            }
            Console.ReadKey();
        }
    }
}
