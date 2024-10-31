using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace LojaRoupas
{

     class Roupa 
    {
        

        public string NameRoupa { get; set; }
        public double PriceRoupa { get; set; }
        public int CodRoupa { get; set; }
        private double ValorTotal;
        public Estoque estoque;

        public Roupa( string nomeroupa, double priceroupa, int codroupa) 
        {
        
            NameRoupa = nomeroupa;
            PriceRoupa = priceroupa;
            CodRoupa  = codroupa;

            
        }

        public void ConfirmarVenda( int quant){
            if( estoque.ComEstoque(quant) == true ){
                ValorTotal = PriceRoupa * quant;
              
            }
           
        }

     




    }
}