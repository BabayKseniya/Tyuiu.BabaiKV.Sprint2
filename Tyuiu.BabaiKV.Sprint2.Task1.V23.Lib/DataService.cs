using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BabaiKV.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (d==c)|(c>b);
            res[1] = (b<a)&(a==b);
            res[2] = (a==d)||(b<c);
            res[3] = (a<b)&&(c>d);
            res[4] = !(c<d);
            res[5] = (a>b)^(d<c);
            return res;
        }
    }
}
