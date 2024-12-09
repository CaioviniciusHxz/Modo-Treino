
using Parcelamento.Model.Entities;

namespace Parcelamento.Model.Service{
    class ContractService {

        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePaymentService){
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract( Contract contract, int months){
            double basicQuota = contract.TotalValue  / months;
            for(int i = 1; i< months; i++){
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuato = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuato + _onlinePaymentService.PaymentFree(updatedQuato);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }

    }
}