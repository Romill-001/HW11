using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesDolg
{
    public class Postman : IGame
    {
        public static Random r = new Random();
        public Team t { get; set; }
        public Postman(Team t)
        {
            this.t = t;
        }

        void IGame.Play()
        {
            Console.WriteLine("Начинается игра Почтальон!!! Выступает команда {0}" + "\n...", t.Name);

            for (int i = 0; i < 2; i++)
            {
                t.Points += r.Next(0, 10);
            }
            Console.WriteLine($"Очки команды после игры: {t.Points}");
            Thread.Sleep(1000);
        }
    }
}
