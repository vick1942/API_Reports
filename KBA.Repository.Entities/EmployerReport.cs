using System.Collections.Generic;

namespace Repository.Entities
{
    public class EmployerReport
    {
        public List<TitlePage> TitlePage { get; set; }
        public List<FinancialSummary> FinancialSummary { get; set; }
        public List<PhmpEligibility> PhmpEligibility { get; set; }
        public List<ParticipantContacts> ParticipantContacts { get; set; }
        public List<RealTimeTelemed> RealTimeTelemed { get; set; }
        public List<DnaTesting> DnaTesting { get; set; }
        public List<RealTimeChoices> RealTimeChoices { get; set; }
        public List<RealTimeWellness> RealTimeWellness { get; set; }
        public List<RecentScreeningEventSummary> RecentScreeningEventSummary { get; set; }
        public List<ChronicConditions> ChronicConditions { get; set; }
        public List<HealthRiskAssessment> HealthRiskAssessment { get; set; }
        public List<HealthScreenings> HealthScreenings { get; set; }
        public List<IndemnityBenefit> IndemnityBenefit { get; set; }
    }
}
