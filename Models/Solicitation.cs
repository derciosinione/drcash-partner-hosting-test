namespace DrcashPartner.Models;

public class Solicitation
{ 
        public int Id { get; set; }

        public string RequestedAmount { get; set; }
        
        public string InstallmentOfRequestedAmount { get; set; }
        
        public string MonthlyIncome { get; set; }

        public string ContractId { get; set; }
        
        public string NumeroProtocolo { get; set; }
        
        public int NumeroProposta { get; set; }

        public int StatusTypeId { get; set; }
        
        public string UserId { get; set; }
        
        public int? ClinicId { get; set; }

        public int SolicitationTypeId { get; set; }
        
        public int ServiceTypeId { get; set; }
        
        public double TacValue { get; set; }
        
        public int CoefficientId { get; set; }
        
        public bool isDeleted { get; set; }
        
        public bool isBeneficiaryInformed { get; set; }
        
        public bool isPaymentRequested { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
        
        public DateTime? PaymentRequestDate { get; set; }
        
        public DateTime? PaymentDoneDate { get; set; }
        
        public string CancelationReason { get; set; }

        public DateTime? CancellationDate { get; set; }

        public float HomogeneousGroup { get; set; }

        public double ClinicRetention { get; set; }
}