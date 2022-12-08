using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    public class Person
    {
        public string Name { get; set; }
        public string Hobby { get; set; }
        public Person(string name, string hobby)
        {
            Name = name;
            Hobby = hobby;
        }
        public delegate void PersonHobby(string message);
        public event PersonHobby Reaction;
        public void CheckHobby(string t)
        {
            if (Hobby.ToLower().Equals(t.ToLower()))
            {
                Reaction.Invoke($"{Name} отреагировал на событие:\nУраааа!!!!!");
            }
        }
    }
}
