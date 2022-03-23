using ClaimsMicroservice.Models;
using System.Collections.Generic;

namespace ClaimsMicroservice
{
    public class ClaimData
    {
        public static List<Claim> claims = new List<Claim>()
        {
            new Claim()
            {
                ClaimID = 1,
                ClaimStatus = "Pending",
                PolicyID = 1,
                MemberID = 1,
                AmountClaimed = 45300,
                BenefitsAvailed = "Medicine&Checkup",
                HospitalID = 1,
                Remarks = "Verified",
                Settled = "False"
            },
            new Claim()
            {
                ClaimID = 2,
                ClaimStatus = "Rejected",
                PolicyID = 1,
                MemberID = 2,
                AmountClaimed = 54340,
                BenefitsAvailed = "Medicine&Checkup",
                HospitalID = 1,
                Remarks = "Verified",
                Settled = "False"
            },
            new Claim()
            {
                ClaimID = 3,
                ClaimStatus = "Invalid Details",
                PolicyID = 3,
                MemberID = 2,
                AmountClaimed = 34300,
                BenefitsAvailed = "Medicine&Checkup",
                HospitalID = 1,
                Remarks = "Verified",
                Settled = "False"
            },
            new Claim()
            {
                ClaimID = 4,
                ClaimStatus = "Pending",
                PolicyID = 2,
                MemberID = 1,
                AmountClaimed = 45300,
                BenefitsAvailed = "Accidental",
                HospitalID = 2,
                Remarks = "Not Verified",
                Settled = "False"
            }
        };
    }
}
