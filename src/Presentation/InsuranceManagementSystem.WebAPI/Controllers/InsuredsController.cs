using InsuranceManagementSystem.Business.Abstract;
using InsuranceManagementSystem.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuredsController : ControllerBase
    {
        private readonly IInsuredService _insuredService;

        public InsuredsController(IInsuredService insuredService)
        {
            _insuredService = insuredService;
        }

        [HttpPost("add")]
        public IActionResult Add(Insured insured)
        {
            var result = _insuredService.Add(insured);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
