using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Coolers
{
    [Table("Coolers.MeasureUnits")]
    public class MeasureUnit : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public String Name { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(10)]
        public String Acronym { get; set; }
    }
}
