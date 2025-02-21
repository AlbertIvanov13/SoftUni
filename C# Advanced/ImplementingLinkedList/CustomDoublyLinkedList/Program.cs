namespace CustomDoublyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();

            customLinkedList.AddFirst(1);
            customLinkedList.AddFirst(2);
            customLinkedList.AddFirst(3);

            customLinkedList.RemoveFirst();
            customLinkedList.RemoveFirst();
        }
    }
}