namespace _04._ClickBait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> suggestedLinks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> featuredArticles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int targetEngagementValue = int.Parse(Console.ReadLine());

            List<int> finalFeedCollection = new List<int>();

            while (suggestedLinks.Count > 0 && featuredArticles.Count > 0)
            {
                int link = suggestedLinks.Dequeue();
                int article = featuredArticles.Pop();

                if (article > link)
                {
                    int remainder = article % link;
                    finalFeedCollection.Add(0 + remainder);
                    if (remainder != 0)
                    {
                        featuredArticles.Push(remainder * 2);
                    }
                }
                else if (link > article)
                {
                    int remainder = link % article;
                    int negativeRemainder = 0 - remainder;
                    finalFeedCollection.Add(negativeRemainder);
                    if (remainder != 0)
                    {
                        suggestedLinks.Enqueue(remainder * 2);
                    }
                }
                else
                {
                    finalFeedCollection.Add(0);
                }
            }

            Console.WriteLine($"Final Feed: {string.Join(", ", finalFeedCollection)}");
            int totalEngagementValue = finalFeedCollection.Sum(x => x);
            if (totalEngagementValue >= targetEngagementValue)
            {
                Console.WriteLine($"Goal achieved! Engagement Value: {totalEngagementValue}");
            }
            else
            {
                int shortfall = targetEngagementValue - totalEngagementValue;
                Console.WriteLine($"Goal not achieved! Short by: {shortfall}");
            }
        }
    }
}