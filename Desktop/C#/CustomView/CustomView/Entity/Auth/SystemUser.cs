using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    [Table("Auth.SystemUsers")]
    public class SystemUser : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public String Username { get; set; }
        [MaxLength(50)]
        public String Password { get; set; }
        [Column("EmployeeId")]
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public Boolean Enabled { get; set; }
        public Boolean MultiSession { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? LastAccess { get; set; }
        public Boolean UserExpires { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? ExpirationDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? UnLockTime { get; set; }
        public int LoginFailures { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
