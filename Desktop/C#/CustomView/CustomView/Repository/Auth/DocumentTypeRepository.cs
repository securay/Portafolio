using Entity.Auth;
using System;
using System.Linq;

namespace Repository.Auth
{
    public class DocumentTypeRepository : BaseRepository<DocumentType>
    {
        public DocumentTypeRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public DocumentTypeRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<DocumentType> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.DocumentTypes
                      where (c.Name + c.Acronym).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<DocumentType> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.DocumentTypes
                      where (c.Name + c.Acronym).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<DocumentType> findDuplicate(DocumentType DocumentType)
        {
            var res_document = (from c in ApplicationContext.DocumentTypes
                               where c.Active && c.Id != DocumentType.Id &&
                               (c.Name == DocumentType.Name ||
                               c.Acronym == DocumentType.Acronym)
                               select c).ToList();
            var res_document_del = (from c in ApplicationContext.DocumentTypes
                               where !c.Active && c.Id != DocumentType.Id &&
                               (c.Name == DocumentType.Name ||
                               c.Acronym == DocumentType.Acronym)
                               select c).ToList();
            
            if(res_document.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<DocumentType>()
                {
                    DuplicatedItems = res_document,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo nombre o acronimo"
                };
            }
            else if (res_document_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<DocumentType>()
                {
                    DuplicatedItems = res_document_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo nombre o acronimo"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<DocumentType>(); ;
        }
    }
}
