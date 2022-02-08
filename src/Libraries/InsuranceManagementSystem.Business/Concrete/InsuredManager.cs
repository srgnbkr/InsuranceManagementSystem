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
    public class InsuredManager : IInsuredService
    {


        private readonly IInsuredRepository _insuredRepository;

        public InsuredManager(IInsuredRepository insuredRepository)
        {
            _insuredRepository = insuredRepository;
        }

        public IResult Add(Insured insured)
        {
            insured.Status = true;
            _insuredRepository.Add(insured);
            return new SuccessResult();
        }
    }
}
