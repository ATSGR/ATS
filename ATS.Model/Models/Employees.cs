using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class Employees
    {
        public long Id { get; set; }
        [Display(Name = "Organization")]
        public long OrganizationsId { get; set; }
        public virtual Organizations Organizations { get; set; }
        [Display(Name = "Branch")]
        public long BranchsId { get; set; }
        public virtual Branchs Branchs { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Display(Name = "Contact No")] 
        [Index(IsUnique = true)]
        [Required(ErrorMessage = "Contact number is required")]
        public string ContactNo { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Department")]
        public string Department { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }
        public byte[] Picture { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }             
    }
}
