using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CategoryMaintenanceMVC.Models
{
    public class Category
    {
        [Required]
        [StringLength(10)]
        [Display(Name ="Category ID")]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Short Name")]
        public string ShortName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Long Name")]
        public string LongName { get; set; }
    }
}