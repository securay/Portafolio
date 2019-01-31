using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("Product")]
    public class Product : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index(IsUnique = true, Order = 0)]
        [MaxLength(250)]
        public string Name { get; set; }
        [Index(IsUnique = true, Order = 1)]
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(20)]
        public string SunatCode { get; set; }
        public bool Perecible { get; set; }
        [Range(0, double.MaxValue)]
        public decimal MinStock { get; set; }
        [Range(0, double.MaxValue)]
        public decimal? NominalValue { get; set; }
        public bool AddOnElectronicDocument { get; set; }
    }
}
