using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("StoredProduct")]
    public class StoredProduct : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Column("ProductId")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        [MaxLength(50)]
        public string SerialNumber { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Buyed { get; set; }
        public bool CurrentProduct { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? ExpirationDate { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Stock { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Column("StoreId")]
        public Guid StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
