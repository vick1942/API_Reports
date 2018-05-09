using Business.Entities;
using Common;
using IRepository;
using Repository.Entities;
using Utilities.Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Repository
{
    public class EmployerReportRepository : IEmployerReportRepository
    {
        private readonly IOptions<SqlStoreProcedureKeys> _sqlStoreProcedureKeys;
        private SettingsDBContext dbConnection;

        public EmployerReportRepository(IOptions<SqlStoreProcedureKeys> sqlStoreProcedureKeys)
        {
            _sqlStoreProcedureKeys = sqlStoreProcedureKeys;
            dbConnection = new SettingsDBContext(_sqlStoreProcedureKeys.Value.SqlConnectionString);
        }

        public async Task<EmployerReportEntity> GetEmployerReportList(string groupNum, DateTime periodBegin, DateTime periodEnd)
        {
            try
            {
                using (var connection = dbConnection.Database.Connection)
                {
                    if (connection != null && connection.State != ConnectionState.Open)
                        await connection.OpenAsync();

                    DbCommand command = connection.CreateCommand();
                    command.CommandText = Constants.EXEC + _sqlStoreProcedureKeys.Value.PrsSchema + Constants.DOT + _sqlStoreProcedureKeys.Value.GetEmployerReport +
                                            Constants.SPACE + Constants.Group_NUM + Constants.COMMA + Constants.PERIOD_BEGIN + Constants.COMMA + Constants.PERIOD_END;

                    command.Parameters.AddRange(new[]
                    {
                         new SqlParameter { ParameterName = Constants.Group_NUM, Value = groupNum },
                         new SqlParameter { ParameterName = Constants.PERIOD_BEGIN, Value = periodBegin },
                         new SqlParameter { ParameterName = Constants.PERIOD_END, Value = periodEnd }
                    });

                    command.CommandTimeout = 0;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            EmployerReport employerReport = new EmployerReport
                            {
                                TitlePage = await GetGroupReportAsync<TitlePage>(dbConnection, reader),
                                FinancialSummary = await GetGroupReportAsync<FinancialSummary>(dbConnection, reader),
                                PhmpEligibility = await GetGroupReportAsync<PhmpEligibility>(dbConnection, reader),
                                ParticipantContacts = await GetGroupReportAsync<ParticipantContacts>(dbConnection, reader),
                                RealTimeTelemed = await GetGroupReportAsync<RealTimeTelemed>(dbConnection, reader),
                                DnaTesting = await GetGroupReportAsync<DnaTesting>(dbConnection, reader),
                                RealTimeChoices = await GetGroupReportAsync<RealTimeChoices>(dbConnection, reader),
                                RealTimeWellness = await GetGroupReportAsync<RealTimeWellness>(dbConnection, reader),
                                RecentScreeningEventSummary = await GetGroupReportAsync<RecentScreeningEventSummary>(dbConnection, reader),
                                ChronicConditions = await GetGroupReportAsync<ChronicConditions>(dbConnection, reader),
                                HealthRiskAssessment = await GetGroupReportAsync<HealthRiskAssessment>(dbConnection, reader),
                                HealthScreenings = await GetGroupReportAsync<HealthScreenings>(dbConnection, reader),
                                IndemnityBenefit = await GetGroupReportAsync<IndemnityBenefit>(dbConnection, reader)
                            };

                            connection.Close();
                            EmployerReportEntity groupEntitiesList = EntityMapper<EmployerReport, EmployerReportEntity>.MapEntity(employerReport);
                            return groupEntitiesList;
                        }
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<T>> GetGroupReportAsync<T>(SettingsDBContext dbConnection, DbDataReader reader) where T : new()
        {
            List<T> totalList = GetResultSet<T>(dbConnection, reader);
            await reader.NextResultAsync();
            return totalList;
        }
        public List<T> GetResultSet<T>(SettingsDBContext db, DbDataReader reader) where T : new() => ((IObjectContextAdapter)db).ObjectContext.Translate<T>(reader).ToList();

    }
}
