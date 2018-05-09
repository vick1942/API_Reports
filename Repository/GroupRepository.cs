using Business.Entities;
using Common;
using IRepository;
using Repository.Entities;
using Utilities.Mapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class GroupRepository : IGroupRepository
    {
        private readonly IOptions<SqlStoreProcedureKeys> _sqlStoreProcedureKeys;
        private SettingsDBContext dbConnection;

        public GroupRepository()
        {
            dbConnection = new SettingsDBContext("name=" + Constants.SqlConnectionString);
        }
        public async Task<List<GroupEntity>> GetDistinctGroups()
        {
            try
            {
                List<Groups> resultSet = await dbConnection.Database.SqlQuery<Groups>(ConfigurationManager.AppSettings["PrsSchema"] + Constants.DOT + ConfigurationManager.AppSettings["GetDistinctGroups"]).ToListAsync();
                dbConnection.CommitChanges();
                List<Groups> groupList = ReturnList(resultSet).ToList();
                List<GroupEntity> groupEntitiesList = EntityMapper<Groups, GroupEntity>.MapEntityCollection(groupList);
                return groupEntitiesList;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public IEnumerable<Groups> ReturnList(IEnumerable<Groups> obj)
        {
            List<Groups> domainObjects = new List<Groups>();

            foreach (Groups dataObject in obj)
                domainObjects.Add(dataObject);

            return domainObjects;
        }
    }
}
