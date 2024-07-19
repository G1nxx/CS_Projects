using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal interface IMusic
    {
        static public abstract void PlayMusic();
        static public abstract void LoadMusic(int numberOfSong);
        static public abstract void StopMusic();


    }
}
