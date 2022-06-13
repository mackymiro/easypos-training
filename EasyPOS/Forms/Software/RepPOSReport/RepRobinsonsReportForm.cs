using FluentFTP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FluentFTP;

namespace EasyPOS.Forms.Software.RepPOSReport
{
    public partial class RepRobinsonsReportForm : Form
    {
        public DateTime filterDate;
        public Int32 filterTerminalId;
        public Forms.Software.RepPOSReport.RepPOSReportForm repPOSReportForm;
        public Entities.RepRobinsonsAccreditationEntity robinsonsEntity;
        public RepRobinsonsReportForm(Forms.Software.RepPOSReport.RepPOSReportForm POSReportForm, Int32 terminalId, DateTime date)
        {
            InitializeComponent();
            repPOSReportForm = POSReportForm;
            filterTerminalId = terminalId;
            filterDate = date;
            RobinsonsDataSource();
        }

        public String FillLeadingZeroes(Decimal number, Int32 length)
        {
            var result = number.ToString();
            var pad = length - result.Length;
            while (pad > 0)
            {
                result = '0' + result;
                pad--;
            }

            return result;
        }

        public String FillLeadingZeroesForTenantId(Int32 number, Int32 length)
        {
            var result = number.ToString();
            var pad = length - result.Length;
            while (pad > 0)
            {
                result = '0' + result;
                pad--;
            }

            return result;
        }

        public void RobinsonsDataSource()
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            Entities.RepRobinsonsAccreditationEntity repRobinsonsAccreditationEntity = new Entities.RepRobinsonsAccreditationEntity()
            {
                TenantId = "",
                Terminal = "",
                TotalGrossSalesAmount = 0,
                TotalVATAmount = 0,
                TotalVoidAmount = 0,
                TotalOfVoidSalesTransaction = 0,
                TotalDiscountAmount = 0,
                TotalCountOfRegularDiscount = 0,
                TotalOfDiscountedSalesTransaction = 0,
                TotalRefundAmount = 0,
                TotalOfRefundSalesTransaction = 0,
                TotalSeniorDiscount = 0,
                TotalOfSeniorDiscountSalesTransaction = 0,
                TotalServiceChargeAmount = 0,
                PreviousEOD = "0",
                TotalNetSalesAmount = 0,
                PreviousGrandTotalEOD = 0,
                CurrentEOD = "0",
                CurrentGrandTotalEOD = 0,
                Date = DateTime.Now.Date,
                NoveltySales = 0,
                MiscellaneousSales = 0,
                LocalTax = 0,
                TotalCreditSales = 0,
                TotalCreditTaxSales = 0,
                TotalNonTaxableSalesAmount = 0,
                TotalPharmaSales = 0,
                TotalNonPharmaSales = 0,
                TotalPWDDiscountAmount = 0,
                TotalGrossSalesFixRent = 0,
                TotalAmountOfReprintedTransaction = 0,
                TotalReprintedTransaction = 0,
                CollectionLines = new List<Entities.TrnCollectionLineEntity>(),

            };

            repRobinsonsAccreditationEntity.TenantId = Modules.SysCurrentModule.GetCurrentSettings().TenantID;

            Controllers.SysSoftwareController sysSoftwareController = new Controllers.SysSoftwareController();
            String terminal = sysSoftwareController.GetCurrentTerminal(Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId));

            repRobinsonsAccreditationEntity.Terminal = terminal;
            repRobinsonsAccreditationEntity.Date = filterDate.Date;

            Decimal currentDeclareRate = 0;

            var currentSysDeclareRate = from d in db.SysDeclareRates
                                        where d.Date == filterDate
                                        select d;

            if (currentSysDeclareRate.Any())
            {
                if (currentSysDeclareRate.FirstOrDefault().DeclareRate != null)
                {
                    currentDeclareRate = Convert.ToDecimal(currentSysDeclareRate.FirstOrDefault().DeclareRate);
                }
            }
            else
            {
                currentDeclareRate = Modules.SysCurrentModule.GetCurrentSettings().DeclareRate;
            }

            var currentCollectionSalesLineQuery = from d in db.TrnSalesLines
                                                  where d.TrnSale.TrnCollections.Any() == true
                                                  && d.TrnSale.TrnCollections.Where(
                                                      c => c.TerminalId == filterTerminalId &&
                                                           c.CollectionDate == filterDate &&
                                                           c.IsLocked == true &&
                                                           c.IsCancelled == false &&
                                                           c.SalesId != null).Any() == true
                                                  && d.TrnSale.IsLocked == true
                                                  && d.TrnSale.IsCancelled == false
                                                  select d;

