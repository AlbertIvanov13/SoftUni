namespace _07._WildSurvival
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bees = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> beeEaters = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int beesGroup = 0;
            int beeEatersGroup = 0;
            while (bees.Count > 0 || beeEaters.Count > 0)
            {
                if (bees.Count > 0)
                {
                    beesGroup = bees.Peek();
                }
                if (beeEaters.Count > 0)
                {
                    beeEatersGroup = beeEaters.Peek();
                }
                while (beesGroup > 0 || beeEatersGroup > 0)
                {
                    if ((beesGroup >= 7 && beeEatersGroup > 0) && (bees.Count > 0 && beeEaters.Count > 0))
                    {
                        beesGroup -= 7;
                        beeEatersGroup--;
                        if (beesGroup == 0 && beeEatersGroup == 0)
                        {
                            bees.Dequeue();
                            beeEaters.Pop();
                        }
                    }
                    else if ((beesGroup < 7 && beeEatersGroup > 0) && (bees.Count > 0 && beeEaters.Count > 0))
                    {
                        beesGroup = 0;
                        bees.Dequeue();
                        beeEaters.Pop();
                        int newGroup = 0;
                        if (beeEaters.Count > 0)
                        {
                            newGroup = beeEaters.Pop();
                        }
                        beeEaters.Push(newGroup + beeEatersGroup);
                        break;
                    }
                    else if ((beeEatersGroup == 0 && beesGroup > 0) && (bees.Count > 0 && beeEaters.Count > 0))
                    {
                        int remainingBees = beesGroup;
                        bees.Dequeue();
                        bees.Enqueue(remainingBees);
                        beeEaters.Pop();
                        break;
                    }
                    else if ((beesGroup == beeEatersGroup) && (bees.Count > 0 && beeEaters.Count > 0))
                    {
                        bees.Dequeue();
                        beeEaters.Pop();
                        break;
                    }
                    
                    if (bees.Count == 0 || beeEaters.Count == 0)
                    {
                        Console.WriteLine("The final battle is over!");
                        if (bees.Count == 0 && beeEaters.Count == 0)
                        {
                            Console.WriteLine("But no one made it out alive!");
                            Environment.Exit(0);
                        }
                        else if (bees.Count > beeEaters.Count)
                        {
                            Console.WriteLine($"Bee groups left: {string.Join(", ", bees)}");
                            Environment.Exit(0);
                        }
                        else if (beeEaters.Count > bees.Count)
                        {
                            Console.WriteLine($"Bee-eater groups left: {string.Join(", ", beeEaters)}");
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}