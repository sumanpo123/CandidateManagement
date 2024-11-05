// Validators/CandidateValidator.cs
using CandidateManagement.Models;
using FluentValidation;

namespace CandidateManagement.Validators
{
    public class CandidateValidator : AbstractValidator<Candidate>
    {
        public CandidateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("A valid email is required.");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Comment is required.");
            // Add more validation rules if needed
        }
    }
}
