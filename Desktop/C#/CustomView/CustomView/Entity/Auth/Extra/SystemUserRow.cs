using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Auth.Extra
{
    public class SystemUserRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public String Username { get; set; }
        public String EntityName { get; set; }
    }
}
