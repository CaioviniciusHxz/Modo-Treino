using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using Loja.Entities;

namespace Loja{
    class Program {
        static void Main(string[] args){
            Estoque estoque = new Estoque();
            System.Console.WriteLine("escolha uma das opções");
            System.Console.WriteLine("1 - Cadastro de Produto");
            System.Console.WriteLine("2 - venda de Produto");
            int option = int.Parse(Console.ReadLine());
            switch( option){
                case 1:
                    System.Console.WriteLine("cadastro de Produto");
                     char response;
                    do{
                        System.Console.WriteLine("Codigo do Produto");
                        int cod = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Nome Produto");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Preço do Produto");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        System.Console.WriteLine("Quantidade do Produto");
                        int quantity = int.Parse(Console.ReadLine());


                        Products prod = new Products (cod, name, price);
                        estoque = new Estoque(cod, quantity);
                        estoque.AddProduct(prod);


                        System.Console.WriteLine("Deseja cadastrar algum outro pedido (Y/N)");
                        response = char.Parse(Console.ReadLine());
                        if( response == 'Y'  || response == 'y'){
                            System.Console.WriteLine("Digite novamente os dados");
                        }
                      
                    }while( response == 'Y'  || response == 'y');

                    break;
            }
            System.Console.WriteLine(estoque);
          
            
            
        }
    }
}