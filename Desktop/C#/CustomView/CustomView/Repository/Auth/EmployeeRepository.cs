using Entity.Auth;
using Entity.Auth.Extra;
using System;
using System.Linq;

namespace Repository.Auth
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public EmployeeRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<EmployeeRow> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Employees
                      where (c.PaternalSurname + " " + c.MaternalSurname + ", " + c.PersonName).Contains(Query) &&
                            c.Active == Active
                      orderby (c.PaternalSurname + " " + c.MaternalSurname + ", " + c.PersonName)
                      select new EmployeeRow()
                      {
                          Id = c.Id,
                          Active = c.Active,
                          Dependency = c.Dependency.Name,
                          DocumentNumber = c.DocumentNumber,
                          DocumentType = c.DocumentType.Name,
                          EntityName = (c.PaternalSurname + " " + c.MaternalSurname + ", " + c.PersonName),
                          Position = c.Position.Name
                      };
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<Employee> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Employees
                      where (c.PaternalSurname + " " + c.MaternalSurname + ", " + c.PersonName).Contains(Query) &&
                            c.Active == Active
                      orderby (c.PaternalSurname + " " + c.MaternalSurname + ", " + c.PersonName)
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<Employee> findDuplicate(Employee Employee)
        {
            var res_document = (from c in ApplicationContext.Employees
                               where c.Active && c.Id != Employee.Id &&
                               c.DocumentNumber == Employee.DocumentNumber &&
                               c.DocumentTypeId == Employee.DocumentTypeId
                               select c).ToList();
            var res_document_del = (from c in ApplicationContext.Employees
                               where !c.Active && c.Id != Employee.Id &&
                               c.DocumentNumber == Employee.DocumentNumber &&
                               c.DocumentTypeId == Employee.DocumentTypeId
                               select c).ToList();
            
            if(res_document.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Employee>()
                {
                    DuplicatedItems = res_document,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo número y tipo de documento"
                };
            }
            else if (res_document_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Employee>()
                {
                    DuplicatedItems = res_document_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo número y tipo de documento"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<Employee>(); ;
        }
    }
}
