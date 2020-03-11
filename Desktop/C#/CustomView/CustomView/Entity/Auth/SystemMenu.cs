using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    //[Table("Auth.SystemMenus")]
    [Table("SystemMenus")]
    public class SystemMenu : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String Caption { get; set; }
    }
}
