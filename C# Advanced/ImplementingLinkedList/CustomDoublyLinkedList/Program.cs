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

            customLinkedList.AddFirst("Albert");

            customLinkedList.RemoveFirst();
            customLinkedList.RemoveFirst();
        }
    }
}