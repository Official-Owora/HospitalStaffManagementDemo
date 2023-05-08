using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class StaffAddress : AuditableBaseEntity
    {
        public int BuildingNumber { get; set; }
        public string? streetName { get; set; }
        public string? Area_locality { get; set; }
        public string? LandMark { get; set; }
        public string? City { get; set; }
        public string? Zip_PostalCode { get; set; }
        public string? State_Province { get; set; }
        public ICollection <Staff>? Staff { get; set; }
    }
}
