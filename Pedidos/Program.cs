using System ;
using System.Globalization;
using Pedidos.Entities;
using Pedidos.Entities.enuns;
namespace Pedidos{
    class Program{
        static void Main (string[]args){
            System.Console.WriteLine("Enter client data: ");
            System.Console.Write("Name: ");
            string clientName = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status =Enum.Parse<OrderStatus>(Console.ReadLine());


            Cliente cliente = new Cliente(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, cliente);
            System.Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++){
                System.Console.WriteLine($"Enter #{i} item data");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, price);

                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem (quantity, price, product);

                order.AddItem(orderItem);

            } 
            System.Console.WriteLine();
            System.Console.WriteLine("Order SUMMARY:");
            System.Console.WriteLine(order);
        }


    }
}