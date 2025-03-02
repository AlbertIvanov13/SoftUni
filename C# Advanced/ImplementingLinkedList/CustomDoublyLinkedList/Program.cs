namespace CustomDoublyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>();

            //customLinkedList.AddFirst(1);
            //customLinkedList.AddFirst(2);
            //customLinkedList.AddFirst(3);

            //customLinkedList.AddFirst("Albert");
            //customLinkedList.AddFirst("Tsvetty");
            //customLinkedList.AddFirst("Vesko");

            customLinkedList.AddLast("Albert");
            customLinkedList.AddLast("Tsvetty");
            customLinkedList.AddLast("Vesko");

            //customLinkedList.RemoveFirst();
            //customLinkedList.RemoveFirst();

            foreach (var item in customLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}