﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entities.Concrete
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
