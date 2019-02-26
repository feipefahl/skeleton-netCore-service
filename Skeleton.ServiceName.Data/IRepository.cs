﻿using System.Linq;
using System.Threading.Tasks;

namespace Skeleton.ServiceName.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All { get; }
        TEntity Find(long key);
        void Insert(params TEntity[] obj);
        void Update(params TEntity[] obj);
        void Delete(params TEntity[] obj);

        Task<TEntity> FindAsync(long key);
        Task InsertAsync(params TEntity[] obj);
        Task UpdateAsync(params TEntity[] obj);
        Task DeleteAsync(params TEntity[] obj);

    }
}
