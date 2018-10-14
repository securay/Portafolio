using Entity.Coolers;
using System;
using System.Linq;

namespace Repository.Coolers
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public CustomerRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<Customer> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Customers
                      where (c.Name + c.RUC).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<Customer> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Customers
                      where (c.Name + c.RUC).Contains(Query) &&
                            c.Active == Active
                      orderby c.Name
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public int CustomerCountToday()
        {
            DateTime Now = ApplicationContext.GetCurrentTime();
            var res = from c in ApplicationContext.Customers
                      where c.DateInsert.Year == Now.Year &&
                      c.DateInsert.Month == Now.Month &&
                      c.DateInsert.Day == Now.Day
                      select c;
            return res.Count();
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<Customer> findDuplicate(Customer Customer)
        {
            var res_code = (from c in ApplicationContext.Customers
                      where c.Active && c.Id != Customer.Id &&
                      c.RUC == Customer.RUC 
                      select c).ToList();
            var res_code_del = (from c in ApplicationContext.Customers
                                where !c.Active && c.Id != Customer.Id &&
                                c.RUC == Customer.RUC
                                select c).ToList();

            var res_barcode = (from c in ApplicationContext.Customers
                               where c.Active && c.Id != Customer.Id &&
                               c.Name == Customer.Name
                               select c).ToList();
            var res_barcode_del = (from c in ApplicationContext.Customers
                               where !c.Active && c.Id != Customer.Id &&
                               c.Name == Customer.Name
                               select c).ToList();

            if (res_code.Count > 0 && res_barcode.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Customer>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo RUC y nombre"
                };
            }
            else if(res_code.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Customer>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo RUC"
                };
            }
            else if(res_barcode.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Customer>()
                {
                    DuplicatedItems = res_barcode,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo nombre"
                };
            }
            else if (res_code_del.Count > 0 && res_barcode_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Customer>()
                {
                    DuplicatedItems = res_code_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo RUC y nombre"
                };
            }
            else if (res_code_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Customer>()
                {
                    DuplicatedItems = res_code_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo RUC"
                };
            }
            else if (res_barcode_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Customer>()
                {
                    DuplicatedItems = res_barcode_del,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo nombre"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<Customer>(); ;
        }
    }
}
