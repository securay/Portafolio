using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    [Table("Auth.Employees")]
    public class Employee : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [Index("IX_DocumentNumber", 1, IsUnique = true)]
        [MaxLength(30)]
        public String DocumentNumber { get; set; }
        [Column("DocumentTypeId")]
        [Index("IX_DocumentNumber", 2, IsUnique = true)]
        public Guid DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public String PaternalSurname { get; set; }
        [MaxLength(50)]
        public String MaternalSurname { get; set; }
        [MaxLength(80)]
        public String PersonName { get; set; }
        [MaxLength(200)]
        public String Email { get; set; }
        [MaxLength(200)]
        public String Address { get; set; }
        [MaxLength(150)]
        public String Phone { get; set; }
        [Column("DependencyId")]
        public Guid DependencyId { get; set; }
        public virtual Dependency Dependency { get; set; }
        [Column("PositionId")]
        public Guid PositionId { get; set; }
        public virtual Position Position { get; set; }
        [NotMapped]
        public String FullName { get { return (PaternalSurname.Trim() + " " + MaternalSurname.Trim() + ", " + PersonName).Trim(); } }
        public override string ToString()
        {
            return FullName;
        }
    }
}
