using Entity.Auth;
using System;
using System.Linq;

namespace Repository.Auth
{
    public class DependencyRepository : BaseRepository<Dependency>
    {
        public DependencyRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public DependencyRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<Dependency> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Dependencies
                      where (c.Name + c.Acronym).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<Dependency> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Dependencies
                      where (c.Name + c.Acronym).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<Dependency> findDuplicate(Dependency Dependency)
        {
            var res_document = (from c in ApplicationContext.Dependencies
                               where c.Active && c.Id != Dependency.Id &&
                               (c.Name == Dependency.Name ||
                               c.Acronym == Dependency.Acronym)
                               select c).ToList();
            var res_document_del = (from c in ApplicationContext.Dependencies
                                    where !c.Active && c.Id != Dependency.Id &&
                               (c.Name == Dependency.Name ||
                               c.Acronym == Dependency.Acronym)
                               select c).ToList();
            
            if(res_document.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Dependency>()
                {
                    DuplicatedItems = res_document,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo nombre o acronimo"
                };
            }
            else if (res_document_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Dependency>()
                {
                    DuplicatedItems = res_document_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo nombre o acronimo"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<Dependency>(); ;
        }
    }
}
