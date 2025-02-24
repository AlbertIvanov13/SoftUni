namespace CustomQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomQueue customQueue = new CustomQueue();

            customQueue.Enqueue(1);
            customQueue.Enqueue(2);
            customQueue.Enqueue(5);
            customQueue.Enqueue(4);

            customQueue.Peek();
        }
    }
}