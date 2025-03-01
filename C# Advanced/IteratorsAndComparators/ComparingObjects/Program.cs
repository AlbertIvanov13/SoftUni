namespace ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            int totalMatches = 1;
            int nonMatches = 0;

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split(" ");
                Person person = new Person(input[0], int.Parse(input[1]), input[2]);
                persons.Add(person);
            }

            int comparablePerson = int.Parse(Console.ReadLine());

            for (int i = 0; i < persons.Count - 1; i++)
            {
                if (persons[i].CompareTo(persons[i + 1]) == 0)
                {
                    totalMatches++;
                }
                else
                {
                    nonMatches++;
                }
            }

            if (totalMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{totalMatches} {nonMatches} {persons.Count}");
            }
        }
    }
}