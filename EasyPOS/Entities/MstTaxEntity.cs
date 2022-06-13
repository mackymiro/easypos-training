using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class MstTaxEntity
    {
        public Int32 Id { get; set; }
        public String Code { get; set; }
        public String Tax { get; set; }
        public Decimal Rate { get; set; }
        public Int32 AccountId { get; set; }
        public String Account { get; set; }
    }
}