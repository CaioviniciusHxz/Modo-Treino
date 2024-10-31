using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using Enuns.Entities;
using Enuns.Entities.Enuns;

namespace Enuns{
    class Program{
        static void Main(string[] args){
            System.Console.Write("Enter department's name: ");
            string departament = Console.ReadLine();

            System.Console.Write("Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Level(Junior/ MideLevel/ Senior): ");
            workerLevel  level = Enum.Parse<workerLevel>(Console.ReadLine());
            System.Console.Write("Basy Salary: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dpt = new Departament(departament);
            Worker worker = new Worker(name, level, basesalary, dpt); 
            System.Console.Write("How many contracts to this worker ?");
            int cont = int.Parse(Console.ReadLine());

            for(int i = 1; i <= cont; i++ ){
                System.Console.WriteLine($"Enter #{i} contract date:  ");
                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                System.Console.Write("Value Per hour: ");
                double valueperhours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HoursContracts contracts = new HoursContracts(date, valueperhours, hours);
                
                worker.AddContract(contracts);
                
            }
            

            System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine("Name " + worker.Name);
            System.Console.WriteLine("Departament " + worker.Departament.Name );
            System.Console.WriteLine("Income for: " + monthAndYear + " : "+ worker.Income(year, month) );


        }
    }
}