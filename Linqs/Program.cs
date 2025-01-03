using  System;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Linqs.Entities;
using System.Globalization;

namespace Linqs{
    class Program{
        static void Main(string [] args){
            System.Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Products> products = new List<Products>();
            using(StreamReader sr = File.OpenText(path)){
                while(!sr.EndOfStream){
                    string[] file = sr.ReadLine().Split(',');
                    string name = file[0];
                    double price = double.Parse(file[1], CultureInfo.InvariantCulture);
                    products.Add(new Products(name, price));
                }
            }
            var avg = products.Select(p=> p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            var names = products.Where(p=> p.Price < avg).OrderByDescending(p => p.Name).Select(p=> p.Name);
            foreach(string name in names){
                System.Console.WriteLine(name);
            }
        }
    }
}