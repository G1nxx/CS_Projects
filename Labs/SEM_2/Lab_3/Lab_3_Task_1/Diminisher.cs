using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    internal class Diminisher
    {
        public static int TryDiminish(int x)
        {
            if (x % 2 == 0)
            {
                x /= 2;
            }
            else
            {
                x += 3;
            }
            return x;
        }

    }
}
