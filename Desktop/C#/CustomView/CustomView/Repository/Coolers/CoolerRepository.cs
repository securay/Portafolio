using Entity.Coolers;
using Entity.Coolers.Extra;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Repository.Coolers
{
    public class CoolerRepository : BaseRepository<Cooler>
    {
        public CoolerRepository()
            : base(CustomView.Program.ApplicationContext)
        {
        }

        public CoolerRepository(Context.ApplicationContext ApplicationContext)
            : base(ApplicationContext)
        {
        }

        public IQueryable<CoolerRow> FindAllRow(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Coolers
                      where (c.Barcode + c.Code + c.Capacity).Contains(Query) &&
                            c.Active == Active
                      orderby c.Code
                      select new CoolerRow()
                      {
                          Id = c.Id,
                          Active = c.Active,
                          Barcode = c.Barcode,
                          Capacity = c.Capacity,
                          Code = c.Code,
                          Color = c.Color,
                          MeasureUnit = c.MeasureUnit.Acronym
                      };
            if(Take > 0)
                return res.Take(Take);
            return res;
        }

        public override IQueryable<Cooler> FindForComboBox(String Query, bool Active, int Take)
        {
            var res = from c in ApplicationContext.Coolers
                      where (c.Barcode + c.Code + c.Capacity).Contains(Query) &&
                            c.Active == Active
                      orderby c.Code
                      select c;
            if (Take > 0)
                return res.Take(Take);
            return res;
        }

        public int CoolerCountToday()
        {
            DateTime Now = ApplicationContext.GetCurrentTime();
            var res = from c in ApplicationContext.Coolers
                      where c.DateInsert.Year == Now.Year &&
                      c.DateInsert.Month == Now.Month &&
                      c.DateInsert.Day == Now.Day
                      select c;
            return res.Count();
        }

        public override Entity.Exceptions.DuplicatedExceptionResult<Cooler> findDuplicate(Cooler Cooler)
        {
            var res_code = (from c in ApplicationContext.Coolers
                      where c.Active && c.Id != Cooler.Id &&
                      c.Code == Cooler.Code 
                      select c).ToList();
            var res_code_del = (from c in ApplicationContext.Coolers
                                where !c.Active && c.Id != Cooler.Id &&
                                c.Code == Cooler.Code
                                select c).ToList();

            var res_barcode = (from c in ApplicationContext.Coolers
                               where c.Active && c.Id != Cooler.Id &&
                               c.Barcode == Cooler.Barcode
                               select c).ToList();
            var res_barcode_del = (from c in ApplicationContext.Coolers
                               where !c.Active && c.Id != Cooler.Id &&
                               c.Barcode == Cooler.Barcode
                               select c).ToList();

            if (res_code.Count > 0 && res_barcode.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo código de cooler y código de barras"
                };
            }
            else if(res_code.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo código"
                };
            }
            else if(res_barcode.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.Duplicated,
                    Message = "Ya existe un registro con el mismo código de barras"
                };
            }
            else if (res_code_del.Count > 0 && res_barcode_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo código de cooler y código de barras"
                };
            }
            else if (res_code_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo código"
                };
            }
            else if (res_barcode_del.Count > 0)
            {
                return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>()
                {
                    DuplicatedItems = res_code,
                    Reason = Entity.Exceptions.Reason.DuplicatedAndDeleted,
                    Message = "Ya existe un registro inactivo con el mismo código de barras"
                };
            }
            return new Entity.Exceptions.DuplicatedExceptionResult<Cooler>(); ;
        }
    }
}
