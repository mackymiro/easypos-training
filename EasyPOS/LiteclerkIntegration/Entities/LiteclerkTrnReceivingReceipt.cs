using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.LiteclerkIntegration.Entities
{
     class LiteclerkTrnReceivingReceipt
    {
        public Int32 Id { get; set; }
        public Int32 BranchId { get; set; }
        public LiteclerkMstCompanyBranch Branch { get; set; }
        public Int32 CurrencyId { get; set; }
        public Decimal ExchangeRate { get; set; }
        public String RRNumber { get; set; }
        public String RRDate { get; set; }
        public String ManualNumber { get; set; }
        public String DocumentReference { get; set; }
        public Int32 SupplierId { get; set; }
        public LiteclerkMstArticleSupplier Supplier { get; set; }
        public Int32 TermId { get; set; }
        public LiteclerkMstTerm Term { get; set; }
        public String Remarks { get; set; }
        public Int32 ReceivedByUserId { get; set; }
        public Int32 PreparedByUserId { get; set; }
        public Int32 CheckedByUserId { get; set; }
        public Int32 ApprovedByUserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal PaidAmount { get; set; }
        public Decimal AdjustmentAmount { get; set; }
        public Decimal BalanceAmount { get; set; }
        public String Status { get; set; }
        public Boolean IsCancelled { get; set; }
        public Boolean IsPrinted { get; set; }
        public Boolean IsLocked { get; set; }
        public Boolean IsAudited { get; set; }  // newly added
        public String CreatedDateTime { get; set; }
        public String UpdatedDateTime { get; set; }
        public String AuditedDateTime { get; set; } // newly added

        public List<LiteclerkTrnReceivingReceiptItem> ReceivingReceiptItems { get; set; }
    }
}
