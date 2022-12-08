using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesDolg
{
    public class Sea : IGame
    {
        static Random r = new Random();
        public Team t { get; set; }
        public Sea(Team t)
        {
            this.t = t;
        }

        public void Play()
        {
            Console.WriteLine("Начинается игра Море!!! Выступает команда {0}" + "\n...", t.Name);

            for (int i = 0; i < 8; i++)
            {
                t.Points += r.Next(0, 3);
            }
            Console.WriteLine($"Очки команды после игры: {t.Points}");
            Thread.Sleep(1000);
        }
    }
}
