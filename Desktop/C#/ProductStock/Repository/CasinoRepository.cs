using DataAccess;
using Entity;
using System;
using System.Linq;

namespace Repository
{
    public class CasinoRepository : BaseRepository<Casino>
    {
        public CasinoRepository(Context Context)
            : base(Context)
        {
        }

        public Casino GetByCasinoCode(String CasinoCode)
        {
            var result = (from c in Context.Casinos
                          where c.Active && c.Code == CasinoCode
                          select c).FirstOrDefault();
            return result;
        }

        public IQueryable<Casino> FindAllCasinoRow(bool active)
        {
            var result = from cs in Context.Casinos
                         where cs.Active == active
                         orderby cs.Name
                         select cs;
            return result;
        }

        public Casino GetByCasinoCryptedCode(string Code)
        {
            var result = from c in Context.Casinos
                         where c.Code.Equals(Code)
                         select c;
            return result.FirstOrDefault();
        }
    }
}
