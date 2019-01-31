using System;

namespace Entity.Extra
{
    public class StoreRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string StoreName { get; set; }
        public string Casino { get; set; }
    }
}
