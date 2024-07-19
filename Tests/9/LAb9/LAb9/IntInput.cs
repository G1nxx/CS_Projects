using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class IntInput
    {
        static public int Input(ref bool flag)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    flag = true;
                    return number;
                }
                else throw new Exception("Было введенно отрицательное число");
            }
            catch
            {
                flag = false;
                return -1;
            }
        }
    }
}
