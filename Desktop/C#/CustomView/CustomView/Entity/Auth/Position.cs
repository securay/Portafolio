﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Auth
{
    //[Table("Auth.Positions")]
    [Table("Positions")]
    public class Position : BaseEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
