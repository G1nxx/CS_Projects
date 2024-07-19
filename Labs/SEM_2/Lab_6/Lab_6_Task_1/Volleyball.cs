using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task_1
{
    internal class Volleyball : SportGames
    {
        public Volleyball() : base()
        {
            Console.WriteLine("Volleyball Begins");
        }
        public override void PlayGame()
        {
            base.PlayGame();
            Console.WriteLine("Playing Volleyball");
        }

        public virtual void ServeTheBall() { Console.WriteLine("Ball Is Served"); }
    }
}
