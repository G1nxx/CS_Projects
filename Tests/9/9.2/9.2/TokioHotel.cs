using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LAb9
{
    internal class TokioHotel : Hotel, IMusic
    {
        public TokioHotel(string title, int Price, int numberOfFloors, bool HasPool) 
        {
            this.title = title;
            this.Price = Price; 
            this.NumberOfFloors = numberOfFloors;
            this.HasPool = HasPool;
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"Тип - Токийский отель\nНазвание - {title}\nЦена  - {Price}\nКоличество этажей  - {numberOfFloors}\n{(HasPool ? "Бассейн есть" : "Бассейнена  нет")}\nФорма бассейна - {FormOfPool}");
        }

        static SoundPlayer player = null;
        static readonly string tillOfDirectory = "G:\\C#\\лабораторные\\9\\Music";
        static readonly List<string> listOfSong = new List<string>
        { 
            "tokio-hotel-covered-in-gold.wav",
            "tokio-hotel-durch-den-monsun.wav", 
            "tokio-hotel-feel-it-all.wav",
            "tokio-hotel-girl-got-a-gun.wav",
            "tokio-hotel-love-who-loves-you-back.wav",
            "tokio-hotel-run-run-run.wav",
            "tokio-hotel-stormy-weather.wav",
            "tokio-hotel-the-heart-get-no-sleep.wav"
        };

        static public  void LoadMusic(int numberOfSong)
        {
            if (player != null) StopMusic();
            player = new SoundPlayer(tillOfDirectory + "\\" + listOfSong[numberOfSong - 1]);
        }
        static public  void StopMusic()
        {
            player.Stop();
        }
        static public  void PlayMusic()
        {
            player.Play();    
        }

        
    }
}
