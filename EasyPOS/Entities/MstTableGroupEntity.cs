﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class MstTableGroupEntity
    {
        public Int32 Id { get; set; }
        public String TableGroup { get; set; }
        public Int32 EntryUserId { get; set; }
        public String EntryUserName { get; set; }
        public String EntryDateTime { get; set; }
        public Int32 UpdateUserId { get; set; }
        public String UpdatedUserName { get; set; }
        public String UpdateDateTime { get; set; }
        public Boolean IsLocked { get; set; }
    }
}
