using Context;
using CustomExceptions;
using CustomView;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Util;

namespace Repository
{
    public class BaseRepository<T> : IDisposable
        where T : Entity.BaseEntity<Guid>
    {
        public ApplicationContext ApplicationContext;
        private bool _disposed = false;
        public BaseRepository(ApplicationContext ApplicationContext)
        {
            this.ApplicationContext = ApplicationContext;
        }

        public T findById(Guid id)
        {
            var result = ApplicationContext.Set<T>().Where(t => t.Id.Equals(id)).FirstOrDefault();
            return result;
        }

        public T findById(ApplicationContext ApplicationContext, Guid id)
        {
            var result = ApplicationContext.Set<T>().Where(t => t.Id.Equals(id)).FirstOrDefault();
            return result;
        }

        public T findSingleBy(String field, Object value)
        {
            return null;
        }

        public T merge(T t)
        {
            ApplicationContext.Set<T>().Attach(t);
            ApplicationContext.SaveChanges();
            return t;
        }

        public Guid getEntityId(T t)
        {
            return t.Id;
        }

        public IQueryable<T> findAll()
        {
            IQueryable<T> result = ApplicationContext.Set<T>();
            return result;
        }


        public virtual IQueryable<T> findAll(bool Active)
        {
            IQueryable<T> result = ApplicationContext.Set<T>().Where(t => t.Active == Active);
            return result;
        }

        public virtual Entity.Exceptions.DuplicatedExceptionResult<T> findDuplicate(T t)
        {
            return new Entity.Exceptions.DuplicatedExceptionResult<T>();
        }

        public virtual IQueryable<T> FindForComboBox(String Query, bool Active, int Take)
        {
            return new List<T>().AsQueryable();
        }

        public IQueryable<T> findAll(ApplicationContext ApplicationContext, bool Active)
        {
            IQueryable<T> result = ApplicationContext.Set<T>().Where(t => t.Active == Active);
            return result;
        }

        public List<T> findAll(bool Active, int page, int size)
        {
            List<T> result = ApplicationContext.Set<T>().Where(t => t.Active == Active).Skip(page * size).Take(size).ToList();
            return result;
        }

        public List<T> save(ICollection<T> itrbl)
        {
            DbSet<T> DbSet = ApplicationContext.Set<T>();
            List<T> result = new List<T>();
            foreach (T item in itrbl)
            {
                result.Add(SaveAndFlush(item));
            }
            return result;
        }

        public void flush()
        {
            ApplicationContext.SaveChanges();
        }

        public T SaveAndFlush(T t)
        {
            save(t);
            ApplicationContext.SaveChanges();
            return t;
        }

        public void Update(T t)
        {
            if (findDuplicate(t).DuplicatedItems.Count == 0)
            {
                try
                {
                    if (Program.Security != null)
                        if (Program.Security.Session != null)
                            if (Program.Security.Session.User != null)
                                t.IdInsert = Program.Security.Session.User.Id;
                }
                catch (NullReferenceException ex)
                {
                    Logger.Log(ex, Logger.ERROR);
                }

                t.DateUpdate = ApplicationContext.GetCurrentTime();
                t.IPUpdate = NetworkUtil.LocalIPAddress();
                ApplicationContext.SaveChanges();
            }
            else
            {
                throw new DuplicatedEntityException(0);
            }
        }

        public void SoftDelete(Entity.BaseEntity<Guid> entity)
        {
            try
            {
                if (Program.Security != null)
                    if (Program.Security.Session != null)
                        if (Program.Security.Session.User != null)
                            entity.IdInsert = Program.Security.Session.User.Id;
            }
            catch (NullReferenceException ex)
            {
                Logger.Log(ex, Logger.ERROR);
            }

            entity.DateDelete = ApplicationContext.GetCurrentTime();
            entity.Active = false;
            entity.IPDelete = NetworkUtil.LocalIPAddress();
            ApplicationContext.SaveChanges();
        }

        public void Reactivate(Entity.BaseEntity<Guid> entity)
        {
            try
            {
                if (Program.Security != null)
                    if (Program.Security.Session != null)
                        if (Program.Security.Session.User != null)
                            entity.IdInsert = Program.Security.Session.User.Id;
            }
            catch (NullReferenceException ex)
            {
                Logger.Log(ex, Logger.ERROR);
            }

            entity.DateUpdate = ApplicationContext.GetCurrentTime();
            entity.Active = true;
            entity.IPUpdate = NetworkUtil.LocalIPAddress();
            ApplicationContext.SaveChanges();
        }

        public T save(T t)
        {
            if (findDuplicate(t).DuplicatedItems.Count == 0)
            {
                try
                {
                    if (Program.Security != null)
                        if (Program.Security.Session != null)
                            if (Program.Security.Session.User != null)
                                t.IdInsert = Program.Security.Session.User.Id;
                }
                catch (NullReferenceException ex)
                {
                    Logger.Log(ex, Logger.ERROR);
                }
                t.Active = true;
                t.DateInsert = ApplicationContext.GetCurrentTime();
                t.IPInsert = NetworkUtil.LocalIPAddress();
                ApplicationContext.Set<T>().Add(t);
                return t;
            }
            else
            {
                throw new DuplicatedEntityException(0);
            }
        }

        public void deleteInBatch(ICollection<T> itrbl)
        {
            DbSet<T> DbSet = ApplicationContext.Set<T>();
            foreach (T item in itrbl)
            {
                DbSet.Remove(item);
            }
        }

        public void deleteAllInBatch()
        {
            DbSet<T> DbSet = ApplicationContext.Set<T>();
            DbSet.RemoveRange(findAll());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    ApplicationContext = null;
                    _disposed = true;
                }
            }
        }
    }
}
