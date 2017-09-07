using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class AssetModels
    {

        public long Id { get; set; }
        [Display(Name = "Asset Manufacture")]
        public long AssetManufacturersId { get; set; }
        public virtual AssetManufacturers AssetManufacturers { get; set; }
        [Display(Name = "Asset Group")]
        public long AssetGroupsId { get; set; }
        public virtual AssetGroups AssetGroups { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "Short name is required")]
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }
      
    }
}
