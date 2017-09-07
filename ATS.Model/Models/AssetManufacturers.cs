using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class AssetManufacturers
    {
        public long Id { get; set; }
        public long AssetGroupsId { get; set; }
        public virtual AssetGroups AssetGroups { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }




    }
}
