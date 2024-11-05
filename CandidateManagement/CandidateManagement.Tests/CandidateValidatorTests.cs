using Xunit;
using FluentValidation.TestHelper;
using CandidateManagement.Models;
using CandidateManagement.Validators;

namespace CandidateManagement.Tests
{
    public class CandidateValidatorTests
    {
        private readonly CandidateValidator _validator;

        public CandidateValidatorTests()
        {
            _validator = new CandidateValidator();
        }

        [Fact]
        public void Validate_ShouldHaveError_WhenFirstNameIsEmpty()
        {
            // Arrange
            var candidate = new Candidate { FirstName = " ", LastName = "Pokharel", Email = "sum3pok@gmail.com", Comment = "Applying for software Engineer" };

            // Act
            var result = _validator.TestValidate(candidate);

            // Assert
            result.ShouldHaveValidationErrorFor(x => x.FirstName);
        }

        [Fact]
        public void Validate_ShouldHaveError_WhenEmailIsInvalid()
        {
            // Arrange
            var candidate = new Candidate { FirstName = "Suman", LastName = "Pokharel", Email = "invalid-email", Comment = "Applying for software Engineer" };

            // Act
            var result = _validator.TestValidate(candidate);

            // Assert
            result.ShouldHaveValidationErrorFor(x => x.Email);
        }

        [Fact]
        public void Validate_ShouldHaveNoErrors_WhenValidCandidate()
        {
            // Arrange
            var candidate = new Candidate
            {
                FirstName = "Suman",
                LastName = "Pokharel",
                Email = "sum3pok@gmail.com",
                Comment = "Applying for software Engineer"
            };

            // Act
            var result = _validator.TestValidate(candidate);

            // Assert
            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
