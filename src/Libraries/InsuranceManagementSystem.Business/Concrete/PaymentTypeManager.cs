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
    public class PaymentTypeManager : IPaymentTypeService
    {
        private readonly IPaymentTypeRepository _paymentTypeRepository;

        public PaymentTypeManager(IPaymentTypeRepository paymentTypeRepository)
        {
            _paymentTypeRepository = paymentTypeRepository;
        }

        public IDataResult<List<PaymentType>> GetAll()
        {
            return new SuccessDataResult<List<PaymentType>>(_paymentTypeRepository.GetAll());
        }
    }
}
