using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATS.Model.Models
{
    class Organizations
    {

        public long Id { get; set; }
        [Display(Name = "Organization Name")]
        [Required(ErrorMessage = "Organization name is required.")]
        public string Name { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }
        //here is icollection for brances..
        public virtual ICollection<Branchs> Branchses { get; set; }



    }
}
