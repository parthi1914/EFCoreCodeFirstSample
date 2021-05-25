using System.Collections.Generic;

namespace EFCoreCodeFirstSample.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(Kiosk kiosk, TEntity entity);
        void Delete(Kiosk kiosk);
    }
}
