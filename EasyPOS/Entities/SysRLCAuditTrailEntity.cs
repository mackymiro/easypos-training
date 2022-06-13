using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class SysRLCAuditTrailEntity
    {
        public Int32 Id { get; set; }
        public Int32 UserId { get; set; }
        public String User { get; set; }
        public DateTime AuditDate { get; set; }
        public String ActionInformation { get; set; }
    }
}
