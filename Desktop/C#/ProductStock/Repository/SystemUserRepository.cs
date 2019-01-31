using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Util;

namespace Repository
{
    public class SystemUserRepository : BaseRepository<SystemUser>
    {
        public SystemUserRepository(Context Context)
            : base(Context)
        {
        }

        public SystemUser GetByName(string SystemUserName)
        {
            var result = (from su in Context.SystemUsers
                          orderby su.Username
                          where su.Username == SystemUserName
                          select su).FirstOrDefault();
            return result;
        }

        public IQueryable<SystemUser> ValidateUser(string Username, string Password)
        {
            string shaPass = PasswordUtil.encryptPassword(Password);
            var result = from u in Context.SystemUsers
                         where u.Username == Username && u.Password == shaPass
                             && u.Active == true
                         select u;
            return result;
        }
        /*
        public IQueryable<SystemUserRow> findAllSystemUserRow(bool Active)
        {
            string ParmDefinition = "DECLARE @active BIT;\n";
            ParmDefinition += string.Format("SET @active = {0};\n", Active ? 1 : 0);
            var res = Context.Database.SqlQuery<SystemUserRow>(
                        "spu_report @query, @ParmDefinition",
                        new SqlParameter("@query", 4),
                        new SqlParameter("@ParmDefinition", ParmDefinition)
                    ).ToList();
            return res.AsQueryable();
        }*/

        public IQueryable<SystemUser> ListByName(string Name)
        {
            var result = from su in Context.SystemUsers
                         orderby su.Username
                         where (su.Username).Contains(Name)
                         select su;
            return result;
        }
    }
}
