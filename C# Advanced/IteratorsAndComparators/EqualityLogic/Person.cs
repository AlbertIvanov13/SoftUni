using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
		private string name;
		private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
		public string Name
		{
			get { return name; }
			set { name = value; }
		}


        public int Age
		{
			get { return age; }
			set { age = value; }
		}

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result != 0)
            {
                return result;
            }

            result = this.Age.CompareTo(other.Age);

            if (result != 0)
            {
                return result;
            }

            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person other)
            {
                return Name == other.Name && Age == other.Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}