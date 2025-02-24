namespace CustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomStack<int> customStack = new CustomStack<int>();

            customStack.Push(5);
            customStack.Push(9);
            customStack.Push(15);
            customStack.Push(20);
            customStack.Pop();
            customStack.Pop();

            customStack.ForEach(x => Console.WriteLine(x));
        }
    }
}