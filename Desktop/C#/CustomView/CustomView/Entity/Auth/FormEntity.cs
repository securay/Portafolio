using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    //[Table("Auth.FormEntities")]
    [Table("FormEntities")]
    public class FormEntity : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
    }
}