            if (currentCollectionSalesLineQuery.Any())
            {
                Decimal totalNetGrossSales = 0;
                Decimal totalGrossSales = 0;
                Decimal totalNonTaxableSales = 0;
                Decimal totalRegularDiscount = 0;
                Decimal totalSeniorCitizenDiscount = 0;
                Decimal totalPWDDiscount = 0;
                Decimal totalSalesReturn = 0;
                Decimal totalVATSales = 0;
                Decimal totalVATAmount = 0;
                Decimal totalNonVATSales = 0;
                Decimal totalVATExemptSales = 0;
                Decimal totalVATZeroRatedSales = 0;
                Decimal totalServiceChargeAmount = 0;
                Int32? totalCustomerCount = 0;
                Int32 totalOfSalesTransaction = 0;
                Decimal totalSalesPerSalesType = 0;
                Decimal totalCreditTransaction = 0;

                var sales = from d in db.TrnSales
                            where d.SalesDate == filterDate
                            && d.TrnCollections.Where(
                                c => c.TerminalId == filterTerminalId &&
                                c.CollectionDate == filterDate &&
                                c.IsLocked == true &&
                                c.IsCancelled == false &&
                                c.SalesId != null).Any() == true
                            && d.IsLocked == true
                            && d.IsCancelled == false
                            select d;
                if (sales.Any())
                {
                    var salesList = sales.ToArray();

                    totalCustomerCount = sales.Sum(d => d.Pax != null ? d.Pax : 0);
                    totalOfSalesTransaction = sales.GroupBy(d => d.Id).Count();
                    String _TotalAmountOfReprintedTransaction = sales.Sum(d => d.Amount != null ? d.Amount * d.NumberOfReprinted : 0).ToString("#,##0.00");
                    repRobinsonsAccreditationEntity.TotalAmountOfReprintedTransaction = Convert.ToDecimal(_TotalAmountOfReprintedTransaction);
                    repRobinsonsAccreditationEntity.TotalReprintedTransaction = sales.Sum(d => d.NumberOfReprinted != null ? d.NumberOfReprinted : 0);

                }
                //repMegaWorldEntity.TotalCustomerCount = totalCustomerCount;
                //repMegaWorldEntity.TotalOfSalesTransaction = totalOfSalesTransaction;


                var salesLinesQuery = from d in currentCollectionSalesLineQuery
                                      where d.Quantity > 0
                                      select d;
                Decimal sumOfDiscount = 0;
                if (salesLinesQuery.Any())
                {
                    var salesLines = salesLinesQuery.ToArray();

                    totalServiceChargeAmount = salesLines.Sum(d => d.MstItem.ItemDescription == "Service Charge" ? d.Price * d.Quantity : 0);
                    totalNonTaxableSales = salesLines.Sum(d => d.MstTax.Code == "EXEMPTVAT" ? ((d.Price - d.DiscountAmount) * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : 0);

                    totalNetGrossSales = salesLines.Sum(d =>
                         d.MstTax.Code == "EXEMPTVAT" ?
                             d.MstItem.MstTax1.Rate > 0 ?
                                 (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                         : d.MstTax.Rate > 0 ?
                                 (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                     );
                    sumOfDiscount = salesLines.Sum(d => d.DiscountAmount);

                    totalGrossSales = salesLines.Sum(d => d.MstTax.Code == "EXEMPTVAT" ?
                                         (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100))
                                     : d.MstTax.Rate > 0 ?
                                        d.Price * d.Quantity : d.Price * d.Quantity);

                    repRobinsonsAccreditationEntity.TotalOfDiscountedSalesTransaction = salesLines.Where(d => d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD"
                                                                                        && d.MstDiscount.Discount != "Zero Discount").OrderBy(d => d.Id).Count();

                    totalRegularDiscount = salesLines.Sum(d =>
                       d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? ((d.Price * d.Quantity) * (d.DiscountRate / 100)) : 0
                   );

                    totalSeniorCitizenDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0
                    );
                    repRobinsonsAccreditationEntity.TotalOfSeniorDiscountSalesTransaction = salesLines.Where(d => d.MstDiscount.Discount == "Senior Citizen Discount").OrderBy(d => d.Id).Count();

                    totalPWDDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0
                    );

                    totalVATSales = salesLines.Sum(d =>
                       d.MstTax.Code == "VAT" && (d.MstDiscount.Discount != "Senior Citizen Discount" || d.MstDiscount.Discount != "PWD") ? ((d.Price * d.Quantity) - d.TaxAmount) : 0
                    );

                    totalVATAmount = salesLines.Sum(d =>
                        d.MstTax.Code == "VAT" ? d.TaxAmount : 0
                    );

                    totalNonVATSales = salesLines.Sum(d =>
                        d.MstTax.Code == "NONVAT" ? d.Amount : 0
                    );

                    totalVATExemptSales = salesLines.Sum(d =>
                        d.MstTax.Code == "EXEMPTVAT" && (d.MstDiscount.Discount == "Senior Citizen Discount" || d.MstDiscount.Discount == "PWD") ? ((d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100))) - d.DiscountAmount : 0
                    );
                    //Decimal _taxRate = 0;
                    //Decimal _price = 0;
                    //Decimal _quantity = 0;
                    //String _taxCode = "EXEMPTVAT";
                    //Decimal vatExempt = 0;

                    //foreach(var sales in salesLines)
                    //{
                    //    if(sales.MstTax.Code == _taxCode)
                    //    {
                    //        vatExempt = ((sales.Price * sales.Quantity) - ((sales.Price * sales.Quantity) / (1 + (sales.MstItem.MstTax1.Rate / 100)) * (sales.MstItem.MstTax1.Rate / 100)));
                    //    }
                    //}

                    totalVATZeroRatedSales = salesLines.Sum(d =>
                        d.MstTax.Code == "ZEROVAT" ? d.Amount : 0
                    );
                }

