using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام گروه")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}