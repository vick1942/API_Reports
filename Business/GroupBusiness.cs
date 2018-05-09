using Business.Entities;
using IBusiness;
using IRepository;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business
{
    public class GroupBusiness :  IGroupBusiness
    {
        public readonly IGroupRepository _groupRepository;
        public GroupBusiness()
        {
            _groupRepository = new GroupRepository();
        }
        public async Task<List<GroupEntity>> GetDistinctGroups()
        {
                return await _groupRepository.GetDistinctGroups();
        }
    }
}
