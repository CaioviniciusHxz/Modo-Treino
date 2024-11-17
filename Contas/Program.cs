using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Contas.Entities;

namespace Contas{
    class Program{
        static void Main(string[] args){
        System.Console.Write("Enter the number of tax Payers: ");
        int n = int.Parse(Console.ReadLine());
        
        List<TaxPayer> taxes = new List<TaxPayer>();
        for(int i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"Tax payer #{i} data");
            System.Console.Write("Individual or Company (i/c): ");
            char response = char.Parse(Console.ReadLine());
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Anual income: ");
            double anuallncome = double.Parse(Console.ReadLine());
            if(response == 'i'){
                System.Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine());
                taxes.Add(new Individual(healthExpenditures, name, anuallncome));
               
            }
            else{
                System.Console.WriteLine("Number employeer: ");
                int employeer = int.Parse(Console.ReadLine());
                taxes.Add(new Company(employeer, name, anuallncome));
            }
            
        }
        System.Console.WriteLine("Taxes Paid: ");
        double soma = 0;
        foreach(TaxPayer item in taxes){
            System.Console.WriteLine($"{item.Name}: $ {item.Tax().ToString("F2", CultureInfo.InvariantCulture)} ");
            soma += item.Tax();
        }
        System.Console.WriteLine($"Total taxes: $ {soma.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}