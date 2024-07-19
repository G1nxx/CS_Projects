using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task_1
{
    internal class SportGames :  Sport
    {
        public SportGames() : base()
        {
            Console.WriteLine("SportGames Begins");
        }
        public override void DoSport()
        {
            Console.WriteLine("DoingSport");
            PlayGame();
        }

        public virtual void PlayGame()
        {
            Console.WriteLine("Playing Sport Game");
        }
    }
}