                Decimal VATSalesReturn = 0;
                Decimal VATAmountSalesReturn = 0;
                Decimal VATExemptSalesReturn = 0;
                Decimal VATAmountExemptSalesReturn = 0;

                //&& d.TrnSale.IsReturned == true
                var salesReturnLinesQuery = from d in db.TrnSalesLines
                                            where d.Quantity < 0
                                            && d.TrnSale.SalesDate == filterDate
                                            && d.TrnSale.IsLocked == true
                                            && d.TrnSale.IsCancelled == false
                                            && d.TrnSale.IsReturned == true
                                            select d;

                if (salesReturnLinesQuery.Any())
                {
                    var salesReturnLines = salesReturnLinesQuery.ToArray();

                    VATSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "VAT" ? d.Amount : 0
                    );

                    VATAmountSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "VAT" ? d.TaxAmount : 0
                    ) * -1;

                    VATExemptSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "EXEMPTVAT" ? d.Amount : 0
                    );

                    VATAmountExemptSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.TaxAmount
                    ) * -1;

                    totalSalesReturn = (VATSalesReturn + VATExemptSalesReturn);
                }
                //
                var disbursment = from d in db.TrnDisbursements
                                  where d.TerminalId == filterTerminalId
                                  && d.DisbursementDate == filterDate
                                  && d.IsLocked == true
                                  && d.IsRefund == true
                                  && d.RefundSalesId != null
                                  select d;

                var CancelledCollection = from d in db.TrnCollections
                                          where d.TerminalId == filterTerminalId
                                          && d.CollectionDate == filterDate
                                          && d.IsLocked == true
                                          && d.IsCancelled == true
                                          select d;
                Decimal refund = 0;
                Decimal voidTransaction = 0;
                if (disbursment.Any())
                {
                    refund = disbursment.Sum(d => d.Amount != null ? d.Amount : 0);
                }
                if (CancelledCollection.Any())
                {
                    voidTransaction = CancelledCollection.Sum(d => d.Amount != null ? d.Amount : 0);

                }
                String _totalGrossSales = (totalGrossSales - refund).ToString("#,##0.00");

                String _totalNonTaxableSales = (totalNonTaxableSales * currentDeclareRate).ToString("#,##0.00");
                String _totalNetGrossSales = (totalNetGrossSales * currentDeclareRate).ToString("#,##0.00");
                //String _totalGrossSales = (totalGrossSales * currentDeclareRate).ToString("#,##0.00");
                String _totalRegularDiscount = (totalRegularDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalSeniorCitizenDiscount = (totalSeniorCitizenDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalPWDDiscount = (totalPWDDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalSalesReturn = (totalSalesReturn * currentDeclareRate).ToString("#,##0.00");
                String _TotalServiceChargeAmount = (totalServiceChargeAmount * currentDeclareRate).ToString("#,##0.00");

                repRobinsonsAccreditationEntity.TotalServiceChargeAmount = Convert.ToDecimal(_TotalServiceChargeAmount);
                repRobinsonsAccreditationEntity.TotalNonTaxableSalesAmount = Convert.ToDecimal(_totalNonTaxableSales);
                repRobinsonsAccreditationEntity.TotalGrossSalesAmount = Convert.ToDecimal(_totalGrossSales) * currentDeclareRate;
                repRobinsonsAccreditationEntity.TotalDiscountAmount = Convert.ToDecimal(_totalRegularDiscount);
                repRobinsonsAccreditationEntity.TotalSeniorDiscount = Convert.ToDecimal(_totalSeniorCitizenDiscount);
                repRobinsonsAccreditationEntity.TotalPWDDiscountAmount = Convert.ToDecimal(_totalPWDDiscount);


                repRobinsonsAccreditationEntity.TotalNetSalesAmount = Convert.ToDecimal(_totalGrossSales) -
                                                        Convert.ToDecimal(_totalRegularDiscount) -
                                                        Convert.ToDecimal(_totalSeniorCitizenDiscount) -
                                                        Convert.ToDecimal(_totalPWDDiscount)
                                                       /*- (Convert.ToDecimal(_totalSalesReturn) * -1)*/;

                Decimal TotalVATSales = totalVATSales - (VATSalesReturn * -1);
                Decimal TotalNonVAT = totalNonVATSales;
                Decimal TotalVATExempt = totalVATExemptSales - (VATExemptSalesReturn * -1);
                Decimal TotalVATZeroRated = totalVATZeroRatedSales;
            }

            var disbursmenet = from d in db.TrnDisbursements
                               where d.TerminalId == filterTerminalId
                               && d.DisbursementDate == filterDate
                               && d.IsLocked == true
                               && d.IsRefund == true
                               && d.RefundSalesId != null
                               select d;

            if (disbursmenet.Any())
            {
                String _TotalRefundAmount = disbursmenet.Sum(d => d.Amount).ToString("#,##0.00");
                repRobinsonsAccreditationEntity.TotalRefundAmount = Convert.ToDecimal(_TotalRefundAmount);
                repRobinsonsAccreditationEntity.TotalOfRefundSalesTransaction = disbursmenet.GroupBy(d => d.Id).Count();
            }

            var currentCancelledCollections = from d in db.TrnCollections
                                              where d.TerminalId == filterTerminalId
                                              && d.CollectionDate == filterDate
                                              && d.IsLocked == true
                                              && d.IsCancelled == true
                                              select d;

            if (currentCancelledCollections.Any())
            {
                String _TotalVoidAmount = currentCancelledCollections.Sum(d => d.Amount).ToString("#,##0.00");
                repRobinsonsAccreditationEntity.TotalVoidAmount = Convert.ToDecimal(_TotalVoidAmount);
                repRobinsonsAccreditationEntity.TotalOfVoidSalesTransaction = currentCancelledCollections.GroupBy(d => d.Id).Count();
            }

            var currentCashCollectionLinesQuery = from d in db.TrnCollectionLines
                                                  where d.TrnCollection.TerminalId == filterTerminalId
                                                  && d.TrnCollection.CollectionDate == filterDate
                                                  && d.TrnCollection.IsLocked == true
                                                  && d.TrnCollection.IsCancelled == false
                                                  && d.MstPayType.PayTypeCode == "CASH"
                                                  group d by new
                                                  {
                                                      d.MstPayType.PayTypeCode,
                                                      d.MstPayType.PayType,
                                                  } into g
                                                  select new
                                                  {
                                                      g.Key.PayTypeCode,
                                                      g.Key.PayType,
                                                      Amount = g.Sum(s => s.MstPayType.PayTypeCode == "CASH" ? s.Amount : 0)
                                                  };
            Decimal totalCASHCollectionAmount = 0;

            if (currentCashCollectionLinesQuery.ToList().Any())
            {
                var currentCollectionLines = currentCashCollectionLinesQuery.ToArray();

                for (Int32 i = 0; i < currentCollectionLines.Count(); i++)
                {
                    var collectionLine = currentCollectionLines[i];

                    repRobinsonsAccreditationEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalCASHCollectionAmount += collectionLine.Amount;
                }
            }

            //repRobinsonsAccreditationEntity.TotalCashSalesAmount = totalCASHCollectionAmount - repRobinsonsAccreditationEntity.TotalRefundAmount;


            var currentCollectionLinesQuery = from d in db.TrnCollectionLines
                                              where d.TrnCollection.TerminalId == filterTerminalId
                                              && d.TrnCollection.CollectionDate == filterDate
                                              && d.TrnCollection.IsLocked == true
                                              && d.TrnCollection.IsCancelled == false
                                              && d.MstPayType.PayTypeCode == "CREDITCARD"
                                              group d by new
                                              {
                                                  d.MstPayType.PayTypeCode,
                                                  d.MstPayType.PayType,
                                              } into g
                                              select new
                                              {
                                                  g.Key.PayTypeCode,
                                                  g.Key.PayType,
                                                  Amount = g.Sum(s => s.MstPayType.PayTypeCode == "CREDITCARD" ? s.Amount : 0)
                                              };

            Decimal totalCollectionAmount = 0;

            if (currentCollectionLinesQuery.ToList().Any())
            {
                var currentCollectionLines = currentCollectionLinesQuery.ToArray();

                for (Int32 i = 0; i < currentCollectionLines.Count(); i++)
                {
                    var collectionLine = currentCollectionLines[i];

                    repRobinsonsAccreditationEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalCollectionAmount += collectionLine.Amount;
                }
            }
            var collectedCC = from d in db.TrnCollections
                              where d.TerminalId == filterTerminalId
                              && d.CollectionDate == filterDate
                              && d.IsLocked == true
                              && d.IsCancelled == false
                              && d.TrnCollectionLines.FirstOrDefault().MstPayType.PayTypeCode == "CREDITCARD"
                              select d;
            Decimal RefundCC = 0;
            Decimal VoidCC = 0;
            var disbursmentCC = from d in db.TrnDisbursements
                                where d.TerminalId == filterTerminalId
                                && d.DisbursementDate == filterDate
                                && d.IsLocked == true
                                && d.IsRefund == true
                                && d.RefundSalesId != null
                                && d.MstPayType.PayTypeCode == "CREDITCARD"
                                select d;

            var CancelledCollectionCC = from d in db.TrnCollections
                                        where d.TerminalId == filterTerminalId
                                        && d.CollectionDate == filterDate
                                        && d.IsLocked == true
                                        && d.IsCancelled == true
                                        && d.TrnCollectionLines.FirstOrDefault().MstPayType.PayTypeCode == "CREDITCARD"
                                        select d;
            if (disbursmentCC.Any())
            {
                RefundCC = disbursmentCC.Sum(x => x.Amount);
            }
            if (CancelledCollectionCC.Any())
            {
                VoidCC = CancelledCollectionCC.Sum(x => x.Amount);
            }
            String _TotalCreditSales = totalCollectionAmount.ToString("#,##0.00");
            repRobinsonsAccreditationEntity.TotalCreditSales = Convert.ToDecimal(_TotalCreditSales);
            String _TotalCreditTaxSales = "0";
            if (collectedCC.Any())
            {
                _TotalCreditTaxSales = (repRobinsonsAccreditationEntity.TotalCreditSales / (1 + collectedCC.FirstOrDefault().TrnSale.TrnSalesLines.FirstOrDefault().MstItem.MstTax1.Rate / 100)
                                                                * (collectedCC.FirstOrDefault().TrnSale.TrnSalesLines.FirstOrDefault().MstItem.MstTax1.Rate / 100)).ToString("#,##0.00");
            }

            repRobinsonsAccreditationEntity.TotalCreditTaxSales = Convert.ToDecimal(_TotalCreditTaxSales);

            var currentOtherPaymentCollectionLinesQuery = from d in db.TrnCollectionLines
                                                          where d.TrnCollection.TerminalId == filterTerminalId
                                                          && d.TrnCollection.CollectionDate == filterDate
                                                          && d.TrnCollection.IsLocked == true
                                                          && d.TrnCollection.IsCancelled == false
                                                          && d.MstPayType.PayTypeCode != "CASH"
                                                          && d.MstPayType.PayTypeCode != "CREDITCARD"
                                                          group d by new
                                                          {
                                                              d.MstPayType.PayTypeCode,
                                                              d.MstPayType.PayType,
                                                          } into g
                                                          select new
                                                          {
                                                              g.Key.PayTypeCode,
                                                              g.Key.PayType,
                                                              Amount = g.Sum(s => s.MstPayType.PayTypeCode != "CREDITCARD" && s.MstPayType.PayTypeCode != "CASH" ? s.Amount : 0)
                                                          };

            Decimal totalOtherCollectionAmount = 0;

            if (currentOtherPaymentCollectionLinesQuery.ToList().Any())
            {
                var currentCollectionLines = currentOtherPaymentCollectionLinesQuery.ToArray();

                for (Int32 i = 0; i < currentCollectionLines.Count(); i++)
                {
                    var collectionLine = currentCollectionLines[i];

                    repRobinsonsAccreditationEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalOtherCollectionAmount += collectionLine.Amount;
                }
            }

            //repRobinsonsAccreditationEntity.TotalOtherPaymentAmount = totalOtherCollectionAmount - repRobinsonsAccreditationEntity.TotalRefundAmount;

            var currentCollectionLinesQueryGC = from d in db.TrnCollectionLines
                                                where d.TrnCollection.TerminalId == filterTerminalId
                                                && d.TrnCollection.CollectionDate == filterDate
                                                && d.TrnCollection.IsLocked == true
                                                && d.TrnCollection.IsCancelled == false
                                                && d.MstPayType.PayTypeCode == "CASH" && d.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC"
                                                //&& (d.MstPayType.PayTypeCode == "GIFTCERTIFICATE"
                                                //|| d.MstPayType.PayTypeCode == "CASH" && d.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC")
                                                group d by new
                                                {
                                                    d.MstPayType.PayTypeCode,
                                                    d.MstPayType.PayType,
                                                } into g
                                                select new
                                                {
                                                    g.Key.PayTypeCode,
                                                    g.Key.PayType,
                                                    Amount = g.Sum(s => s.Amount)
                                                };


            Decimal totalCollectionGCAmount = 0;

            if (currentCollectionLinesQueryGC.ToList().Any())
            {
                var currentCollectionLines = currentCollectionLinesQueryGC.ToArray();

                for (Int32 i = 0; i < currentCollectionLines.Count(); i++)
                {
                    var collectionLine = currentCollectionLines[i];

                    repRobinsonsAccreditationEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalCollectionGCAmount += collectionLine.Amount;
                }
            }
            Decimal RefundGC = 0;
            //Decimal VoidGC = 0;
            var disbursmentGC = from d in db.TrnDisbursements
                                where d.TerminalId == filterTerminalId
                                && d.DisbursementDate == filterDate
                                && d.IsLocked == true
                                && d.IsRefund == true
                                && d.RefundSalesId != null
                               && d.MstPayType.PayTypeCode == "CASH" && d.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC"
                                select d;

            //var CancelledCollectionGC = from d in db.TrnCollections
            //                            where d.TerminalId == filterTerminalId
            //                            && d.CollectionDate == filterDate
            //                            && d.IsLocked == true
            //                            && d.IsCancelled == true
            //                            && (d.TrnCollectionLines.FirstOrDefault().MstPayType.PayTypeCode == "GIFTCERTIFICATE"
            //                                  || d.TrnCollectionLines.FirstOrDefault().MstPayType.PayTypeCode == "CASH" && d.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC")
            //                            select d;



            if (disbursmentGC.Any())
            {
                RefundGC = disbursmentGC.Sum(x => x.Amount);
            }
            //if (CancelledCollectionGC.Any())
            //{
            //    VoidGC = CancelledCollectionGC.Sum(x => x.Amount);
            //}
            String _TotalGCCash = (totalCollectionGCAmount - RefundGC).ToString("#,##0.00");
            repRobinsonsAccreditationEntity.TotalGrossSalesFixRent = Convert.ToDecimal(_TotalGCCash);

            var previousDeclareRates = from d in db.SysDeclareRates
                                       where d.Date < filterDate
                                       select d;

            Decimal totalAccumulatedGrossSales = 0;
            Decimal totalAccumulatedRegularDiscount = 0;
            Decimal totalAccumulatedSeniorCitizenDiscount = 0;
            Decimal totalAccumulatedPWDDiscount = 0;
            Decimal totalAccumulatedSalesReturn = 0;

            //&& d.TrnSale.IsReturned == false

            var previousCollectionSalesLineQuery = from d in db.TrnSalesLines
                                                   where d.TrnSale.TrnCollections.Any() == true
                                                   && d.TrnSale.TrnCollections.Where(
                                                       c => c.TerminalId == filterTerminalId &&
                                                            c.CollectionDate < filterDate &&
                                                            c.IsLocked == true &&
                                                            c.IsCancelled == false &&
                                                            c.SalesId != null).Any() == true
                                                   && d.TrnSale.IsLocked == true
                                                   && d.TrnSale.IsCancelled == false
                                                   && d.TrnSale.IsReturned == false
                                                   select d;

            if (previousCollectionSalesLineQuery.Any())
            {
                var salesLinesQuery = from d in previousCollectionSalesLineQuery
                                      where d.Quantity > 0
                                      select d;

                if (salesLinesQuery.Any())
                {
                    var salesLines = salesLinesQuery.ToArray();
                    var previousDeclareRatesValues = previousDeclareRates.ToArray();

                    totalAccumulatedGrossSales = salesLines.Sum(d =>
                      previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                      (
                       d.MstTax.Code == "EXEMPTVAT" ?
                                          (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100))
                                      : d.MstTax.Rate > 0 ?
                                         d.Price * d.Quantity : d.Price * d.Quantity
                      ) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                      :
                       (
                       d.MstTax.Code == "EXEMPTVAT" ?
                                          (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100))
                                      : d.MstTax.Rate > 0 ?
                                         d.Price * d.Quantity : d.Price * d.Quantity
                      )
                    );

                    totalAccumulatedRegularDiscount = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? d.DiscountAmount * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? d.DiscountAmount * d.Quantity : 0) * currentDeclareRate
                    );

                    totalAccumulatedSeniorCitizenDiscount = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0) * currentDeclareRate
                    );

                    totalAccumulatedPWDDiscount = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.MstDiscount.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (d.MstDiscount.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0) * currentDeclareRate
                    );
                }

                Decimal VATSalesReturn = 0;
                Decimal VATAmountSalesReturn = 0;
                Decimal VATExemptSalesReturn = 0;
                Decimal VATAmountExemptSalesReturn = 0;

                var previousSalesReturnLinesQuery = from d in db.TrnSalesLines
                                                    where d.Quantity < 0
                                                    && d.TrnSale.SalesDate < filterDate
                                                    && d.TrnSale.IsLocked == true
                                                    && d.TrnSale.IsCancelled == false
                                                    && d.TrnSale.IsReturned == true
                                                    select d;

                if (previousSalesReturnLinesQuery.Any())
                {
                    var salesReturnLines = previousSalesReturnLinesQuery.ToArray();
                    var previousDeclareRatesValues = previousDeclareRates.ToArray();

                    VATSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? d.Amount : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? d.Amount : 0) * currentDeclareRate).ToString("#,##0.00"))
                    );

                    VATAmountSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? d.TaxAmount : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? d.TaxAmount : 0) * currentDeclareRate).ToString("#,##0.00"))
                    ) * -1;

                    VATExemptSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? d.Amount : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? d.Amount : 0) * currentDeclareRate).ToString("#,##0.00"))
                    );

                    VATAmountExemptSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.TaxAmount) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.TaxAmount) * currentDeclareRate).ToString("#,##0.00"))
                    ) * -1;

                    totalAccumulatedSalesReturn = (VATSalesReturn + VATExemptSalesReturn);
                }
            }
            var prevDisbursment = from d in db.TrnDisbursements
                                  where d.TerminalId == filterTerminalId
                                  && d.DisbursementDate < filterDate
                                  && d.IsLocked == true
                                  && d.IsRefund == true
                                  && d.RefundSalesId != null
                                  select d;

            Decimal prevRefund = 0;
            if (prevDisbursment.Any())
            {
                prevRefund = prevDisbursment.Sum(d => d.Amount != null ? d.Amount : 0);
            }

            String _totalAccumulatedGrossSales = (totalAccumulatedGrossSales - prevRefund).ToString("#,##0.00");
            String _totalAccumulatedRegularDiscount = totalAccumulatedRegularDiscount.ToString("#,##0.00");
            String _totalAccumulatedSeniorCitizenDiscount = totalAccumulatedSeniorCitizenDiscount.ToString("#,##0.00");
            String _totalAccumulatedPWDDiscount = totalAccumulatedPWDDiscount.ToString("#,##0.00");
            String _totalAccumulatedSalesReturn = totalAccumulatedSalesReturn.ToString("#,##0.00");

            Decimal _totalAccumulatedPreviousNetSales = Convert.ToDecimal(_totalAccumulatedGrossSales) -
                                                    Convert.ToDecimal(_totalAccumulatedRegularDiscount) -
                                                    Convert.ToDecimal(_totalAccumulatedSeniorCitizenDiscount) -
                                                    Convert.ToDecimal(_totalAccumulatedPWDDiscount)
                                                    /* - (Convert.ToDecimal(_totalAccumulatedSalesReturn) * -1)*/;

            repRobinsonsAccreditationEntity.PreviousGrandTotalEOD = _totalAccumulatedPreviousNetSales;
            repRobinsonsAccreditationEntity.CurrentGrandTotalEOD = repRobinsonsAccreditationEntity.TotalNetSalesAmount + repRobinsonsAccreditationEntity.PreviousGrandTotalEOD;

            var firstCollection = from d in db.TrnCollections
                                  where d.IsLocked == true
                                  && d.TenderAmount != 0
                                  select d;

            if (firstCollection.Any())
            {
                Double totalCurrentDays = (filterDate - firstCollection.FirstOrDefault().CollectionDate).TotalDays + 1;
                Double totalPreviousDays = (filterDate - firstCollection.FirstOrDefault().CollectionDate).TotalDays;

                repRobinsonsAccreditationEntity.CurrentEOD = totalCurrentDays.ToString();
                if (repRobinsonsAccreditationEntity.CurrentEOD == "1")
                {
                    repRobinsonsAccreditationEntity.PreviousEOD = "0";
                }
                else
                {
                    repRobinsonsAccreditationEntity.PreviousEOD = totalPreviousDays.ToString();
                }


            }
            Decimal tax = 1.12m;
            Decimal taxRate = .12m;
            String _TotalVATAmount = (((repRobinsonsAccreditationEntity.TotalGrossSalesAmount - (repRobinsonsAccreditationEntity.TotalSeniorDiscount
                                                + repRobinsonsAccreditationEntity.TotalNonTaxableSalesAmount + repRobinsonsAccreditationEntity.TotalPWDDiscountAmount + repRobinsonsAccreditationEntity.TotalGrossSalesFixRent))
                                                / tax) * taxRate).ToString("#,##0.00");
            repRobinsonsAccreditationEntity.TotalVATAmount = Convert.ToDecimal(_TotalVATAmount);

            robinsonsEntity = repRobinsonsAccreditationEntity;

        }

        public void CreateFile()
        {
            try
            {
                var dataSource = robinsonsEntity;
                //Int32 DiscountedCountTransaction = dataSource.TotalOfDiscountedSalesTransaction + dataSource.TotalCountOfRegularDiscount;
                String tCode = dataSource.TenantId.Substring(6, 4);
                String currentTerminal = dataSource.Terminal.Substring(1);
                Int32 batchNumber = 1;
                String month = dataSource.Date.Month.ToString("d2");
                String day = dataSource.Date.Day.ToString("00");
                var filename = @"C:\Robinsons\";
              
                var directory = new DirectoryInfo(filename);
                if (directory.GetFiles(tCode + month + day) != null)
                {
                    //var filepath = files;
                    //filepath.Substring(24, 1);
                    //Int32 newBatchnumber = Convert.ToInt32(filepath) + 1;
                    //batchNumber = newBatchnumber;

                    batchNumber = Directory.GetFiles(filename, tCode + month + day + ".*", SearchOption.AllDirectories).Length;
                    if (batchNumber != null)
                    {
                        batchNumber = batchNumber + 1;
                    }
                }


                String path = @"C:\Robinsons\" + tCode + month + day + "." + currentTerminal + batchNumber.ToString();

                StreamWriter file = new StreamWriter(path);

                file.WriteLine("01" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.TenantId), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("02" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.Terminal), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("03" + FillLeadingZeroes(dataSource.TotalGrossSalesAmount, 16).Replace(",", ""));
                file.WriteLine("04" + FillLeadingZeroes(dataSource.TotalVATAmount, 16).Replace(",", ""));
                file.WriteLine("05" + FillLeadingZeroes(dataSource.TotalVoidAmount, 16).Replace(",", ""));
                file.WriteLine("06" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.TotalOfVoidSalesTransaction), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("07" + FillLeadingZeroes(dataSource.TotalDiscountAmount, 16).Replace(",", ""));
                file.WriteLine("08" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.TotalOfDiscountedSalesTransaction), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("09" + FillLeadingZeroes(dataSource.TotalRefundAmount, 16).Replace(",", ""));
                file.WriteLine("10" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.TotalOfRefundSalesTransaction), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("11" + FillLeadingZeroes(dataSource.TotalSeniorDiscount, 16).Replace(",", ""));
                file.WriteLine("12" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.TotalOfSeniorDiscountSalesTransaction), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("13" + FillLeadingZeroes(dataSource.TotalServiceChargeAmount, 16).Replace(",", ""));
                file.WriteLine("14" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.PreviousEOD), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("15" + FillLeadingZeroes(dataSource.PreviousGrandTotalEOD, 16).Replace(",", ""));
                file.WriteLine("16" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.CurrentEOD), 16).Replace(".", "").Replace(",", ""));
                file.WriteLine("17" + FillLeadingZeroes(dataSource.CurrentGrandTotalEOD, 16).Replace(",", ""));
                file.WriteLine("18" + "000000" + dataSource.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture).Replace(".", "").Replace(",", ""));
                file.WriteLine("20" + dataSource.NoveltySales.ToString("#,##0.00").PadLeft(16, '0').Replace(",", ""));
                file.WriteLine("21" + dataSource.LocalTax.ToString("#,##0.00").PadLeft(16, '0').Replace(",", ""));
                file.WriteLine("22" + FillLeadingZeroes(dataSource.TotalCreditSales, 16).Replace(",", ""));
                file.WriteLine("23" + FillLeadingZeroes(dataSource.TotalCreditTaxSales, 16).Replace(",", ""));
                file.WriteLine("24" + FillLeadingZeroes(dataSource.TotalNonTaxableSalesAmount, 16).Replace(",", ""));
                file.WriteLine("25" + dataSource.TotalPharmaSales.ToString("#,##0.00").PadLeft(16, '0').Replace(",", ""));
                file.WriteLine("26" + dataSource.TotalNonPharmaSales.ToString("#,##0.00").PadLeft(16, '0').Replace(",", ""));
                file.WriteLine("27" + FillLeadingZeroes(dataSource.TotalPWDDiscountAmount, 16).Replace(",", ""));
                file.WriteLine("28" + FillLeadingZeroes(dataSource.TotalGrossSalesFixRent, 16).Replace(",", ""));
                file.WriteLine("29" + dataSource.TotalAmountOfReprintedTransaction.ToString("#,##0.00").PadLeft(16, '0').Replace(",", ""));
                file.WriteLine("30" + FillLeadingZeroesForTenantId(Convert.ToInt32(dataSource.TotalReprintedTransaction), 16).Replace(".", "").Replace(",", ""));

                file.Close();
                MessageBox.Show("File Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.None);


                String destination = @"./../IT_Tenants";
                String host = Modules.SysCurrentModule.GetCurrentSettings().RLCServerIP;
                String username = "accredit";
                String password = "RLC@Partners";
                Int32 port = 22;

                Modules.SysSFTPModule.UploadFile(host, username, password, path, destination, port);
                //Modules.SysSFTPModule.CopyFile(host, filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
