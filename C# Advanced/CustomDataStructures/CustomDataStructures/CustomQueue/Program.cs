namespace CustomQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomQueue<string> customQueue = new CustomQueue<string>();

            //customQueue.Enqueue(1);
            //customQueue.Enqueue(2);
            //customQueue.Enqueue(5);
            //customQueue.Enqueue(4);

            customQueue.Enqueue("Albert");
            customQueue.Enqueue("Tsvetty");

            customQueue.Peek();

            customQueue.ForEach(x => Console.WriteLine(x));
        }
    }
}