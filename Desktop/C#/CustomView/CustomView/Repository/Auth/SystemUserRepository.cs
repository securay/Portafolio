using Context;
using CustomView;
using Entity.Auth;
using Entity.Auth.Extra;
using System;
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

        public IQueryable<SystemUserRow> findAllSystemUserRow(string Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.SystemUsers
                      where (c.Username + c.Employee.PaternalSurname + " " + c.Employee.MaternalSurname + " " + c.Employee.PersonName).Contains(Query) &&
                            c.Active == Active
                      orderby (c.Employee.PaternalSurname + " " + c.Employee.MaternalSurname + " " + c.Employee.PersonName)
                      select new SystemUserRow()
                      {
                          Active = c.Active,
                          Id = c.Id,
                          EntityName = c.Employee.PaternalSurname + " " + c.Employee.MaternalSurname + " " + c.Employee.PersonName,
                          Username = c.Username
                      };
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public IQueryable<SystemUser> ListByName(String Username, bool Active, int Take)
        {
            var result = from su in ApplicationContext.SystemUsers
                         orderby su.Employee.PaternalSurname
                         where su.Active == Active &&
                            (su.Username).Contains(Username)
                         select su;
            if (Take > 0)
                return result.Take(Take);
            return result;
        }
        

        public IQueryable<SystemUserRow> GetByEmployeeName(String EmployeeName, int Take)
        {
            var result = from su in ApplicationContext.SystemUsers
                         orderby su.Employee.PaternalSurname
                         where (su.Employee.PaternalSurname + " " + su.Employee.MaternalSurname + ", " + su.Employee.PersonName).Contains(EmployeeName)
                         select new SystemUserRow()
                         {
                             Id = su.Id,
                             Username = su.Username,
                             EntityName = su.Employee.PaternalSurname + " " + su.Employee.MaternalSurname + ", " + su.Employee.PersonName,
                             Active = su.Active
                         };
            return result.Take(Take);
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<SystemUser> findDuplicate(SystemUser SystemUser)
        {
            var res_document = (from c in ApplicationContext.SystemUsers
                                where c.Active && c.Id != SystemUser.Id &&
                                (c.Username == SystemUser.Username ||
                                c.EmployeeId == SystemUser.EmployeeId)
                                select c).ToList();
            var res_document_del = (from c in ApplicationContext.SystemUsers
                                    where !c.Active && c.Id != SystemUser.Id &&
                               (c.Username == SystemUser.Username ||
                               c.EmployeeId == SystemUser.EmployeeId)
                                    select c).ToList();

            if (res_document.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<SystemUser>()
                {
                    DuplicatedItems = res_document,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo nombre de usuario o el empleado ya tiene un usuario asignado"
                };
            }
            else if (res_document_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<SystemUser>()
                {
                    DuplicatedItems = res_document_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo de usuario o el empleado ya tiene un usuario asignado"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<SystemUser>(); ;
        }
    }
}
