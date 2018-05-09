using Business.Entities;
using IBusiness;
using IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business
{
    public class GroupBusiness :  IGroupBusiness
    {
        public readonly IGroupRepository _groupRepository;

        public GroupBusiness(IGroupRepository gr)
        {
            _groupRepository = gr;
        }
        public async Task<List<GroupEntity>> GetDistinctGroups()
        {
                return await _groupRepository.GetDistinctGroups();
        }
    }
}
