using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class Branchs
    {
        public long Id { get; set; }
        [Display(Name = "Branch Name")]
        [Required(ErrorMessage = "Branch Name")]
        public string Name { get; set; }
        public string ShortName { get; set; }
        //forign key from organization table..
        [Display(Name = "Organization")]
        public long OrganizationsId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefidBy { get; set; }
        public DateTime ModefiedOn { get; set; }
        public virtual Organizations Organizations { get; set; }
        //collection for asset locations
        public virtual ICollection<AssetLocations> AssetLocationses { get; set; }
        public virtual ICollection<Employees> Employeeses { get; set; }

    }
}
