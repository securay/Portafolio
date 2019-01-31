using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    [Table("SystemUsers")]
    public class SystemUser : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public bool MultiSession { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? LastAccess { get; set; }
        public bool UserExpires { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? ExpirationDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? UnLockTime { get; set; }
        public int LoginFailures { get; set; }
    }
}
