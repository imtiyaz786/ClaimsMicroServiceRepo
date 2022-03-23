using System.Threading.Tasks;

namespace ClaimsMicroservice.Repository
{
    public interface IClaimRepository
    {
        public Task<string> SubmitClaim(int policyID, int memberID, int benefitID, int hospitalID, double claimAmt, string benefits);
        public string GetClaimStatus(int claimID, int policyID, int memberID);
    }
}
