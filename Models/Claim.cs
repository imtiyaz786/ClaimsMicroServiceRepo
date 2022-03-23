namespace ClaimsMicroservice.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public string ClaimStatus { get; set; }
        public string Remarks { get; set; }
        public int PolicyID { get; set; }

        public int MemberID { get; set; }
        public int HospitalID { get; set; }
        public string BenefitsAvailed { get; set; }
        public double AmountClaimed { get; set; }
        public string Settled { get; set; }
    }
}
