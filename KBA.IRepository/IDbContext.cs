using System;
using System.Data.Entity;

namespace IRepository
{
    public interface IDbContext : IDisposable
    {
        IDbSet<TEntity> SetEntity<TEntity>() where TEntity : class;
        int CommitChanges();
    }
}
