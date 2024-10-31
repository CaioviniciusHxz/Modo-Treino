using System.Reflection.Emit;

namespace Enuns.Entities{
    class HoursContracts
    {
        public DateTime Date{get; set;}
        public double ValuePerHour {get; set;}
        public int Hours {get; set;}

        public HoursContracts(){

        }

        public HoursContracts(DateTime date, double valueperhours, int hours){

            Date = date;
            ValuePerHour = valueperhours;
            Hours = hours;
        }

        public double TotalValue(){
            return Hours * ValuePerHour;
        }
    }
}