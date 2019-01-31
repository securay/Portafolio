using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
        public bool Active { get; set; }
        public Guid IdInsert { get; set; }
        [MaxLength(50)]
        public string IPInsert { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateInsert { get; set; }
        public Guid? IdUpdate { get; set; }
        [MaxLength(50)]
        public string IPUpdate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? DateUpdate { get; set; }
        public Guid? IdDelete { get; set; }
        [MaxLength(50)]
        public string IPDelete { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? DateDelete { get; set; }
    }
}
