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
    public class PolicyManager : IPolicyService
    {
        private readonly IPolicyRepository _policyRepository;

        public PolicyManager(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }

        public IResult Add(Policy policy)
        {
            _policyRepository.Add(policy);
            
            return new SuccessResult();
            
        }

        public IDataResult<List<Policy>> GetAll()
        {
            var data = _policyRepository.GetAll();
            return new SuccessDataResult<List<Policy>>(data,"Listed");
        }

        public IDataResult<Policy> GetById(int id)
        {
            return new SuccessDataResult<Policy>(_policyRepository.GetById(id));
        }
    }
}
