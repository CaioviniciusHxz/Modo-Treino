namespace Parcelamento.Model.Service{
    interface IOnlinePaymentService{
        double PaymentFree(double amount);
        double Interest(double amount, int months);
    }
}