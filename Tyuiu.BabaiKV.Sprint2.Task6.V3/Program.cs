using Tyuiu.BabaiKV.Sprint2.Task6.V3.Lib;
namespace Tyuiu.BabaiKV.Sprint2.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня недели:");
            int num = Convert.ToInt32(Console.ReadLine());


            string res;
            if ((num < 1) || (num > 7))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это день недели: " + ds.FindDayName(num);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
