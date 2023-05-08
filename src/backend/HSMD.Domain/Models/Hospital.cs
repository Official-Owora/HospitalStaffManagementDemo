using HSMD.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Hospital : AuditableBaseEntity
    {
        [ForeignKey(nameof(HospitalAddress))]
        public int HospitalId { get; set; }
        public string? HospitalName { get; set; }
        public string? HospitalMD { get; set; }

        public HospitalAddress? HospitalAddress { get; set; }
    }
}
