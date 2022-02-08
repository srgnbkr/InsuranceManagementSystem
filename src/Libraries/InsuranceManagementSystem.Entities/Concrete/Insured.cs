using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entities.Concrete
{
    public class Insured
    {
        public int InsuredId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public int BirthYear { get; set; }
        public string Gender { get; set; }
        public string Degree { get; set; }
        public int CustomerId { get; set; }
        public int PolicyId { get; set; }
        public bool Status { get; set; }

    }
}
