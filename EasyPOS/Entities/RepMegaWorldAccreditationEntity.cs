using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Entities
{
    public class RepMegaWorldAccreditationEntity
    {
        public String TenantName { get; set; }
        public String TenantCode { get; set; }
        public String Terminal { get; set; }
        public String SalesType { get; set; }
        public DateTime Date { get; set; }
        public Decimal OldTotalAccumulated { get; set; }
        public Decimal NewTotalAccumulated { get; set; }
        public Decimal TotalGrossSalesAmount { get; set; }
        public Decimal TotalNonTaxableSalesAmount { get; set; }
        public Decimal TotalSeniorPWDDiscount { get; set; }
        public Decimal TotalOtherDiscount { get; set; }
        public Decimal TotalRefundAmount { get; set; }
        public Decimal TotalVATAmount { get; set; }
        public Decimal TotalServiceChargeAmount { get; set; }
        public Decimal TotalNetSalesAmount { get; set; }
        public Decimal TotalCashSalesAmount { get; set; }
        public Decimal TotalCreditDebitAmount { get; set; }
        public Decimal TotalOtherPaymentAmount { get; set; }
        public Decimal TotalVoidAmount { get; set; }
        public Int32? TotalCustomerCount { get; set; }
        public String ControlNumber { get; set; }
        public Int32 TotalOfSalesTransaction { get; set; }
        public Decimal TotalSalesPerSalesType { get; set; }
        public List<TrnCollectionLineEntity> CollectionLines { get; set; }
        public Decimal TotalHourlyNetSalesAmount { get; set; }
        ////Hourly Entities

        //public Decimal TotalHourlyGrossSalesAmount { get; set; }
        //public Decimal TotalHourlyNonTaxableSalesAmount { get; set; }
        //public Decimal TotalHourlySeniorPWDDiscount { get; set; }
        //public Decimal TotalHourlyOtherDiscount { get; set; }
        //public Decimal TotalHourlyRefundAmount { get; set; }
        //public Decimal TotalHourlyVATAmount { get; set; }
        //public Decimal TotalHourlyServiceChargeAmount { get; set; }
        //
        //public Decimal TotalHourlyCashSalesAmount { get; set; }
        //public Decimal TotalHourlyCreditDebitAmount { get; set; }
        //public Decimal TotalHourlyOtherPaymentAmount { get; set; }
        //public Decimal TotalHourlyVoidAmount { get; set; }
        //public Int32? TotalHourlyCustomerCount { get; set; }
        //public Int32 TotalHourlyOfSalesTransaction { get; set; }
        //public List<TrnSalesLineEntity> SalesLines { get; set; }

    }
}
