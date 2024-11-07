namespace Funcionario.Entities{
    class Employee{
        public string Name{get; set;}
        public int Hours{get; set;}
        public double ValuePerHour{get; set;}

        public Employee(){

        }
        public Employee(string name, int hours, double valueperhours){
            Name = name;
            Hours = hours;
            ValuePerHour = valueperhours;
        }
        public virtual double Payment(){
            return ValuePerHour * Hours;
        }
    }
}