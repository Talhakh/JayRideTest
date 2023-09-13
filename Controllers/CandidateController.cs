using JayRideTest.DTO;
using Microsoft.AspNetCore.Mvc;

namespace JayRideTest.Controllers
{
    [ApiController]
    [Route("[candidate]")]
    public class CandidateController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CandidateController> _logger;

        public CandidateController(ILogger<CandidateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCandidateData()
        {
            var candidateData = new
            {
                name = "test",
                phone = "test"
            };

            return Ok(candidateData);
        }
    }
}