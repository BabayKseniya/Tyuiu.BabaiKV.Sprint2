using Tyuiu.BabaiKV.Sprint2.Task1.V23.Lib;
namespace Tyuiu.BabaiKV.Sprint2.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);

            Console.Title = "Спринт #2 | Выполнила: Бабай К. В. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки в C#                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Бабай Ксения Витальевна | СМАРТб-24-1                        *");
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

            }
            Console.ReadKey();
        }
    }
}
