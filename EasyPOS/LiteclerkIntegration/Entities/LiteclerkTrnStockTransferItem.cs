﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.LiteclerkIntegration.Entities
{
     class LiteclerkTrnStockTransferItem
    {
        public Int32 Id { get; set; }
        public Int32 STId { get; set; }
        public LiteclerkTrnStockTransfer StockTransfer { get; set; }
        public Int32 ItemId { get; set; }
        public LiteclerkMstArticleItem Item { get; set; }
        public Int32 ItemInventoryId { get; set; }
        public String Particulars { get; set; }
        public Decimal Quantity { get; set; }
        public Int32 UnitId { get; set; }
        public LiteclerkMstUnit Unit { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BaseQuantity { get; set; }
        public Int32 BaseUnitId { get; set; }
        public LiteclerkMstUnit BaseUnit { get; set; }
        public Decimal BaseCost { get; set; }
    }
}
