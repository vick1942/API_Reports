namespace Repository.Entities
{
    public class FinancialSummary
    {
        public int ParticipantCount { get; set; }
        public int TotalSpendableIncomeIncrease { get; set; }
        public int TotalFICASavings { get; set; }
        public int AdditionalFicaSavings25 { get; set; }
        public int AdditionalFicaSavings50 { get; set; }
        public int AdditionalFicaSavings75 { get; set; }
    }
}
