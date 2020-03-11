using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Entity
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
        public bool Active { get; set; }
        public Guid IdInsert { get; set; }
        [MaxLength(50)]
        public String IPInsert { get; set; }
        //[Column(TypeName = "DateTime2")]
        public DateTime DateInsert { get; set; }
        public Nullable<Guid> IdUpdate { get; set; }
        [MaxLength(50)]
        public String IPUpdate { get; set; }
        //[Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateUpdate { get; set; }
        public Nullable<Guid> IdDelete { get; set; }
        [MaxLength(50)]
        public String IPDelete { get; set; }
        //[Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateDelete { get; set; }
    }
}
