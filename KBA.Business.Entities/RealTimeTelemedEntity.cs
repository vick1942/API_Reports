namespace Business.Entities
{
    public class RealTimeTelemedEntity
    {
        public int ConsultsPrimaryCareConsultCount { get; set; }
        public int ConsultsPrimaryCareConsultAverageCost { get; set; }
        public int ConsultsPrimaryCareConsultTotalSavings { get; set; }
        public int ConsultsUrgentCareConsultCount { get; set; }
        public int ConsultsUrgentCareConsultAverageCost { get; set; }
        public int ConsultsUrgentCareConsultTotalSavings { get; set; }
        public int ConsultsEmergencyRoomConsultCount { get; set; }
        public int ConsultsEmergencyRoomConsultAverageCost { get; set; }
        public int ConsultsEmergencyRoomConsultTotalSavings { get; set; }
        public int ConsultsTotalCount { get; set; }
        public int ConsultsTotalSavings { get; set; }
        public int TimeFramesOvernightCount { get; set; }
        public int TimeFramesOvernightPercent { get; set; }
        public int TimeFramesMorningCount { get; set; }
        public int TimeFramesMorningPercent { get; set; }
        public int TimeFramesAfternoonCount { get; set; }
        public int TimeFramesAfternoonPercent { get; set; }
        public int TimeFramesEveningCount { get; set; }
        public int TimeFramesEveningPercent { get; set; }
        public int TimeFramesTotalCount { get; set; }
        public int TimeFramesTotalPercent { get; set; }
        public string Top5DiagnosesFirstDiagnosisName { get; set; }
        public int Top5DiagnosesFirstDiagnosisCount { get; set; }
        public string Top5DiagnosesSecondDiagnosisName { get; set; }
        public int Top5DiagnosesSecondDiagnosisCount { get; set; }
        public string Top5DiagnosesThirdDiagnosisName { get; set; }
        public int Top5DiagnosesThirdDiagnosisCount { get; set; }
        public string Top5DiagnosesFourthDiagnosisName { get; set; }
        public int Top5DiagnosesFourthDiagnosisCount { get; set; }
        public string Top5DiagnosesFifthDiagnosisName { get; set; }
        public int Top5DiagnosesFifthDiagnosisCount { get; set; }
        public int Top5DiagnosesTotalDiagnosisCount { get; set; }
        public int ConsultsByAgePercentLessThan25 { get; set; }
        public int ConsultsByAgePercent25to29 { get; set; }
        public int ConsultsByAgePercent30to34 { get; set; }
        public int ConsultsByAgePercent35to39 { get; set; }
        public int ConsultsByAgePercent40to44 { get; set; }
        public int ConsultsByAgePercent45to49 { get; set; }
        public int ConsultsByAgePercent50to54 { get; set; }
        public int ConsultsByAgePercent55to59 { get; set; }
        public int ConsultsByAgePercent60to65 { get; set; }
        public int ConsultsByAgePercentGreaterThan65 { get; set; }
        public int ConsultSavingsTotalConsults { get; set; }
        public int ConsultSavingsAverageSavings { get; set; }
        public int ConsultSavingsTotalSavings { get; set; }
    }
}
