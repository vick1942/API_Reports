using Business.Entities;
using System;
using System.Threading.Tasks;

namespace IBusiness
{
    public interface IEmployerReportBusiness
    {
        Task<EmployerReportEntity> GetEmployerReportList(string groupNum, DateTime periodBegin, DateTime periodEnd);
    }
}
