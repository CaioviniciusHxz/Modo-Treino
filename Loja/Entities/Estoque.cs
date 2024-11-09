using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.VisualBasic;

namespace Loja.Entities{
    class Estoque: Products{
        public List<Products> products{get; private set;} = new List<Products>();
        public int Quantity {get; private set;}


      public Estoque(){
        
      }
        public Estoque(int cod, int quantity) : base(cod){
            Quantity = quantity;
        }
        public Estoque(int cod, string nameproduct, double price, int quantity) : base (cod, nameproduct,price){
            Quantity = quantity;

        }

        public void AddProduct(Products prod){
            products.Add(prod);
        }
          public void RemoveProduct(Products prod){
            products.Remove(prod);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Products item in products){
              sb.AppendLine($"Codigo: {item.Cod}");
              sb.AppendLine($"Nome Product: {item.NameProduct}");
              sb.AppendLine($"Preço do Product: {item.Price}");
            }
            return sb.ToString();
        }

        /*public bool VerificarItem(Products cod ){
          int index = Products.BinarySearch(cod);
          
          if(index < 0){
            return true;
          }
          return false;
            
        }*/

    }
}