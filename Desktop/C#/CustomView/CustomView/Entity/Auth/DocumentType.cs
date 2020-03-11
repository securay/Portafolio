using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    //[Table("Auth.DocumentTypes")]
    [Table("DocumentTypes")]
    public class DocumentType : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }
        [MaxLength(10)]
        public String Acronym { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
