using System;

namespace Entity.Coolers.Extra
{
    public class ServiceOrderRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public String Code { get; set; }
        public String Customer { get; set; }
        public bool Closed { get; set; }
    }
}
