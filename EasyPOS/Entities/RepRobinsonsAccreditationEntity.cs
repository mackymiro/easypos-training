using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepRobinsonsAccreditationEntity
    {
        public String TenantId { get; set; }
        public String Terminal { get; set; }
        public Decimal TotalGrossSalesAmount { get; set; }
        public Decimal TotalVATAmount { get; set; }
        public Decimal TotalVoidAmount { get; set; }
        public Int32 TotalOfVoidSalesTransaction { get; set; }
        public Decimal TotalDiscountAmount { get; set; }
        public Int32 TotalCountOfRegularDiscount { get; set; }
        public Int32 TotalOfDiscountedSalesTransaction { get; set; }
        public Decimal TotalRefundAmount { get; set; }
        public Int32 TotalOfRefundSalesTransaction { get; set; }
        public Decimal TotalSeniorDiscount { get; set; }
        public Int32 TotalOfSeniorDiscountSalesTransaction { get; set; }
        public Decimal TotalServiceChargeAmount { get; set; }
        public String PreviousEOD { get; set; }
        public Decimal TotalNetSalesAmount {get; set;}
        public Decimal PreviousGrandTotalEOD { get; set; }
        public String CurrentEOD { get; set; }
        public Decimal CurrentGrandTotalEOD { get; set; }
        public DateTime Date { get; set; }
        public Decimal NoveltySales { get; set; }
        public Decimal MiscellaneousSales { get; set; }
        public Decimal LocalTax { get; set; }
        public Decimal TotalCreditSales { get; set; }
        public Decimal TotalCreditTaxSales { get; set; }
        public Decimal TotalNonTaxableSalesAmount { get; set; }
        public Decimal TotalPharmaSales { get; set; }
        public Decimal TotalNonPharmaSales { get; set; }
        public Decimal TotalPWDDiscountAmount { get; set; }
        public Decimal TotalGrossSalesFixRent { get; set; }
        public Decimal TotalAmountOfReprintedTransaction { get; set; }
        public Int32 TotalReprintedTransaction { get; set; }
        public List<TrnCollectionLineEntity> CollectionLines { get; set; }

        public Decimal TotalPrevGrossSale { get; set; }
    }
}
