using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMID2017_Zhanel_Turlybayeva
{
    class Program
    {
        static bool Needed(string x)
        {
            //получаем числовое значение числа
            int a = int.Parse(x);
            
            //находим нужные числа
            for (int i = 1; i <= a; ++i)
            {
                if (a % 3 == 0 && a%5!=0)
                {
                    return true;
                }
            }
            
            return false;
        }

        static void Main(string[] args)
        {
            //пробегаемся по массиву
            for (int i = 0; i < args.Length; ++i)
            {
                if (Needed(args[i]))
                {
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
