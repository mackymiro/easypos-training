﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepSalesReportSalesReturnDetailReportEntity
    {
        public Int32 Id { get; set; }
        public Int32 SalesId { get; set; }
        public String Terminal { get; set; }
        public String Date { get; set; }
        public String SalesReturnNumber { get; set; }
        public String CustomerCode { get; set; }
        public String Customer { get; set; }
        public Int32 ItemId { get; set; }
        public String ItemDescription { get; set; }
        public String ItemCode { get; set; }
        public String ItemCategory { get; set; }
        public Int32 UnitId { get; set; }
        public String Unit { get; set; }
        public Decimal Price { get; set; }
        public Int32 DiscountId { get; set; }
        public String Discount { get; set; }
        public Decimal DiscountRate { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Decimal NetPrice { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Amount { get; set; }
        public Int32 TaxId { get; set; }
        public String Tax { get; set; }
        public Decimal TaxRate { get; set; }
        public Decimal TaxAmount { get; set; }
        public String SalesLineTimeStamp { get; set; }
        public Int32? UserId { get; set; }
        public String User { get; set; }
    }
}
