using System;
using System.Globalization;
using Execoes.Entites;
using Execoes.Entites.Execption;

namespace Execoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
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
                account = new Account(number, name,balance);


                System.Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Ex(amount);
                System.Console.WriteLine("Saldo Atualizado:" + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExeception e)
            {
                System.Console.WriteLine("ERROR" + e.Message);

            }


        }
    }
}