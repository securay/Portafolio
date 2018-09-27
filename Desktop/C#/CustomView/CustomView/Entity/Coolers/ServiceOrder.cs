using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Coolers
{
    [Table("Coolers.ServiceOrder")]
    public class ServiceOrder : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public String Code { get; set; }
        [Column("CustomerId")]
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public bool Closed { get; set; }
    }
}
