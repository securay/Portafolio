using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Coolers
{
    [Table("Coolers.Customer")]
    public class Customer : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(255)]
        public String Name { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public String RUC { get; set; }
        [MaxLength(200)]
        public String Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
