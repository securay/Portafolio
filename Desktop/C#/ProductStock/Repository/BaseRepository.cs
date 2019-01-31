using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Util;

namespace Repository
{
    public class BaseRepository<T> : IDisposable
        where T : BaseEntity<Guid>
    {
        public Context Context;
        private bool _disposed = false;
        public BaseRepository(Context Context)
        {
            this.Context = Context;
        }

        public T FindById(Guid id)
        {
            var result = Context.Set<T>().Where(t => t.Id.Equals(id)).FirstOrDefault();
            return result;
        }

        public T FindById(Context Context, Guid id)
        {
            var result = Context.Set<T>().Where(t => t.Id.Equals(id)).FirstOrDefault();
            return result;
        }

        public T FindSingleBy(String field, Object value)
        {
            return null;
        }

        public T Merge(T t)
        {
            Context.Set<T>().Attach(t);
            Context.SaveChanges();
            return t;
        }

        public Guid GetEntityId(T t)
        {
            return t.Id;
        }

        public IQueryable<T> FindTop(bool Active, int i)
        {
            IQueryable<T> result = Context.Set<T>().Where(t => t.Active == Active).OrderByDescending(t => t.DateInsert).Take(i);
            return result;
        }

        public IQueryable<T> FindAll()
        {
            IQueryable<T> result = Context.Set<T>();
            return result;
        }


        public virtual IQueryable<T> FindAll(bool Active)
        {
            IQueryable<T> result = Context.Set<T>().Where(t => t.Active == Active);
            return result;
        }

        public virtual List<T> FindDuplicate(T t)
        {
            return new List<T>();
        }

        public IQueryable<T> FindAll(Context Context, bool Active)
        {
            IQueryable<T> result = Context.Set<T>().Where(t => t.Active == Active);
            return result;
        }

        public List<T> FindAll(bool Active, int page, int size)
        {
            List<T> result = Context.Set<T>().Where(t => t.Active == Active).Skip(page * size).Take(size).ToList();
            return result;
        }

        public List<T> Save(ICollection<T> itrbl)
        {
            DbSet<T> DbSet = Context.Set<T>();
            List<T> result = new List<T>();
            foreach (T item in itrbl)
            {
                result.Add(SaveAndFlush(item));
            }
            return result;
        }

        public void Flush()
        {
            Context.SaveChanges();
        }

        public T SaveAndFlush(T t)
        {
            t = Save(t);
            Context.SaveChanges();
            return t;
        }

        public void Update(T t)
        {
            if (FindDuplicate(t).Count == 0)
            {
                try
                {
                    if (CurrentValues.User != null)
                        t.IdUpdate = CurrentValues.User.Id;
                }
                catch (NullReferenceException ex)
                {
                    Logger.Error("Error en actualización", ex);
                }

                t.DateUpdate = Context.GetCurrentTime();
                t.IPUpdate = NetworkUtil.LocalIPAddress();
                Context.SaveChanges();
            }
            else
            {
                throw new DuplicateEntityException(0);
            }
        }

        public void SoftDelete(BaseEntity<Guid> entity)
        {
            if (CurrentValues.User != null)
                entity.IdDelete = CurrentValues.User.Id;

            entity.DateDelete = Context.GetCurrentTime();
            entity.Active = false;
            entity.IPDelete = NetworkUtil.LocalIPAddress();
            Context.SaveChanges();
        }

        public void Reactivate(BaseEntity<Guid> entity)
        {
            if (CurrentValues.User != null)
                entity.IdUpdate = CurrentValues.User.Id;

            entity.DateUpdate = Context.GetCurrentTime();
            entity.Active = true;
            entity.IPUpdate = NetworkUtil.LocalIPAddress();
            Context.SaveChanges();
        }

        public T Save(T t)
        {
            if (FindDuplicate(t).Count == 0)
            {
                try
                {
                    if (CurrentValues.User != null)
                        t.IdInsert = CurrentValues.User.Id;
                }
                catch (NullReferenceException ex)
                {
                    Logger.Error("Error al guardar", ex);
                }
                t.Active = true;
                t.DateInsert = Context.GetCurrentTime();
                t.IPInsert = NetworkUtil.LocalIPAddress();
                Context.Set<T>().Add(t);
                return t;
            }
            else
            {
                throw new DuplicateEntityException(0);
            }
        }

        public void DeleteInBatch(ICollection<T> itrbl)
        {
            DbSet<T> DbSet = Context.Set<T>();
            foreach (T item in itrbl)
            {
                DbSet.Remove(item);
            }
        }

        public void DeleteAllInBatch()
        {
            DbSet<T> DbSet = Context.Set<T>();
            DbSet.RemoveRange(FindAll());
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
                    Context = null;
                    _disposed = true;
                }
            }
        }
    }
}
