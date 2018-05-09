using Business.Entities;
using System;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IEmployerReportRepository
    {
        Task<EmployerReportEntity> GetEmployerReportList(string groupNum, DateTime periodBegin, DateTime periodEnd);
    }
}
