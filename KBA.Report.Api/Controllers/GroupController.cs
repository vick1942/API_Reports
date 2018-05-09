using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IBusiness;

namespace KBA.Reporting.Api.Controllers
{
    [Route("api/[controller]")]
    public class GroupController : Controller
    {
        public readonly IGroupBusiness _groupBusiness;
        public GroupController(IGroupBusiness groupBusiness)
        {
            _groupBusiness = groupBusiness;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetGroupList")]
        public async Task<JsonResult> GetGroupList()
        {
            List<Business.Entities.GroupEntity> DistinctgroupList = await _groupBusiness.GetDistinctGroups();
            return Json(DistinctgroupList);
        }

    }
}
