using System;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using  System.Globalization;
namespace LojaRoupas
{
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Cadastra Roupa ");
            char response;
            string[] Principal = new string[]{};
            List<string> Nome = new List<string>();
            List<int> Codigo = new List<int>();
            List<double> Preco = new List<double>();
            List<int> Quantidade = new List<int>();

            Principal[0] = Codigo.ToString();
            Principal[1] = Nome.ToString();
            Principal[2] = Quantidade.ToString();
            Principal[3] = Preco.ToString();
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
            System.Console.WriteLine("Quantidade de peça");
            int quant = int.Parse(Console.ReadLine());
            
            Roupa rp = new Roupa(nomeroupa, priceroupa, codroupa);
            
          
            Codigo.Add(codroupa);
            Nome.Add(nomeroupa);
            Quantidade.Add(quant);
            Preco.Add(priceroupa);
            
              Estoque estoqueClass = new Estoque(Principal);
                
                
                    
            System.Console.WriteLine("Cadastra outra peça (Y/N)");
            response = char.Parse(Console.ReadLine());
            }while(response == 'Y');
          
     



        }
    }
}
