using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Model.Models
{
    class Branchs
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //forign key from organization table..
        public long OrganizationsId { get; set; }

        public virtual Organizations Organizations { get; set; }



    }
}
