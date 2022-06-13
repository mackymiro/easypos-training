﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class DgvTrnSalesReturnEntity
    {
        public Int32 ColumnReturnItemId { get; set; }
        public String ColumnReturnItemDescription { get; set; }
        public String ColumnReturnUnit { get; set; }
        public String ColumnReturnPrice { get; set; }
        public String ColumnReturnDiscountAmount { get; set; }
        public String ColumnReturnNetPrice { get; set; }
        public String ColumnReturnQuantity { get; set; }
        public String ColumnReturnAmount { get; set; }
        public String ColumnReturnPickItem { get; set; }
        public String ColumnReturnUnpickItem { get; set; }
        public String ColumnReturnReturnQuantity { get; set; }
        public Int32 ColumnReturnTaxId { get; set; }
        public String ColumnReturnTaxRate { get; set; }
        public String ColumnReturnTaxAmount { get; set; }
        //public String ColumnReturnedAmount { get; set; }

    }
}