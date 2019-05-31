using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        public int CatehoryId { get; set; }
        public int BrandId { get; set; }

        [Display(Name = "نام مدل")]
        public string ModelName { get; set; }

        [Display(Name = "توصیحات")]
        public string Description { get; set; }

        [ForeignKey(nameof(CatehoryId))]
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(BrandId))]
        public virtual Company Brand { get; set; }
    }
}