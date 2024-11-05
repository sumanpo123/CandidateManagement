// Controllers/CandidatesController.cs
using CandidateManagement.Models;
using CandidateManagement.Services;
using CandidateManagement.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CandidateManagement.Controllers
{
    [ApiController]
    [Route("api/candidates")]
    public class CandidatesController : ControllerBase
    {
        private readonly CandidateService _candidateService;
        private readonly IValidator<Candidate> _validator;

        public CandidatesController(CandidateService candidateService, IValidator<Candidate> validator)
        {
            _candidateService = candidateService;
            _validator = validator;
        }

        [HttpPost]
        public IActionResult CreateOrUpdateCandidate([FromBody] Candidate candidate)
        {
            var validationResult = _validator.Validate(candidate);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            _candidateService.AddOrUpdateCandidate(candidate);
            return Ok("Candidate information saved successfully.");
        }

        [HttpGet("{email}")]
        public IActionResult GetCandidate(string email)
        {
            var candidate = _candidateService.GetCandidate(email);
            if (candidate == null)
            {
                return NotFound();
            }

            return Ok(candidate);
        }
    }
}
