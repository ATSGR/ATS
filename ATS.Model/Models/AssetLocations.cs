using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class AssetLocations
    {
        public long Id { get; set; }
        //forign key form organization model or table
        [Display(Name = "Organization")]
        public long OrganizationsId { get; set; }
        //forign key from branchs model class or table
        [Display(Name = "Branch")]
        public long BranchsId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }
        public virtual Organizations Organizations { get; set; }
        public virtual Branchs Branchs { get; set; }
    }
}
