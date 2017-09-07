using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class AssetGroups
    {
        public long Id { get; set; }
        [Display(Name = "Asset Type")]
        public long AssetTypesId { get; set; }//FK from asset type table
        [Required(ErrorMessage = "Group name is required")]
        public string Name { get; set; }
        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "Short Name is required")]
        public string ShortName { get; set; }
        public string Code { get; set; }
        public virtual AssetTypes AssetTypes { get; set; }
        public virtual ICollection<AssetManufacturers> AssetManufacturerses { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }
    }
}

