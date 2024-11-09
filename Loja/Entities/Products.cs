namespace Loja.Entities{
    class Products{
        public int Cod {get; private set;}
        public string NameProduct{ get; private set;}
        public double Price {get; private set;}
        

        public Products(){

        } 
        public Products(int cod){
            Cod = cod;
        }

        public Products(int cod, string nameproduct, double price){
            Cod = cod;
            NameProduct = nameproduct;
            Price = price;
            
        }

    }
}