using Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IGroupRepository 
    {
        Task<List<GroupEntity>> GetDistinctGroups();
    }
}
