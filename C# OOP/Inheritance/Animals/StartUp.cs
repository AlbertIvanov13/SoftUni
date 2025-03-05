namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animal;
            while ((animal = Console.ReadLine()) != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (animal)
                    {
                        case "Cat":
                            Cat cat = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine(animal);
                            Console.WriteLine(cat);
                            Console.WriteLine(cat.ProduceSound());
                            break;
                        case "Dog":
                            Dog dog = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine(animal);
                            Console.WriteLine(dog);
                            Console.WriteLine(dog.ProduceSound());
                            break;
                        case "Frog":
                            Frog frog = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine(animal);
                            Console.WriteLine(frog);
                            Console.WriteLine(frog.ProduceSound());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                            Console.WriteLine(animal);
                            Console.WriteLine(kitten);
                            Console.WriteLine(kitten.ProduceSound());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(animalData[0], int.Parse(animalData[1]));
                            Console.WriteLine(animal);
                            Console.WriteLine(tomcat);
                            Console.WriteLine(tomcat.ProduceSound());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}