using System;
using Parcelamento.Model.Entities;
using Parcelamento.Model.Service;
using System.Globalization;
namespace Parcelamento{
    class Program{
        static void Main(string [] args){
            System.Console.WriteLine("ENTER CONTRACT DATA: ");
            System.Console.Write("NUMBER: ");
            int contractNumber = int.Parse(Console.ReadLine());
            System.Console.Write("DATE (DD/MM/YYYY)");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            System.Console.Write("Contratc value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("ENTER NUMBER DE OF INSTALLMENTS: ");
            int months = int.Parse(Console.ReadLine());
            Contract MyContract = new Contract(contractNumber, contractDate, contractValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(MyContract, months);

            System.Console.WriteLine("INSTALLMENT: ");
            foreach(Installment installment in MyContract.Installments){
                System.Console.WriteLine(installment);
            }
        }
    }
}