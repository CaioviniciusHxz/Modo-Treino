namespace Loja.Entities{
    class Venda : Estoque {
        public List <Estoque> __estoque {get; set;} = new List<Estoque>();
        public double Amount {get; set;}
        public double ValueTotal{get; private set;}
        
        public Venda(double amount){
            Amount = amount;
        }
        public double venda(int quantity){
            return Amount * Quantity;
        }
        public override void RemoveProduct(Products prod)
        {
            base.RemoveProduct(prod);
        }
    }
}