namespace Contas.Entities{
    class Individual : TaxPayer{
      
        public double  HealthExpenditures { get; set; }

        public Individual(){}
          public Individual(double healthExpenditures, string name, double anuallncome) : base(name, anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }




        public override double Tax()
        {   
            double imposto;
            if(Anuallncome < 20000  ){
                return imposto = Anuallncome * 0.15;
            }
            else{
                return imposto = (Anuallncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}