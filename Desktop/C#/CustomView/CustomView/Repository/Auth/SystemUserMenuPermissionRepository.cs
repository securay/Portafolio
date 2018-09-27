using Context;
using Entity.Auth;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Repository.Auth
{
    public class SystemUserMenuPermissionRepository : BaseRepository<SystemUserMenuPermission>
    {
        public SystemUserMenuPermissionRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public SystemUserMenuPermissionRepository(ApplicationContext ApplicationContext) 
            : base (ApplicationContext)
        {
        }

        public SystemUserMenuPermission GetByUserAndMenu(SystemUser User, SystemMenu SystemMenu)
        {
            var result = (from ca in ApplicationContext.SystemUserMenuPermissions
                          where ca.SystemMenu.Id == SystemMenu.Id &&
                            ca.SystemUser.Id == User.Id 
                          select ca).FirstOrDefault();
            return result;
        }

        public IQueryable<SystemUserMenuPermission> ListByUser(SystemUser SystemUser)
        {
            using (SystemMenuRepository SystemMenuRepository = new SystemMenuRepository())
            {
                List<SystemMenu> SystemMenus = SystemMenuRepository.findAll(true).ToList();
                foreach (SystemMenu SystemMenu in SystemMenus)
                {
                    if (GetByUserAndMenu(SystemUser, SystemMenu) == null)
                    {
                        SystemUserMenuPermission SystemUserMenuPermission = new SystemUserMenuPermission()
                        {
                            SystemMenu = SystemMenu,
                            SystemUser = SystemUser,
                            Allow = false
                        };
                        SaveAndFlush(SystemUserMenuPermission);
                    }
                }
                var result = from su in ApplicationContext.SystemUserMenuPermissions
                             orderby su.SystemMenu.Caption
                             where su.SystemUser.Id == SystemUser.Id
                             select su;
                return result;
            }
        }
    }
}
