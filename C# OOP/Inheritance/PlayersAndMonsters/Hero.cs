﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public abstract class Hero
    {
		private string username;
		private int level;

        protected Hero(string username, int level)
        {
            this.username = username;
            this.level = level;
        }

        public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public int Level
		{
			get { return level; }
			set { level = value; }
		}

		public override string ToString()
		{
			return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
		}
	}
}