using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Transactions;
using Pagamentos.Entities;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            System.Console.Write("ENTER FULL FILE PATH: ");
            string path = Console.ReadLine();
            System.Console.Write("ENTER SALARY: ");
            double s = double.Parse(Console.ReadLine());
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] dados = sr.ReadLine().Split(',');
                    string name = dados[0];
                    string email = dados[1];
                    double salary = double.Parse(dados[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                    
                }

            }

            var result = employees.Where(p => p.Salary > s).Select(p => p.Email);
            var r1 = result.OrderBy(p => p);
            var soma = employees.Where(p=> p.Name[0] == 'M').Sum(p => p.Salary);
            foreach(var i in r1){
                System.Console.WriteLine(i);
            }
                
            System.Console.WriteLine($"Sum of salary of people whose name starts with 'M': {soma}");




        }
    }
}