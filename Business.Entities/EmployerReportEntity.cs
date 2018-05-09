using System.Collections.Generic;

namespace Business.Entities
{
    public class EmployerReportEntity
    {
        public List<TitlePageEntity> TitlePage { get; set; }
        public List<FinancialSummaryEntity> FinancialSummary { get; set; }
        public List<PhmpEligibilityEntity> PhmpEligibility { get; set; }
        public List<ParticipantContactsEntity> ParticipantContacts { get; set; }
        public List<RealTimeTelemedEntity> RealTimeTelemed { get; set; }
        public List<DnaTestingEntity> DnaTesting { get; set; }
        public List<RealTimeChoicesEntity> RealTimeChoices { get; set; }
        public List<RealTimeWellnessEntity> RealTimeWellness { get; set; }
        public List<RecentScreeningEventSummaryEntity> RecentScreeningEventSummary { get; set; }
        public List<ChronicConditionsEntity> ChronicConditions { get; set; }
        public List<HealthRiskAssessmentEntity> HealthRiskAssessment { get; set; }
        public List<HealthScreeningsEntity> HealthScreenings { get; set; }
        public List<IndemnityBenefitEntity> IndemnityBenefit { get; set; }
        public double ExecutionTime { get; set; }
    }
}
