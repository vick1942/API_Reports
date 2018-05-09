namespace Business.Entities
{
    public class IndemnityBenefitEntity
    {
        public int MembersReceivingBenefitsCount { get; set; }
        public int TotalDaysPaidCount { get; set; }
        public int AveragePaidPerMember { get; set; }
        public int TotalPaid { get; set; }
    }

}
