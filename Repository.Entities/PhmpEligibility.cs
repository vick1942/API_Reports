namespace Repository.Entities
{
    public class PhmpEligibility
    {
        public int ParticipantsByGenderPercentMale { get; set; }
        public int ParticipantsByGenderPercentFemale { get; set; }
        public int ParticipantsByAgePercentLessThan25 { get; set; }
        public int ParticipantsByAgePercent25to29 { get; set; }
        public int ParticipantsByAgePercent30to34 { get; set; }
        public int ParticipantsByAgePercent35to39 { get; set; }
        public int ParticipantsByAgePercent40to44 { get; set; }
        public int ParticipantsByAgePercent45to49 { get; set; }
        public int ParticipantsByAgePercent50to54 { get; set; }
        public int ParticipantsByAgePercent55to59 { get; set; }
        public int ParticipantsByAgePercent60to65 { get; set; }
        public int ParticipantsByAgePercentGreaterThan65 { get; set; }
    }
}
