namespace CustomList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomList customList = new CustomList();

            customList.Add(5);
            customList.Add(8);
            customList.Add(9);
            customList.Add(15);

            customList.RemoveAt(0);

            //customList.Insert(1, 20);

            customList.Contains(8);
            customList.Contains(99);

            customList.Swap(1, 3);
        }
    }
}