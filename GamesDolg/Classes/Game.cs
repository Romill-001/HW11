using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDolg
{
    public class Game
    {
        private IGame game;
        public void SetGame(IGame game)
        {
            this.game = game;
        }
        public void Start()
        {
            game.Play();
        }
        public void Endgame(List<Team> list)
        {
            foreach (Team t in list)
            {
                Console.WriteLine($"Команда {t.Name} набрала {t.Points} очков");
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Points == list[i + 1].Points)
                {
                    list[i].Points++;
                }
            }
            var sortlist = list.OrderByDescending(x => x.Points).ToList();
            Console.WriteLine($"Победила команда {sortlist[0].Name} с количеством очков: {sortlist[0].Points}");
        }
    }
}
