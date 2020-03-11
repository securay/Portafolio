using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Coolers
{
    //[Table("Coolers.Coolers")]
    [Table("Coolers")]
    public class Cooler : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public String Barcode { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public String Code { get; set; }
        public int Color { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Capacity { get; set; }
        [Column("MeasureUnitId")]
        public Guid MeasureUnitId { get; set; }
        public virtual MeasureUnit MeasureUnit { get; set; }
    }
}
