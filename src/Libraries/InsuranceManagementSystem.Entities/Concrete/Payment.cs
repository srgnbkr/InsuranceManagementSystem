using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entities.Concrete
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal PaymentPrice { get; set; }
        public string CreditCardNumber { get; set; }
        public int InsuredId { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
