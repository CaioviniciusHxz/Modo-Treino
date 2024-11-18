using System;
using System.Globalization;
using Execoes.Entites;

namespace Execoes{
    class Program{
        static void Main(string[ ] args){
            Account account = new Account();
            System.Console.WriteLine("Enter account Data: ");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Holder: ");
            string name = Console.ReadLine();
            System.Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("WithDraw Limit: ");

            System.Console.WriteLine(account.WithdrowLimit.ToString("F2", CultureInfo.InvariantCulture));

            try{
                System.Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
            }catch(IOException e){
                System.Console.WriteLine("Valor do Saque é maior que o limite de saque");
                System.Console.WriteLine(e.Message);
            }
            

        }
    }
}