using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام فارسی")]
        public string PersianName { get; set; }
        [Display(Name = "نام لاتین")]
        public string EnglishName { get; set; }
        public int CountryId { get; set; }


        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}