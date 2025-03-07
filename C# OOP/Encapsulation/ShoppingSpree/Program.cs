using System.Linq.Expressions;
using System.Net.Http.Headers;
using ShoppingSpree.Models;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            List<Product> productList = new List<Product>();
            try
            {
                string[] persons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in persons)
                {
                    string[] nameAge = item.Split("=");
                    if (string.IsNullOrEmpty(nameAge[0]) || string.IsNullOrWhiteSpace(nameAge[0]))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    Person person = new Person(nameAge[0], decimal.Parse(nameAge[1]));
                    personList.Add(person);
                }

                foreach (var item in products)
                {
                    string[] productPrice = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    if (string.IsNullOrWhiteSpace(productPrice[0]) || string.IsNullOrEmpty(productPrice[0]))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    Product product = new Product(productPrice[0], decimal.Parse(productPrice[1]));
                    productList.Add(product);
                }
            string nameProduct;
            while ((nameProduct = Console.ReadLine()) != "END")
            {
                string[] tokens = nameProduct.Split(" ");
                foreach (Person person in personList)
                {
                    if (tokens[0] == person.Name)
                    {
                        foreach (Product product in productList)
                        {
                            if (tokens[1] == product.Name)
                            {
                                person.BuyProducts(person, product);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            foreach (Person person in personList)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.Write($"{person.Name} - ");
                    Console.WriteLine(string.Join(", ", person.BagOfProducts.Select(p => p.Name)));
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}