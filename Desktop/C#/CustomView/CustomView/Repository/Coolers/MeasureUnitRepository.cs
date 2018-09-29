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

        public override IQueryable<MeasureUnit> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from l in ApplicationContext.MeasureUnits
                      where (l.Name + l.Acronym).Contains(Query) &&
                            l.Active == Active
                      select l;
            if(Take > 0)
                return res.Take(Take);
            return res;
        }
    }
}
