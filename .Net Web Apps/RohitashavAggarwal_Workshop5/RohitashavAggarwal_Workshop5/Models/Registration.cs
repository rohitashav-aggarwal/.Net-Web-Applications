using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RohitashavAggarwal_Workshop5.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [MaxLength(2)]
        public string Province { get; set; }
        [Required]
        [MaxLength(7)]
        [Display(Name = "Postal Code")]
        [RegularExpression(@"^[A-Z]\d[A-Z] \d[A-Z]\d$", ErrorMessage ="Incorrect format, A1A 1A1")]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Home Phone")]
        [RegularExpression(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", ErrorMessage ="Please write a valid phone number, no special characters allowed")]
        public string HomePhone { get; set; }
        [Required]
        [Display(Name = "Business Phone")]
        public string BusinessPhone { get; set; }
        
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage ="Please write a valid email")]
        [Display(Name = "Email")]
        public string EmailID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}