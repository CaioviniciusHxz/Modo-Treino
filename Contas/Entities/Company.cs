using System.Reflection.Metadata;

namespace Contas.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployess { get; set; }

        public Company(){}
        public Company(int employees, string name, double anuallncome) : base(name, anuallncome)
        {
            NumberOfEmployess = employees;

        }
        public override double Tax()
        {
            double imposto;
          if(NumberOfEmployess > 10){
            imposto = Anuallncome * 0.14;
            return imposto;
          }
          else{
            return imposto = Anuallncome * 0.16;
          }
        }
    }
}