using InsuranceManagementSystem.Business.Abstract;
using InsuranceManagementSystem.Core.Utilities.Results;
using InsuranceManagementSystem.DataAccess.Abstract;
using InsuranceManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IInsuredRepository _insuredRepository;


        public PaymentManager(IPaymentRepository paymentRepository, ICustomerRepository customerRepositoy, IInsuredRepository insuredRepository)
        {
            _paymentRepository = paymentRepository;
            _insuredRepository = insuredRepository;
            _customerRepository =  customerRepositoy;
           
        }

        public IResult Payment(Payment payment)
        {
            _paymentRepository.Add(payment);
            return new SuccessResult();
        }

        
    }
}
