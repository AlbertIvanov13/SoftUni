namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new[] { "1", "2", "3", "4", "5" });

            Console.WriteLine(stack.IsEmpty());
        }
    }
}