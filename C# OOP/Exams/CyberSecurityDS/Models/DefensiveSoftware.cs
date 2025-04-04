using CyberSecurityDS.Models.Contracts;
using CyberSecurityDS.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityDS.Models
{
    public abstract class DefensiveSoftware : IDefensiveSoftware
    {
        private string name;
        private int effectiveness;
        private readonly List<string> assignedAttacks;

        protected DefensiveSoftware(string name, int effectiveness)
        {
            Name = name;
            Effectiveness = effectiveness;
            assignedAttacks = new List<string>();
        }

        public string Name
        {
            get { return name; }
            private set 
            { 
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.SoftwareNameRequired);
                }
                name = value;
            }
        }

        public int Effectiveness
        {
            get { return effectiveness; }
            private set 
            {
                if (value == 0)
                {
                    value = 1;
                }
                else if (value > 10)
                {
                    value = 10;
                }
                else if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.EffectivenessNegative);
                }
                effectiveness = value; 
            }
        }

        public IReadOnlyCollection<string> AssignedAttacks
        {
            get { return assignedAttacks.AsReadOnly(); }
        }

        public void AssignAttack(string attackName)
        {
           assignedAttacks.Add(attackName);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (assignedAttacks.Any())
            {
                sb.AppendLine($"Defensive Software: {Name}, Effectiveness: {Effectiveness}, Assigned Attacks: {string.Join(", ", AssignedAttacks)}");
            }
            else
            {
                sb.AppendLine($"Defensive Software: {Name}, Effectiveness: {Effectiveness}, Assigned Attacks: [None]");
            }

            return sb.ToString().TrimEnd();
        }
    }
}