using Entity.Coolers;
using Entity.Coolers.Extra;
using System;
using System.Linq;

namespace Repository.Coolers
{
    public class ServiceOrderDetailRepository : BaseRepository<ServiceOrderDetail>
    {
        public ServiceOrderDetailRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public ServiceOrderDetailRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<ServiceOrderDetail> FindAllRow(ServiceOrder ServiceOrder, bool Active, int Take)
        {
            var res = from c in ApplicationContext.ServiceOrderDetails
                      where c.ServiceOrderId == ServiceOrder.Id &&
                            c.Active == Active
                      orderby c.Cooler.Code
                      select c;
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public IQueryable<ServiceOrderCoolerRow> FindAllRow(string Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.ServiceOrderDetails
                      where (c.ServiceOrder.Code + 
                                c.Cooler.Code + 
                                c.Cooler.Barcode + 
                                c.ServiceOrder.Customer.Name).Contains(Query) &&
                            c.Active == Active &&
                            !c.Returned
                      orderby c.Cooler.Code
                      select new ServiceOrderCoolerRow()
                      {
                          Id = c.Id,
                          Active = c.Active,
                          Barcode = c.Cooler.Barcode,
                          Code = c.Cooler.Code,
                          ServiceOrder = c.ServiceOrder.Code,
                          Customer = c.ServiceOrder.Customer.Name
                      };
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public int ServiceOrderDetailCountToday()
        {
            DateTime Now = ApplicationContext.GetCurrentTime();
            var res = from c in ApplicationContext.ServiceOrderDetails
                      where c.DateInsert.Year == Now.Year &&
                      c.DateInsert.Month == Now.Month &&
                      c.DateInsert.Day == Now.Day
                      select c;
            return res.Count();
        }

        public bool IsUsed(Cooler cooler)
        {
            var res = from c in ApplicationContext.ServiceOrderDetails
                      where c.Active &&
                      !c.ServiceOrder.Closed &&
                      !c.Returned &&
                      c.CoolerId == cooler.Id
                      select c;
            return res.Count() > 0;
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<ServiceOrderDetail> findDuplicate(ServiceOrderDetail ServiceOrderDetail)
        {
            var res_barcode = (from c in ApplicationContext.ServiceOrderDetails
                               where c.Active && c.Id != ServiceOrderDetail.Id &&
                               c.CoolerId == ServiceOrderDetail.CoolerId &&
                               c.ServiceOrderId == ServiceOrderDetail.ServiceOrderId
                               select c).ToList();
            var res_barcode_del = (from c in ApplicationContext.ServiceOrderDetails
                               where !c.Active && c.Id != ServiceOrderDetail.Id &&
                               c.CoolerId == ServiceOrderDetail.CoolerId &&
                               c.ServiceOrderId == ServiceOrderDetail.ServiceOrderId
                               select c).ToList();
            
            if(res_barcode.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<ServiceOrderDetail>()
                {
                    DuplicatedItems = res_barcode,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo cooler"
                };
            }
            else if (res_barcode_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<ServiceOrderDetail>()
                {
                    DuplicatedItems = res_barcode,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo cooler"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<ServiceOrderDetail>(); ;
        }
    }
}
