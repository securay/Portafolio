using Entity.Coolers;
using Entity.Coolers.Extra;
using System;
using System.Linq;

namespace Repository.Coolers
{
    public class ServiceOrderRepository : BaseRepository<ServiceOrder>
    {
        public ServiceOrderRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public ServiceOrderRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<ServiceOrderRow> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.ServiceOrders
                      where (c.Code + c.Customer.RUC + c.Customer.Name).Contains(Query) &&
                            c.Active == Active
                      orderby c.Code
                      select new ServiceOrderRow()
                      {
                          Id = c.Id,
                          Active = c.Active,
                          Closed = c.Closed,
                          Code = c.Code,
                          Customer = c.Customer.Name
                      };
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<ServiceOrder> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.ServiceOrders
                      where (c.Code + c.Customer.RUC).Contains(Query) &&
                            c.Active == Active
                      orderby c.Code
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public int ServiceOrderCountToday()
        {
            DateTime Now = ApplicationContext.GetCurrentTime();
            var res = from c in ApplicationContext.ServiceOrders
                      where c.DateInsert.Year == Now.Year &&
                      c.DateInsert.Month == Now.Month &&
                      c.DateInsert.Day == Now.Day
                      select c;
            return res.Count();
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<ServiceOrder> findDuplicate(ServiceOrder ServiceOrder)
        {
            var res_barcode = (from c in ApplicationContext.ServiceOrders
                               where c.Active && c.Id != ServiceOrder.Id &&
                               c.Code == ServiceOrder.Code
                               select c).ToList();
            var res_barcode_del = (from c in ApplicationContext.ServiceOrders
                               where !c.Active && c.Id != ServiceOrder.Id &&
                               c.Code == ServiceOrder.Code
                               select c).ToList();
            
            if(res_barcode.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<ServiceOrder>()
                {
                    DuplicatedItems = res_barcode,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo código"
                };
            }
            else if (res_barcode_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<ServiceOrder>()
                {
                    DuplicatedItems = res_barcode,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo código"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<ServiceOrder>(); ;
        }
    }
}
