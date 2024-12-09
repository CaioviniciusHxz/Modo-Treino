using System;
using System.Diagnostics;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces{
    class Pogram{
        static void Main(string [] args){
            System.Console.WriteLine("Enter rental data: ");
            System.Console.WriteLine("Car Model: ");
            string vehicle = Console.ReadLine();

            System.Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.WriteLine("Enter price per Hours");
            double pricePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            System.Console.WriteLine("ENter price oer Day");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(vehicle));
            RentalService rentalService = new RentalService(pricePerHours, pricePerDay, new BrazilTaxService());

            rentalService.Processvoice(carRental);
            
            System.Console.WriteLine("Invoice");
            System.Console.WriteLine(carRental.Invoice);

 
        }
    }
}