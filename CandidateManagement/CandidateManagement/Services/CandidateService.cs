// Services/CandidateService.cs
using CandidateManagement.Models;
using Microsoft.Extensions.Caching.Memory;

namespace CandidateManagement.Services
{
    public class CandidateService
    {
        private readonly IMemoryCache _cache;

        public CandidateService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void AddOrUpdateCandidate(Candidate candidate)
        {
            _cache.Set(candidate.Email, candidate);
        }

        public Candidate GetCandidate(string email)
        {
            _cache.TryGetValue(email, out Candidate candidate);
            return candidate;
        }
    }
}
