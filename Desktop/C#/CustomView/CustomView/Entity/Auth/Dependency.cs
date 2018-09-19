using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    [Table("Auth.Dependencies")]
    public class Dependency : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Column("ParentId")]
        public Guid? ParentId { get; set; }
        public virtual Dependency Parent { get; set; }
        [Column("DependencyLevelId")]
        public Guid DependencyLevelId { get; set; }
        public virtual DependencyLevel DependencyLevel { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }
        [MaxLength(20)]
        public String Acronym { get; set; }
    }
}
