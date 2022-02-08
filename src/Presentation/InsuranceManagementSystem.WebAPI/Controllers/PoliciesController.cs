using InsuranceManagementSystem.Business;
using InsuranceManagementSystem.Business.Abstract;
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

        
        private readonly IPolicyService _policyService;

        public PoliciesController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var data = _policyService.GetAll();
            return Ok(data);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _policyService.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Policy policy)
        {
            var result = _policyService.Add(policy);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }



    }
}
