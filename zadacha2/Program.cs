using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst = new List<Person>
            {
                new Person("Илья", "Сериал пацаны"),
                new Person("Андрей", "Геншин"),
                new Person("Ильдар", "Юнити")
            };
            Console.WriteLine("Введите событие");
            string t = Console.ReadLine();
            foreach(Person p in lst) 
            {
                if (lst.Find(i => i.Hobby.ToLower() == t.ToLower()) != null)
                {
                    p.Reaction += Message;
                    p.CheckHobby(t);
                }
                else
                {
                    Console.WriteLine("Нет людей с таким хобби");
                    break;
                }

            }
            void Message(string message) => Console.WriteLine(message);
        }
    }
}
