namespace CustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomStack customStack = new CustomStack();

            customStack.Push(5);
            customStack.Push(9);
            customStack.Push(15);
            customStack.Push(20);
            customStack.Pop();
            customStack.Pop();

            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Peek());


        }
    }
}