using InsuranceManagementSystem.Core.Utilities.Results;
using InsuranceManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Business.Abstract
{
    public interface IPolicyService
    {
        IDataResult<List<Policy>> GetAll();
        IDataResult<Policy> GetById(int id);
        IResult Add(Policy policy);
    }
}
