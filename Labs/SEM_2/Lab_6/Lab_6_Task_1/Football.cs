using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task_1
{
    sealed class Football : SportGames 
    {
        public Football() : base()
        {
            Console.WriteLine("Football Begins");
        }
        public override void PlayGame()
        {
            base.PlayGame();
            Console.WriteLine("Playing Football");
        }
    }
}
