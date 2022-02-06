using InsuranceManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.DataAccess.Abstract
{
    public interface IPolicyRepository
    {
        List<Policy> GetAll();
        Policy Add(Policy policy);
    }
}
