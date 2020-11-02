using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeCuBe.Test.WebAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public string JoiningDate { get; set; }
        public string Photo { get; set; }
    }
}