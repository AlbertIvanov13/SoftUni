using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._CreaturesOfTheCode
{
    public class MythicalCreaturesHub
    {
        public List<Creature> Creatures { get; set; }
        public int Capacity { get; set; }

        public MythicalCreaturesHub(int capacity)
        {
            Capacity = capacity;
            Creatures = new List<Creature>(capacity);
        }

        public void AddCreature(Creature creature)
        {
            if (Creatures.Count < Capacity && !Creatures.Any(c => c.Name.ToLower() == creature.Name.ToLower()))
            {
                Creatures.Add(creature);
            }
        }

        public bool RemoveCreature(string name)
        {
            if (Creatures.Any(c => c.Name == name))
            {
                Creatures.Remove(Creatures.First(c => c.Name == name));
                return true;
            }

            return false;
        }

        public Creature GetStrongestCreature()
        {
            Creatures = Creatures.OrderByDescending(c => c.Health).ToList();
            return Creatures[0];
        }

        public string Details(string creatureName)
        {
            if (Creatures.Any(c => c.Name == creatureName))
            {
                Creature creature = Creatures.FirstOrDefault(c => c.Name == creatureName);
                return creature.ToString();
            }

            return $"Creature with the name {creatureName} not found.";
        }

        public string GetAllCreatures()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mythical Creatures:");
            Creatures = Creatures.OrderBy(c => c.Name).ToList();
            foreach (Creature creature in Creatures)
            {
                sb.AppendLine($"{creature.Name} -> {creature.Kind}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}