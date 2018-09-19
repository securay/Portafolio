using Context;
using CustomView;
using Entity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Auth
{
    public class SystemUserRepository : BaseRepository<SystemUser>
    {
        public SystemUserRepository()
            : base(Program.ApplicationContext)
        {
        }

        public SystemUserRepository(ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public SystemUser GetByName(String SystemUserName)
        {
            var result = (from su in ApplicationContext.SystemUsers
                          orderby su.Username
                          where su.Username == SystemUserName
                          select su).FirstOrDefault();
            return result;
        }

        public IQueryable<SystemUser> ValidateUser(String Username, String Password)
        {
            string shaPass = Util.PasswordUtil.encryptPassword(Password);
            var result = from u in ApplicationContext.SystemUsers
                         where u.Username == Username && u.Password == shaPass
                             && u.Active == true
                         select u;
            return result;
        }

        public IQueryable<Entity.Auth.Extra.SystemUserRow> findAllSystemUserRow(bool Active)
        {
            String ParmDefinition = "DECLARE @active BIT;\n";
            ParmDefinition += String.Format("SET @active = {0};\n", Active ? 1 : 0);
            var res = ApplicationContext.Database.SqlQuery<Entity.Auth.Extra.SystemUserRow>(
                        "spu_list_system_users @active",
                        new System.Data.SqlClient.SqlParameter("@active", Active)
                    ).ToList();
            return res.AsQueryable();
        }

        public IQueryable<SystemUser> ListByName(String SystemUserTypeName)
        {
            var result = from su in ApplicationContext.SystemUsers
                         orderby su.Employee.PaternalSurname
                         where (su.Username).Contains(SystemUserTypeName)
                         select su;
            return result;
        }
        

        public IQueryable<Entity.Auth.Extra.SystemUserRow> GetByEmployeeName(String EmployeeName, int Take)
        {
            var result = from su in ApplicationContext.SystemUsers
                         orderby su.Employee.PaternalSurname
                         where (su.Employee.PaternalSurname + " " + su.Employee.MaternalSurname + ", " + su.Employee.PersonName).Contains(EmployeeName)
                         select new Entity.Auth.Extra.SystemUserRow()
                         {
                             Id = su.Id,
                             Username = su.Username,
                             EntityName = su.Employee.PaternalSurname + " " + su.Employee.MaternalSurname + ", " + su.Employee.PersonName,
                             SystemUserType = "",
                             Active = su.Active
                         };
            return result.Take(Take);
        }
    }
}
