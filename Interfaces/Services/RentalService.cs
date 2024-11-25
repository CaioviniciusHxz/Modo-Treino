using Interfaces.Entities;

namespace Interfaces.Services{
    class RentalService
    {
       public double  PricePerHours { get; private set; }   
       public double  PricePerDay { get; private set; }  


       private ITaxServices _TaxService ;


       public RentalService(double pricePerHours, double pricePerDay, ITaxServices taxServices){
        PricePerHours= pricePerHours;
        PricePerDay = pricePerDay;
        _TaxService = taxServices;
       }

       public void Processvoice (CarRental carRental){
        TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

        double basicPayment = 0.0;

        if(duration.TotalHours <= 12){
            basicPayment = PricePerHours * Math.Ceiling(duration.TotalHours);
        }
        else{
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }
        double tax = _TaxService.Tax(basicPayment);
        
        carRental.Invoice = new Invoice(basicPayment, tax);


       }
    }
}