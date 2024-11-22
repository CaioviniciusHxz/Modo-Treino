using System;
using System.Globalization;
using Arquivos.Entities;
namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFoldePath = sourceFolderPath + @"/out";
                string targetFilePath = targetFoldePath + @"/summary.xlsx";

                Directory.CreateDirectory(targetFoldePath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                        Products product = new Products(name, price, quantity);

                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("An error  occurred");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}