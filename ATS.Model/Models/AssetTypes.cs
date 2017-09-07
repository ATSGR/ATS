using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class AssetTypes
    {
        public long Id { get; set; }
        [Display(Name = "Asset Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Short Name")]
        [Required(ErrorMessage = "Short name is required")]
        public string ShortName { get; set; }
        [Display(Name = "Code")]
        public string Code { get; set; }
        public virtual ICollection<AssetGroups> AssetGroupses { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModefiedBy { get; set; }
        public DateTime ModefiedOn { get; set; }
    }
}
