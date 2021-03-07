using System.Collections.Generic;

namespace XLabs.Venue.Api.DataAccess.Interfaces
{
    public interface IRepository<TEntity, TKey>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(TKey key);
    }
}
