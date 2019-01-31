using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("Casinos")]
    public class Casino : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(5)]
        public string Code { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Code);
        }
    }
}
