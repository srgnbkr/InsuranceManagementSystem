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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IResult Add(Customer customer)
        {
            
            _customerRepository.Add(customer);
            return new SuccessResult(customer.FirstName+" "+customer.LastName+" Sisteme Eklendi");
        }
    }
}
