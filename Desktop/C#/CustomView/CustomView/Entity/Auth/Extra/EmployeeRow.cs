using System;

namespace Entity.Auth.Extra
{
    public class EmployeeRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public String EntityName { get; set; }
        public String DocumentNumber { get; set; }
        public String DocumentType { get; set; }
        public String Dependency { get; set; }
        public String Position { get; set; }
    }
}
