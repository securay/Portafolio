using Context;
using Entity.Auth;
using GUI.CustomControls;
using System;
using System.Data.Entity.Core;
using System.Linq;
using Util;

namespace Authentication
{
    public class Security
    {
        public Session Session { get; set; }
        protected ApplicationContext ApplicationContext;

        public Security()
        {
            ApplicationContext = new ApplicationContext();
        }

        public SystemUser ValidateUser(string login, string pass)
        {
            var query = new Repository.Auth.SystemUserRepository().ValidateUser(login, pass);
            SystemUser user;

            try
            {
                user = query.First();
                return user;
            }
            catch (InvalidOperationException ioe)
            {
                Logger.Log(ioe, Logger.INFO);
                return null;
            }
        }

        public bool RequestLogin(string login, string pass)
        {
            SystemUser user = ValidateUser(login, pass);

            if (user == null)
            {
                return false;
            }
            Session = new Session();
            if (user.LastAccess != null)
                Session.UserLastAccessDate = (DateTime)user.LastAccess;

            user.LastAccess = ApplicationContext.GetCurrentTime();
            ApplicationContext.SaveChanges();

            Session.User = user;

            return true;
        }

        public bool UserExists(string login)
        {
            var query = from u in ApplicationContext.SystemUsers
                        where u.Username == login
                        select u;
            return query.Count() > 0;
        }

        public bool UserIsActive(string login)
        {
            var query = from u in ApplicationContext.SystemUsers
                        where u.Username == login && u.Active == true
                        select u;
            return query.Count() > 0;
        }

        public IQueryable<SystemUser> UserQuery()
        {
            return ApplicationContext.SystemUsers;
        }

        protected void SetUserPassword(string login, string password)
        {
            try
            {
                SystemUser user = (from u in UserQuery()
                                   where u.Username == login
                                   select u).First();
                user.Password = PasswordUtil.encryptPassword(password);
                ApplicationContext.SaveChanges();
            }
            catch (InvalidCastException ioe)
            {
                Logger.Log(ioe, Logger.ERROR);
                throw new UserNotFoundException();
            }
        }

        public void Audit(BaseForm form, string command, string cmdDesc)
        {
            try
            {
                if (Session.User == null) return;
                FormEntity dbForm = GetDbFormOf(form);
                SystemUser SystemUser = GetSystemUser();
                Audit audit = new Audit()
                {
                    FormEntity = dbForm,
                    Command = command,
                    CommandDescription = cmdDesc
                };
                audit.SystemUser = SystemUser;
                audit.DateInsert = ApplicationContext.GetCurrentTime();
                audit.IPInsert = NetworkUtil.LocalIPAddress();
                audit.IdInsert = SystemUser.Id;
                audit.Active = true;
                ApplicationContext.Audits.Add(audit);
                ApplicationContext.SaveChanges();
            }
            catch (EntityException ex)
            {
                Logger.Log(ex.Message, Logger.ERROR);
            }
        }

        public SystemUser GetSystemUser()
        {
            var result = (from su in ApplicationContext.SystemUsers
                          where su.Id == Session.User.Id
                          select su).First();
            return result;
        }
        
        protected FormEntity GetDbFormOf(BaseForm form)
        {
            var q = from f in ApplicationContext.FormEntities
                    where f.Name == form.Name
                    select f;

            try
            {
                FormEntity dbForm = q.First();
                return dbForm;
            }
            catch (InvalidOperationException ioe)
            {
                try
                {
                    Logger.Log(ioe, Logger.INFO);
                    FormEntity dbForm = new FormEntity()
                    {
                        Name = form.Name,
                        Title = form.Text,
                        IdInsert = Session.User.Id,
                        DateInsert = ApplicationContext.GetCurrentTime(),
                        IPInsert = NetworkUtil.LocalIPAddress()
                    };
                    ApplicationContext.FormEntities.Add(dbForm);
                    ApplicationContext.SaveChanges();
                    return dbForm;
                }
                catch (EntityException ex)
                {
                    Logger.Log(ex.Message, Logger.ERROR);
                    return null;
                }
            }
        }
    }

    public class UserAlreadyExistsException : System.Exception { }
    public class UserIsInActiveException : System.Exception { }

    public class UserNotFoundException : System.Exception { }

    public class DeniedAccessException : System.Exception { }
}
