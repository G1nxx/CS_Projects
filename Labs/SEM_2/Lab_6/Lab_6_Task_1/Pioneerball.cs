using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task_1
{
    sealed class Pioneerball : Volleyball
    {
        public Pioneerball() : base()
        {
            Console.WriteLine("Pioneerball Begins");
        }

        public override void PlayGame()
        {
            base.PlayGame();
            Console.WriteLine("Playing Pioneerball");
        }

        public override void ServeTheBall()
        {
            Console.WriteLine("The Ball Was Thrown");
        }
    }
}
