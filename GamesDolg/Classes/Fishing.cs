using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesDolg
{
    public class Fishing : IGame
    {
        public static Random r = new Random();
        public Team t { get; set; }
        public Fishing(Team t)
        {
            this.t = t;
        }

        void IGame.Play()
        {
            Console.WriteLine("Начинается игра Рыбалка!!! Выступает команда {0}" + "\n...", t.Name);
            for (int i = 0; i < 6; i++)
            {

                if (r.Next(0, 10) > 5)
                {
                    t.Points += 10;
                }
                else if (r.Next(0, 10) <= 5 && r.Next(0, 10) > 0)
                {
                    t.Points += 5;
                }
                else
                {
                    t.Points -= 1;
                }
            }
            Console.WriteLine($"Очки команды после игры: {t.Points}");
            Thread.Sleep(1000);
        }
    }
}
