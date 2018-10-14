using System;

namespace Entity.Coolers.Extra
{
    public class ServiceOrderDetailRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public bool Returned { get; set; }
    }
}
