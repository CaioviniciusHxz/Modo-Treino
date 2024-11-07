using System;
using System.Globalization;
using Funcionario.Entities;
namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
           


            System.Console.Write("Enter the numnber of employees: ");
            int Funcionario = int.Parse(Console.ReadLine());
            char response;
            for (int i = 0; i <= Funcionario; i++)
            {
                System.Console.WriteLine($"Employee #{i}, data: ");
                System.Console.Write("Outsourced (Y/N)? ");
                response = char.Parse(Console.ReadLine());
                System.Console.Write("Name ");
                string name = Console.ReadLine();
                System.Console.Write("Hours");
                int hours = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                System.Console.WriteLine("Value per Hours");
                double valueperhours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                if (response == 'Y' || response == 'y')
                {
                   
                    System.Console.Write("Additinal charge: ");
                    double additinalcharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, valueperhours, additinalcharge));
                    

                }
                if(response == 'N' || response == 'y'  ){
                    employees.Add(new Employee(name, hours, valueperhours));
                }
                
                else
                {
                    System.Console.WriteLine("Incorret data!");

                }
             

            }
               System.Console.WriteLine();
                System.Console.WriteLine("PAYMENTS");
                foreach(Employee item in employees){
                    System.Console.WriteLine(item.Name + " - $" + item.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }

        }
    }
}