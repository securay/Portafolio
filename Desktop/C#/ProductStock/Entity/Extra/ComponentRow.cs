using System;

namespace Entity.Extra
{
    public class ComponentRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string SerialNumber { get; set; }
        public decimal Buyed { get; set; }
        public decimal Stock { get; set; }
        public string Price { get; set; }
    }
}
