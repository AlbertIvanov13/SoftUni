using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._CreaturesOfTheCode
{
    public class Creature
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public int Health { get; set; }
        public List<string> Abilities { get; set; }
        public Creature(string name, string kind, int health, string abilities)
        {
            Name = name;
            Kind = kind;
            Health = health;
            Abilities = new List<string>(abilities.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} ({Kind}) has {Health} HP");
            sb.AppendLine($"Abilities: {string.Join(", ", Abilities)}");
            return sb.ToString().TrimEnd();
        }
    }
}