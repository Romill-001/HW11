using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GamesDolg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> lst = new List<Team>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите название страны");
                string t = Console.ReadLine();
                Team team = new Team(t);
                lst.Add(team);
            }
            Game game = new Game();
            foreach(Team t in lst)
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
                game.SetGame(new Postman(t));
                game.Start();
                game.SetGame(new Hill(t));
                game.Start();
                game.SetGame(new Sea(t));
                game.Start();
                game.SetGame(new Mousetrap(t));
                game.Start();
                game.SetGame(new Beach(t));
                game.Start();
                game.SetGame(new Fishing(t));
                game.Start();
                game.SetGame(new MyGame(t));
                game.Start();
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<");
            }
            game.Endgame(lst);
        }
    }
}
