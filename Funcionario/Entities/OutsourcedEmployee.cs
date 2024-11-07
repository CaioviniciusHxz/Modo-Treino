namespace Funcionario.Entities{
    class OutsourcedEmployee : Employee {
        public double AdditinalCharge {get; set;}

        public OutsourcedEmployee(string name, int hours, double valueperhours, double additinalcharge): base(name, hours, valueperhours ){

            AdditinalCharge = additinalcharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditinalCharge;
        }
    }
}