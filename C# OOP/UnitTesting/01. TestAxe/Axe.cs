﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._TestAxe
{
    public class Axe
    {
        private int attackPoints;
        private int durabilityPoints;

        public Axe(int attack, int durability)
        {
            this.attackPoints = attack;
            this.durabilityPoints = durability;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DurabilityPoints
        {
            get { return this.durabilityPoints; }
        }

        public void Attack(Dummy target)
        {
            if (this.durabilityPoints <= 0)
            {
                throw new InvalidOperationException("Axe is broken.");
            }

            target.TakeAttack(this.attackPoints);
            this.durabilityPoints -= 1;
        }
    }
}