﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class MstSupplierEntity
    {
        public Int32 Id { get; set; }
        public String Supplier { get; set; }
        public String Address { get; set; }
        public String TelephoneNumber { get; set; }
        public String CellphoneNumber { get; set; }
        public String FaxNumber { get; set; }
        public Int32 TermId { get; set; }
        public String Term { get; set; }
        public String TIN { get; set; }
        public Int32 AccountId { get; set; }
        public String Account { get; set; }
        public Int32 EntryUserId { get; set; }
        public String EntryUserName { get; set; }
        public String EntryDateTime { get; set; }
        public Int32 UpdateUserId { get; set; }
        public String UpdatedUserName { get; set; }
        public String UpdateDateTime { get; set; }
        public Boolean IsLocked { get; set; }
    }
}