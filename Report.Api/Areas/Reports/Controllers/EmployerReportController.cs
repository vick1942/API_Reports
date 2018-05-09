using Business;
using Business.Entities;
using IBusiness;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Report.Api.Areas.Reports.Controllers
{
    public class EmployerReportController : ApiController
    {
        public readonly IEmployerReportBusiness _employerReportBusiness;
        public EmployerReportController(IEmployerReportBusiness employerReportBusiness)
        {
            _employerReportBusiness = employerReportBusiness;
        }

        [HttpGet]
        [ActionName("GetEmployerReport")]
        public async Task<IHttpActionResult> GetEmployeedReport(string groupNum, DateTime periodBegin, DateTime periodEnd)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            EmployerReportEntity DistinctgroupList = await _employerReportBusiness.GetEmployerReportList(groupNum, periodBegin, periodEnd);
            watch.Stop();
            if (DistinctgroupList != null)
                DistinctgroupList.ExecutionTime = Math.Round(TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds).TotalSeconds, 2);

            return Json(DistinctgroupList);
        }
    }
}
