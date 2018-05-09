using Business.Entities;
using IBusiness;
using IRepository;
using System;
using System.Threading.Tasks;

namespace Business
{
    public class EmployerReportBusiness : IEmployerReportBusiness
    {
        public readonly IEmployerReportRepository _employerReportRepository;
        public EmployerReportBusiness(IEmployerReportRepository EmployerReportRepository)
        {
            if (Equals(_employerReportRepository, null))
                _employerReportRepository = EmployerReportRepository;
        }
        public async Task<EmployerReportEntity> GetEmployerReportList(string groupNum, DateTime periodBegin, DateTime periodEnd)
        {
            return await _employerReportRepository.GetEmployerReportList(groupNum, periodBegin, periodEnd);
        }
    }
}
