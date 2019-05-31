using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "کشور سازنده")]
        public string Name { get; set; }

        public virtual ICollection<Company> Companys { get; set; }
    }
}