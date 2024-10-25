using System;

namespace LojaRoupas{
    class Estoque {
        private int Quant;
        public Roupa  Rp {get; set;}

        public Estoque( Roupa rp, int quant)
        {
            Rp = rp;
            Quant = quant;
        }
    } 
}