using System.Collections.Generic;
using System.Linq;
using EFCoreCodeFirstSample.Models.Repository;

namespace EFCoreCodeFirstSample.Models.DataManager
{
    public class KioskManager : IDataRepository<Kiosk>
    {
        readonly KioskContext _kioskContext;

        public KioskManager(KioskContext context)
        {
            _kioskContext = context;
        }

        public IEnumerable<Kiosk> GetAll()
        {
            return _kioskContext.Kiosks.ToList();
        }

        public Kiosk Get(long id)
        {
            return _kioskContext.Kiosks.FirstOrDefault(e => e.KioskId == id);
        }

        public void Add(Kiosk entity)
        {
            _kioskContext.Kiosks.Add(entity);
            _kioskContext.SaveChanges();
        }

        public void Update(Kiosk kiosk, Kiosk entity)
        {
            kiosk.KioskName = entity.KioskName;
            kiosk.LocationId = entity.LocationId;
            kiosk.UpdatedBy = entity.UpdatedBy;
            kiosk.UpdatedOn = entity.UpdatedOn;
           
            _kioskContext.SaveChanges();
        }

        public void Delete(Kiosk kiosk)
        {
            _kioskContext.Kiosks.Remove(kiosk);
            _kioskContext.SaveChanges();
        }
    }
}
