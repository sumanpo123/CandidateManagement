using Xunit;
using Microsoft.Extensions.Caching.Memory;
using CandidateManagement.Models;
using CandidateManagement.Services;

namespace CandidateManagement.Tests
{
    public class CandidateServiceTests
    {
        private readonly CandidateService _service;
        private readonly IMemoryCache _cache;

        public CandidateServiceTests()
        {
            _cache = new MemoryCache(new MemoryCacheOptions());
            _service = new CandidateService(_cache);
        }

        [Fact]
        public void AddOrUpdateCandidate_ShouldStoreCandidateInCache()
        {
            // Arrange
            var candidate = new Candidate
            {
                Email = "sum3pok@gmail.com",
                FirstName = "SUman",
                LastName = "Pokharel"
            };

            // Act
            _service.AddOrUpdateCandidate(candidate);
            var retrievedCandidate = _service.GetCandidate(candidate.Email);

            // Assert
            Assert.NotNull(retrievedCandidate);
            Assert.Equal(candidate.FirstName, retrievedCandidate.FirstName);
            Assert.Equal(candidate.LastName, retrievedCandidate.LastName);
        }

        [Fact]
        public void GetCandidate_ShouldReturnNullIfNotFound()
        {
            // Act
            var candidate = _service.GetCandidate("notfound@gamil.com");

            // Assert
            Assert.Null(candidate);
        }
    }
}
