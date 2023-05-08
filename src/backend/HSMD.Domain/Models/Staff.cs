using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Staff : AuditableBaseEntity
    {
        public int Staff_AddressId { get; set; }
        public string? FirstName { get; set;}
        public string? LastName { get; set;}
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public DateTime Date_Joined_Hospital { get; set; }
        public DateTime Date_Left_Hospital { get; set; }
        public string? DepartmentName { get; set; }
        public string? Staff_Position { get; set;}
        public StaffAddress? StaffAddress { get; set; }
    }
}
