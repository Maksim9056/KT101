namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductRepository ProductRepository  = new ProductRepository();
            CustomerRepository CustomerRepository = new CustomerRepository();

            Product productМашина = new Product { Id = 19, Name = "Машина", Price = 1000000 };

            Customer CustomerЮлия = new Customer { Id =71, Name = "Юлия", Address = "Екатеринбург" };

            ProductRepository.Add(productМашина);
            CustomerRepository.Add(CustomerЮлия);

            Product foundProductMax = ProductRepository.FindById(19);

            Customer foundCustomerMax = CustomerRepository.FindById(71);

            Console.WriteLine(foundProductMax.Name); // Выводит "Машина"
            Console.WriteLine(foundCustomerMax.Name); // Выводит "Иван"



            Console.ReadLine();

        }
    }
}