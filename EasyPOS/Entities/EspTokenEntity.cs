﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class EspTokenEntity
    {
        public String access_token { get; set; }
        public String expires_in { get; set; }
        public String token_type { get; set; }
        public String username { get; set; }
    }
}
