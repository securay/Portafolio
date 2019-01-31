using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("Component")]
    public class Component : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Column("StoredProductId")]
        public Guid StoredProductId { get; set; }
        public virtual StoredProduct StoredProduct { get; set; }
        [Column("ProductId")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        [MaxLength(50)]
        public string SerialNumber { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Buyed { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Stock { get; set; }
    }
}
