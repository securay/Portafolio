using System;

namespace Entity.Coolers.Extra
{
    public class CoolerRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public String Code { get; set; }
        public String Barcode { get; set; }
        public int Color { get; set; }
        public decimal Capacity { get; set; }
        public String MeasureUnit { get; set; }
    }
}
