namespace _01._BallGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> strengths = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> accuracies = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int totalGoalsScored = 0;

            while (strengths.Count > 0 && accuracies.Count > 0)
            {
                if (strengths.Peek() + accuracies.Peek() == 100)
                {
                    strengths.Pop();
                    accuracies.Dequeue();
                    totalGoalsScored++;
                }
                else if (strengths.Peek() + accuracies.Peek() < 100)
                {
                    if (strengths.Peek() < accuracies.Peek())
                    {
                        strengths.Pop();
                    }
                    else if (strengths.Peek() > accuracies.Peek())
                    {
                        accuracies.Dequeue();
                    }
                    else if (strengths.Peek() == accuracies.Peek())
                    {
                        int sum = strengths.Pop() + accuracies.Peek();
                        strengths.Push(sum);
                        accuracies.Dequeue();
                    }
                }
                else if (strengths.Peek() + accuracies.Peek() > 100)
                {
                    int strengthValue = strengths.Pop();
                    strengthValue -= 10;
                    strengths.Push(strengthValue);
                    int accuracy = accuracies.Dequeue();
                    accuracies.Enqueue(accuracy);
                }
            }

            if (totalGoalsScored == 3)
            {
                Console.WriteLine("Paul scored a hat-trick!");
            }
            else if (totalGoalsScored == 0)
            {
                Console.WriteLine("Paul failed to score a single goal.");
            }
            else if (totalGoalsScored > 3)
            {
                Console.WriteLine("Paul performed remarkably well!");
            }
            else if (totalGoalsScored > 0 && totalGoalsScored < 3)
            {
                Console.WriteLine("Paul failed to make a hat-trick.");
            }

            if (totalGoalsScored > 0)
            {
                Console.WriteLine($"Goals scored: {totalGoalsScored}");
            }

            if (strengths.Count > 0)
            {
                Console.WriteLine($"Strength values left: {string.Join(", ", strengths)}");
            }

            if (accuracies.Count > 0)
            {
                Console.WriteLine($"Accuracy values left: {string.Join(", ", accuracies)}");
            }
        }
    }
}