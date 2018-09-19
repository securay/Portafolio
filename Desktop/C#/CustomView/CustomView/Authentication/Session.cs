using System;

namespace Authentication
{
    public class Session
    {
        public Entity.Auth.SystemUser User { get; set; }
        public DateTime UserLastAccessDate { get; set; }
    }
}
