using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task_1
{
    sealed class BeachVolleyball : Volleyball
    {
        public BeachVolleyball() : base()
        {
            Console.WriteLine("BeachVolleyball Begins");
        }
        public override void PlayGame()
        {
            base.PlayGame();
            Console.WriteLine("Playing Beach Volleyball");
        }
    }
}
