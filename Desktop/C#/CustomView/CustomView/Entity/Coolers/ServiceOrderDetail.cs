using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Coolers
{
    [Table("Coolers.ServiceOrderDetail")]
    public class ServiceOrderDetail : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Column("ServiceOrderId")]
        public Guid ServiceOrderId { get; set; }
        public virtual ServiceOrder ServiceOrder { get; set; }
        [Column("CoolerId")]
        public Guid CoolerId { get; set; }
        public virtual Cooler Cooler { get; set; }
        public bool Returned { get; set; } 
    }
}
