using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("Store")]
    public class Store : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(255)]
        public string Name { get; set; }
        [Column("CasinoId")]
        public Guid CasinoId { get; set; }
        public virtual Casino Casino { get; set; }
    }
}
