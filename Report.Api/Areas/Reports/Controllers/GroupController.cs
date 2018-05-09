using IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Report.Api.Areas.Reports.Controllers
{
    public class GroupController : ApiController
    {
        public readonly IGroupBusiness _groupBusiness;
        public GroupController(IGroupBusiness groupBusiness)
        {
            _groupBusiness = groupBusiness;
        }
        
        [HttpGet]
        [ActionName("GetGroupList")]
        public async Task<IHttpActionResult> GetGroupList()
        {
            List<Business.Entities.GroupEntity> DistinctgroupList = await _groupBusiness.GetDistinctGroups();
            return Json(new { DistinctgroupList });
        }
    }
}
