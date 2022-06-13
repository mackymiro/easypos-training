using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.LiteclerkIntegration.Entities
{
     class LiteclerkTrnStockOut
    {
        public Int32 Id { get; set; }
        public Int32 BranchId { get; set; }
        public LiteclerkMstCompanyBranch Branch { get; set; }
        public Int32 CurrencyId { get; set; }
        public String OTNumber { get; set; }
        public String OTDate { get; set; }
        public String ManualNumber { get; set; }
        public String DocumentReference { get; set; }
        public Int32 AccountId { get; set; }
        public Int32 ArticleId { get; set; }
        public String Remarks { get; set; }
        public Int32 PreparedByUserId { get; set; }
        public Int32 CheckedByUserId { get; set; }
        public Int32 ApprovedByUserId { get; set; }
        public Decimal Amount { get; set; }
        public String Status { get; set; }
        public Boolean IsCancelled { get; set; }
        public Boolean IsPrinted { get; set; }
        public Boolean IsLocked { get; set; }
        public Boolean IsAudited { get; set; }  // newly added
        public String CreatedDateTime { get; set; }
        public String UpdatedDateTime { get; set; }
        public String AuditedDateTime { get; set; } // newly added
        public List<LiteclerkTrnStockOutItem> StockOutItems { get; set; }
    }
}
