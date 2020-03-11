using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    //[Table("Auth.SystemUserMenuPermissions")]
    [Table("SystemUserMenuPermissions")]
    public class SystemUserMenuPermission : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Column("SystemUserId")]
        public Guid SystemUserId { get; set; }
        public virtual SystemUser SystemUser { get; set; }
        [Column("SystemMenuId")]
        public Guid SystemMenuId { get; set; }
        public virtual SystemMenu SystemMenu { get; set; }
        public bool Allow { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool List { get; set; }
        public bool Export { get; set; }
        public bool Extras { get; set; }
        public bool Activate { get; set; }
        public override string ToString()
        {
            if (SystemMenu != null)
                return SystemMenu.Caption;
            return "";
        }
    }
}
