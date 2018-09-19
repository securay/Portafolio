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
        private String SystemUserType_;
        public String SystemUserType
        {
            get
            {
                return SystemUserType_ == null ? "" : (SystemUserType_.Length > 0 ? SystemUserType_.Substring(0, SystemUserType_.Length - 2) : SystemUserType_);
            }
            set
            {
                SystemUserType_ = value;
            }
        }
    }
}
