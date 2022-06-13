﻿using System;

namespace EasyPOS.EasyFISIntegration.Entities
{
    public class EasyPOSTrnStockOutItem
    {
        public Int32 OTId { get; set; }
        public String ItemCode { get; set; }
        public String Item { get; set; }
        public String Unit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Amount { get; set; }
    }
}
