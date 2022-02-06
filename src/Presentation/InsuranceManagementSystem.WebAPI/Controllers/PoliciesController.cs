using InsuranceManagementSystem.DataAccess.Abstract;
using InsuranceManagementSystem.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliciesController : ControllerBase
    {

        private readonly IPolicyRepository policyRepository;

        public PoliciesController(IPolicyRepository policyRepository)
        {
            this.policyRepository = policyRepository;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var data = policyRepository.GetAll();
            return Ok(data);
        }


        [HttpPost("add")]
        public IActionResult AddPolicy(Policy policy)
        {
            var data = policyRepository.Add(policy);
            return Ok(data);
        }
    }
}
