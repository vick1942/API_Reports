using Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IBusiness
{
    public interface IGroupBusiness
    {
        Task<List<GroupEntity>> GetDistinctGroups();
    }
}
