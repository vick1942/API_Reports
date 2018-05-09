using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IBusiness;
using Business.Entities;

namespace KBA.Reporting.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployerReportController : Controller
    {
        public readonly IEmployerReportBusiness _employerReportBusiness;
        public EmployerReportController(IEmployerReportBusiness employerReportBusiness)
        {
            _employerReportBusiness = employerReportBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("GetEmployerReport")]
        public async Task<JsonResult> GetEmployeedReport(string groupNum, DateTime periodBegin, DateTime periodEnd)
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
