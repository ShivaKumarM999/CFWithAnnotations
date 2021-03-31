using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CFWithAnnotations.Models
{
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }

        [Required]
        public string DeptName { get; set; }

        public string Loc { get; set; }
    }
}