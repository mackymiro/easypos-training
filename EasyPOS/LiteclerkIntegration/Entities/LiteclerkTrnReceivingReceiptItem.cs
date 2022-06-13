using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.LiteclerkIntegration.Entities
{
     class LiteclerkTrnReceivingReceiptItem
    {
        public Int32 Id { get; set; }
        public Int32 RRId { get; set; }
        public Int32 BranchId { get; set; }
        public Int32 POId { get; set; }
        public Int32 ItemId { get; set; }
        public LiteclerkMstArticleItem Item { get; set; }
        public String Particulars { get; set; }
        public Decimal Quantity { get; set; }
        public Int32 UnitId { get; set; }
        public LiteclerkMstUnit Unit { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
        public Int32 VATId { get; set; }
        public Decimal VATRate { get; set; }
        public Decimal VATAmount { get; set; }
        public Int32 WTAXId { get; set; }
        public Decimal WTAXRate { get; set; }
        public Decimal WTAXAmount { get; set; }
        public Decimal BaseQuantity { get; set; }
        public Int32 BaseUnitId { get; set; }
        public LiteclerkMstUnit BaseUnit { get; set; }
        public Decimal BaseCost { get; set; }
        public Decimal BaseAmount { get; set; }
    }
}
