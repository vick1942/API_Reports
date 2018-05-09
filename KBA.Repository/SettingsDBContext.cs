using System.Data.Entity;

namespace Repository
{
    public class SettingsDBContext : DbContext
    {
        #region Contructor
        public SettingsDBContext(string connectionString) : base(connectionString)
        {
        }
        #endregion

        #region Public Methods
        public IDbSet<TEntity> SetEntity<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public int CommitChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}
