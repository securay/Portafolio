using Entity.Auth;
using System;
using System.Linq;

namespace Repository.Auth
{
    public class PositionRepository : BaseRepository<Position>
    {
        public PositionRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public PositionRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<Position> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Positions
                      where (c.Name).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<Position> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Positions
                      where (c.Name).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<Position> findDuplicate(Position Position)
        {
            var res_document = (from c in ApplicationContext.Positions
                               where c.Active && c.Id != Position.Id &&
                               c.Name == Position.Name 
                               select c).ToList();
            var res_document_del = (from c in ApplicationContext.Positions
                                    where !c.Active && c.Id != Position.Id &&
                               c.Name == Position.Name 
                               select c).ToList();
            
            if(res_document.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Position>()
                {
                    DuplicatedItems = res_document,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo nombre"
                };
            }
            else if (res_document_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Position>()
                {
                    DuplicatedItems = res_document_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo nombre"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<Position>(); ;
        }
    }
}
