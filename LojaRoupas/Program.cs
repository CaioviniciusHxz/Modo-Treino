using System;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using  System.Globalization;
namespace LojaRoupas
{
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Cadastra Roupa (Y/N)");
            char response = char.Parse(Console.ReadLine());
           List<string> list = new List<string>();
         do{
            int count = 1;
            count++;
            System.Console.WriteLine("CADASTRO DE ROUPA");
            System.Console.Write("NOME DA ROUPA: ");
            string nomeroupa = Console.ReadLine();
            System.Console.Write("Preço Da roupa: ");
            double priceroupa = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Codigo da Roupa");
            int codroupa = int.Parse(Console.ReadLine());
            
            Roupa rp = new Roupa(nomeroupa, priceroupa, codroupa);
            list.Add(nomeroupa);
            list.Add(priceroupa.ToString("F2", CultureInfo.InvariantCulture));
            list.Add(codroupa.ToString());
                
                
                    
            System.Console.WriteLine("Cadastra outra peça (Y/N)");
            response = char.Parse(Console.ReadLine());
            }while(response == 'Y');
           foreach(string item in list){
                System.Console.WriteLine(item);
           }
     



        }
    }
}
