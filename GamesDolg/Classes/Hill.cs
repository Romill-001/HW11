using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesDolg
{
    public class Hill : IGame
    {
        public static Random r = new Random();
        public Team t { get; set; }
        public Hill(Team t)
        {
            this.t = t;
        }

        void IGame.Play()
        {
            Console.WriteLine("Начинается игра Горка!!! Выступает команда {0}" + "\n...", t.Name);

            if (r.Next(20, 100) > 60)
            {
                t.Points += 5;
            }
            else
            {
                t.Points += 10;
            }
            Console.WriteLine($"Очки команды после игры: {t.Points}");
            Thread.Sleep(1000);
        }
    }
}
