using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesDolg
{
    public class MyGame : IGame
    {
        public static Random r = new Random();
        public Team t { get; set; }
        public MyGame(Team t)
        {
            this.t = t;
        }

        void IGame.Play()
        {
            Console.WriteLine("Начинается игра Вилки и Розетки!!! Выступает команда {0}" + "\n...", t.Name);
            for (int i = 0; i < 5; i++)
            {

                t.Points += r.Next(0, 5);
            }
            Console.WriteLine($"Очки команды после игры: {t.Points}");
            Thread.Sleep(1000);
        }
    }
}
