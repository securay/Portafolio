using Context;
using Entity.Auth;
using System;
using System.Linq;

namespace Repository.Auth
{
    public class SystemMenuRepository : BaseRepository<SystemMenu>
    {
        public SystemMenuRepository()
            : base(CustomView.Program.ApplicationContext)
        {

        }

        public SystemMenuRepository(ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {

        }

        public override IQueryable<SystemMenu> findAll(bool Active)
        {
            var result = from su in ApplicationContext.SystemMenus
                         where su.Active == Active 
                         select su;
            return result;
        }

        public SystemMenu GetByName(String EntityName)
        {
            var res = (from sm in ApplicationContext.SystemMenus
                      where sm.Name == EntityName
                      select sm).FirstOrDefault();
            return res;
        }
    }
}