using Tyuiu.BabaiKV.Sprint2.Task5.V3.Lib;
namespace Tyuiu.BabaiKV.Sprint2.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца:");
            int nummouth= Convert.ToInt32(Console.ReadLine());
            

            string res;
            if ((nummouth <1) ||( nummouth>12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это месяц: " + ds.FindDayName(nummouth);
            }

                

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
