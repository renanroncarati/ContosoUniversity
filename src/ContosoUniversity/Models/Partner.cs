using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Partner
    {
        [Display(Name = "Number")]
        public int PartnerID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}