using System;

namespace LojaRoupas{
     class Venda : Roupa    {

        public Venda( string nomeroupa, double priceroupa, int codroupa) : base(nomeroupa, priceroupa, codroupa)
        {
        }
         public double TotalVenda(int quant){
           return PriceRoupa *= quant;
        }
        
    }
}