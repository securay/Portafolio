using Entity.Coolers;
using System;
using System.Linq;

namespace Repository.Coolers
{
    public class MeasureUnitRepository : BaseRepository<MeasureUnit>
    {
        public MeasureUnitRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public MeasureUnitRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<MeasureUnit> FindAll(String Query, bool Active, int Take)
        {
            var res = from l in ApplicationContext.MeasureUnits
                      where (l.Name + l.Acronym).Contains(Query) &&
                            l.Active == Active
                      select l;
            return res.Take(Take);
        }
    }
}
