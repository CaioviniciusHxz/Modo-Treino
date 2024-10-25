using System;

namespace LojaRoupas
{

    class Roupa
    {

        public string NameRoupa { get; set; }
        public double PriceRoupa { get; set; }
        public int CodRoupa { get; set; }

        public Roupa(string nomeroupa, double priceroupa, int codroupa)
        {
            NameRoupa = nomeroupa;
            PriceRoupa = priceroupa;
            CodRoupa  = codroupa;
        }
       





    }
}