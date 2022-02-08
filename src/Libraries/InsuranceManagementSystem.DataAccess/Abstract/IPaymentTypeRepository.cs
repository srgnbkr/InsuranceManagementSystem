using InsuranceManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.DataAccess.Abstract
{
    public interface IPaymentTypeRepository
    {
        List<PaymentType> GetAll();
    }
}
