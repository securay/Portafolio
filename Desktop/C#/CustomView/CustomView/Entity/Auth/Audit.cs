using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    [Table("Auth.Audits")]
    public class Audit : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [MaxLength(100)]
        public String Command { get; set; }
        [MaxLength(150)]
        public String CommandDescription { get; set; }
        [Column("SystemUserId")]
        public Guid SystemUserId { get; set; }
        public virtual SystemUser SystemUser { get; set; }
        [Column("FormEntityId")]
        public Guid FormEntityId { get; set; }
        public virtual FormEntity FormEntity { get; set; }
    }
}
