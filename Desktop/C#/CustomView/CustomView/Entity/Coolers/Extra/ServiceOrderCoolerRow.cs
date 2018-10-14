using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Coolers.Extra
{
    public class ServiceOrderCoolerRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string Customer { get; set; }
        public string ServiceOrder { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
    }
}
