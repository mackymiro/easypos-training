using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DGVSysRLCAuditTrailListEntity
    {
        public Int32 ColumnRLCAuditTrailListId { get; set; }
        public Int32 ColumnRLCAuditTrailListUserId { get; set; }
        public String ColumnRLCAuditTrailListUser { get; set; }
        public String ColumnRLCAuditTrailListAuditDate { get; set; }
        public String ColumnRLCAuditTrailListActionInformation { get; set; }
    }
}
