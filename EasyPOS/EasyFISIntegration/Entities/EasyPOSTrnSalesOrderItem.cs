﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.EasyFISIntegration.Entities
{
    class EasyPOSTrnSalesOrderItem
    {
        public Int32 SOId { get; set; }
        public String ItemBarcode { get; set; }
        public String Unit { get; set; }
        public String Particulars { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Price { get; set; }
        public String Discount { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Decimal NetPrice { get; set; }
        public Decimal Amount { get; set; }
        public String VAT { get; set; }
        public String SalesItemTimeStamp { get; set; }
    }
}
