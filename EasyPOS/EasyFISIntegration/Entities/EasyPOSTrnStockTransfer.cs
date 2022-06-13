﻿using System;
using System.Collections.Generic;

namespace EasyPOS.EasyFISIntegration.Entities
{
    public class EasyPOSTrnStockTransfer
    {
        public String BranchCode { get; set; }
        public String Branch { get; set; }
        public String STNumber { get; set; }
        public String STDate { get; set; }
        public String ToBranch { get; set; }
        public String ToBranchCode { get; set; }
        public List<EasyPOSTrnStockTransferItem> ListPOSIntegrationTrnStockTransferItem { get; set; }
    }
}
