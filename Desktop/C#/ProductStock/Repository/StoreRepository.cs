using DataAccess;
using Entity;
using Entity.Extra;
using System;
using System.Linq;

namespace Repository
{
    public class StoreRepository : BaseRepository<Store>
    {
        public StoreRepository(Context Context)
            : base(Context)
        {
        }

        public IQueryable<Store> GetStores(String Query, int Take)
        {
            var res = from s in Context.Stores
                      where s.Name.Contains(Query) && s.Active
                      orderby s.Name
                      select s;
            return Take == 0 ? res : res.Take(Take);
        }

        public IQueryable<StoreRow> ListStores(String Query, bool Active)
        {
            var res = from s in Context.Stores
                      where s.Name.Contains(Query) && s.Active
                      orderby s.Name
                      select new StoreRow()
                      {
                          Id = s.Id,
                          Active = s.Active,
                          Casino = s.Casino.Name,
                          StoreName = s.Name
                      };
            return res;
        }

        public IQueryable<Store> GetByNameAndCasino(String Name, Guid CasinoId, int Take)
        {
            var res = from s in Context.Stores
                       where s.Active && s.Name.Contains(Name) &&
                            s.CasinoId == CasinoId
                       orderby s.Name
                       select s;
            return Take == 0 ? res : res.Take(Take);
        }
    }
}
