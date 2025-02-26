using CustomLinkedList;

namespace CustomDoublyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomDoublyLinkedList<string> customLinkedList = new CustomDoublyLinkedList<string>();

            //customLinkedList.AddFirst(1);
            //customLinkedList.AddFirst(2);
            //customLinkedList.AddFirst(3);

            customLinkedList.AddFirst("Albert");

            customLinkedList.RemoveFirst();
        }
    }
}