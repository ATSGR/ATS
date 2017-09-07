using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class Vendors
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "Vendor Name")]
        [Required(ErrorMessage = "Vendor name is required")]
        public string  Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "Short name is required")]
        public string  ShortName { get; set; }
        [Display(Name = "Contact No")]
        [Required(ErrorMessage = "Contact number is required")]
        public string ContactNo { get; set; }
        public string  Address { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }     
    }
}
