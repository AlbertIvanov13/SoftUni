namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            FamilyCar sportCar = new FamilyCar(300, 100);
            sportCar.Drive(10);
            Console.WriteLine(sportCar.Fuel);
        }
    }
}