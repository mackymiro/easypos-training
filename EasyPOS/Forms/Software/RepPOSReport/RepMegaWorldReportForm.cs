using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;
using System.Security.AccessControl;

namespace EasyPOS.Forms.Software.RepPOSReport
{
    public partial class RepMegaWorldReportForm : Form
    {
        public DateTime filterDate;
        public Int32 filterTerminalId;
        public Forms.Software.RepPOSReport.RepPOSReportForm repPOSReportForm;
        public Entities.RepMegaWorldAccreditationEntity megaWorldEntity;
        public RepMegaWorldReportForm(Forms.Software.RepPOSReport.RepPOSReportForm POSReportForm, Int32 terminalId, DateTime date)
        {
            InitializeComponent();

            repPOSReportForm = POSReportForm;
            filterTerminalId = terminalId;
            filterDate = date;

            MegaWorldDataSource();
        }

        public String FillLeadingZeroes(Int32 number, Int32 length)
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
        public String getHourCode(Int32 hour, Int32 minute)
        {
            String returnText = "";
            if (hour == 1 && minute <= 59 || hour == 2 && minute == 00)
            {
                returnText = "01";
            }
            else if (hour == 2 && minute >= 01 || hour == 3 && minute == 00)
            {
                returnText = "02";
            }
            else if (hour == 3 && minute >= 01 || hour == 4 && minute == 00)
            {
                returnText = "03";
            }
            else if (hour == 4 && minute >= 01 || hour == 5 && minute == 00)
            {
                returnText = "04";
            }
            else if (hour == 5 && minute >= 01 || hour == 6 && minute == 00)
            {
                returnText = "05";
            }
            else if (hour == 6 && minute >= 01 || hour == 7 && minute == 00)
            {
                returnText = "06";
            }
            else if (hour == 7 && minute >= 01 || hour == 8 && minute == 00)
            {
                returnText = "07";
            }
            else if (hour == 8 && minute >= 01 || hour == 9 && minute == 00)
            {
                returnText = "08";
            }
            else if (hour == 9 && minute >= 01 || hour == 10 && minute == 00)
            {
                returnText = "09";
            }
            else if (hour == 10 && minute >= 01 || hour == 11 && minute == 00)
            {
                returnText = "10";
            }
            else if (hour == 11 && minute >= 01 || hour == 12 && minute == 00)
            {
                returnText = "11";
            }
            else if (hour == 12 && minute >= 01 || hour == 13 && minute == 00)
            {
                returnText = "12";
            }
            else if (hour == 13 && minute >= 01 || hour == 14 && minute == 00)
            {
                returnText = "13";
            }
            else if (hour == 14 && minute >= 01 || hour == 15 && minute == 00)
            {
                returnText = "14";
            }
            else if (hour == 15 && minute >= 01 || hour == 16 && minute == 00)
            {
                returnText = "15";
            }
            else if (hour == 16 && minute >= 01 || hour == 17 && minute == 00)
            {
                returnText = "16";
            }
            else if (hour == 17 && minute >= 01 || hour == 18 && minute == 00)
            {
                returnText = "17";
            }
            else if (hour == 18 && minute >= 01 || hour == 19 && minute == 00)
            {
                returnText = "18";
            }
            else if (hour == 19 && minute >= 01 || hour == 20 && minute == 00)
            {
                returnText = "19";
            }
            else if (hour == 20 && minute >= 01 || hour == 21 && minute == 00)
            {
                returnText = "20";
            }
            else if (hour == 21 && minute >= 01 || hour == 22 && minute == 00)
            {
                returnText = "21";
            }
            else if (hour == 22 && minute >= 01 || hour == 23 && minute == 00)
            {
                returnText = "22";
            }
            else if (hour == 23 && minute >= 01 || hour == 24 && minute == 00)
            {
                returnText = "23";
            }
            else
            {
                returnText = "24";
            }
            return returnText;
        }

        public String getMonth(Int32 number)
        {
            String returnMonth = "";

            switch (number)
            {
                case 1:
                    returnMonth = "1";
                    break;
                case 2:
                    returnMonth = "2";
                    break;
                case 3:
                    returnMonth = "3";
                    break;
                case 4:
                    returnMonth = "4";
                    break;
                case 5:
                    returnMonth = "5";
                    break;
                case 6:
                    returnMonth = "6";
                    break;
                case 7:
                    returnMonth = "7";
                    break;
                case 8:
                    returnMonth = "8";
                    break;
                case 9:
                    returnMonth = "9";
                    break;
                case 10:
                    returnMonth = "A";
                    break;
                case 11:
                    returnMonth = "B";
                    break;
                case 12:
                    returnMonth = "C";
                    break;
                default:
                    break;
            }

            return returnMonth;
        }

        public void HourlyMegaWorldDataSource()
        {

        }
        public void MegaWorldDataSource()
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            Entities.RepMegaWorldAccreditationEntity repMegaWorldEntity = new Entities.RepMegaWorldAccreditationEntity()
            {
                TenantName = "",
                TenantCode = "",
                Terminal = "",
                SalesType = "",
                Date = DateTime.Now.Date,
                OldTotalAccumulated = 0,
                NewTotalAccumulated = 0,
                CollectionLines = new List<Entities.TrnCollectionLineEntity>(),
                TotalGrossSalesAmount = 0,
                TotalNonTaxableSalesAmount = 0,
                TotalSeniorPWDDiscount = 0,
                TotalOtherDiscount = 0,
                TotalRefundAmount = 0,
                TotalVATAmount = 0,
                TotalServiceChargeAmount = 0,
                TotalNetSalesAmount = 0,
                TotalCashSalesAmount = 0,
                TotalCreditDebitAmount = 0,
                TotalOtherPaymentAmount = 0,
                TotalVoidAmount = 0,
                TotalCustomerCount = 0,
                ControlNumber = "",
                TotalOfSalesTransaction = 0,
                TotalSalesPerSalesType = 0,
                TotalHourlyNetSalesAmount =0
            };

            repMegaWorldEntity.TenantName = Modules.SysCurrentModule.GetCurrentSettings().TenantName;
            repMegaWorldEntity.TenantCode = Modules.SysCurrentModule.GetCurrentSettings().TenantCode;

            Controllers.SysSoftwareController sysSoftwareController = new Controllers.SysSoftwareController();
            String terminal = sysSoftwareController.GetCurrentTerminal(Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId));

            repMegaWorldEntity.Terminal = terminal;
            repMegaWorldEntity.SalesType = Modules.SysCurrentModule.GetCurrentSettings().SalesType;
            repMegaWorldEntity.Date = filterDate.Date;

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

                }
                repMegaWorldEntity.TotalCustomerCount = totalCustomerCount;
                repMegaWorldEntity.TotalOfSalesTransaction = totalOfSalesTransaction;



                var salesLinesQuery = from d in currentCollectionSalesLineQuery
                                      where d.Quantity > 0
                                      select d;

                if (salesLinesQuery.Any())
                {
                    var salesLines = salesLinesQuery.ToArray();
                    totalServiceChargeAmount = salesLines.Sum(d => d.MstItem.ItemDescription == "Service Charge" ? d.Price * d.Quantity : 0);
                    totalNonTaxableSales = salesLines.Sum(d => d.MstTax.Code == "EXEMPTVAT" ? d.Price * d.Quantity : 0);

                    totalGrossSales = salesLines.Sum(d => d.Price * d.Quantity);

                    totalNetGrossSales = salesLines.Sum(d =>
                                      d.MstTax.Code == "EXEMPTVAT" ?
                                          d.MstItem.MstTax1.Rate > 0 ?
                                              (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                                      : d.MstTax.Rate > 0 ?
                                              (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                                  );

                    totalRegularDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? ((d.Price * d.Quantity) * (d.DiscountRate / 100)) : 0
                    );

                    totalSeniorCitizenDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0
                    );

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


                String _totalNonTaxableSales = (totalNonTaxableSales * currentDeclareRate).ToString("#,##0.00");
                String _totalNetGrossSales = (totalNetGrossSales * currentDeclareRate).ToString("#,##0.00");
                String _totalGrossSales = (totalGrossSales * currentDeclareRate).ToString("#,##0.00");
                String _totalRegularDiscount = (totalRegularDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalSeniorCitizenDiscount = (totalSeniorCitizenDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalPWDDiscount = (totalPWDDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalSalesReturn = (totalSalesReturn * currentDeclareRate).ToString("#,##0.00");

                repMegaWorldEntity.TotalServiceChargeAmount = totalServiceChargeAmount * currentDeclareRate;
                repMegaWorldEntity.TotalNonTaxableSalesAmount = Convert.ToDecimal(_totalNonTaxableSales);
                repMegaWorldEntity.TotalGrossSalesAmount = Convert.ToDecimal(_totalGrossSales);
                repMegaWorldEntity.TotalOtherDiscount = Convert.ToDecimal(_totalRegularDiscount);
                repMegaWorldEntity.TotalSeniorPWDDiscount = Convert.ToDecimal(_totalSeniorCitizenDiscount) + Convert.ToDecimal(_totalPWDDiscount);


                repMegaWorldEntity.TotalNetSalesAmount = Convert.ToDecimal(_totalGrossSales) -
                                                        Convert.ToDecimal(_totalRegularDiscount) -
                                                        Convert.ToDecimal(_totalSeniorCitizenDiscount) -
                                                        Convert.ToDecimal(_totalPWDDiscount) -
                                                        (Convert.ToDecimal(_totalSalesReturn) * -1);

                Decimal TotalVATSales = totalVATSales - (VATSalesReturn * -1);
                repMegaWorldEntity.TotalVATAmount = totalVATAmount - VATAmountSalesReturn - VATAmountExemptSalesReturn;
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
                repMegaWorldEntity.TotalRefundAmount = disbursmenet.Sum(d => d.Amount);
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

                    repMegaWorldEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalCASHCollectionAmount += collectionLine.Amount;
                }
            }

            repMegaWorldEntity.TotalCashSalesAmount = totalCASHCollectionAmount - repMegaWorldEntity.TotalRefundAmount;


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

                    repMegaWorldEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalCollectionAmount += collectionLine.Amount;
                }
            }

            repMegaWorldEntity.TotalCreditDebitAmount = totalCollectionAmount - repMegaWorldEntity.TotalRefundAmount;

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

                    repMegaWorldEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalOtherCollectionAmount += collectionLine.Amount;
                }
            }

            repMegaWorldEntity.TotalOtherPaymentAmount = totalOtherCollectionAmount - repMegaWorldEntity.TotalRefundAmount;



            var currentCancelledCollections = from d in db.TrnCollections
                                              where d.TerminalId == filterTerminalId
                                              && d.CollectionDate == filterDate
                                              && d.IsLocked == true
                                              && d.IsCancelled == true
                                              select d;

            if (currentCancelledCollections.Any())
            {
                repMegaWorldEntity.TotalVoidAmount = currentCancelledCollections.Sum(d => d.Amount);
            }

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
                                    d.MstItem.MstTax1.Rate > 0 ?
                                        (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                                : d.MstTax.Rate > 0 ?
                                        (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                            ) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (
                                d.MstTax.Code == "EXEMPTVAT" ?
                                    d.MstItem.MstTax1.Rate > 0 ?
                                        (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                                : d.MstTax.Rate > 0 ?
                                        (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                            ) * currentDeclareRate
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

            String _totalAccumulatedGrossSales = totalAccumulatedGrossSales.ToString("#,##0.00");
            String _totalAccumulatedRegularDiscount = totalAccumulatedRegularDiscount.ToString("#,##0.00");
            String _totalAccumulatedSeniorCitizenDiscount = totalAccumulatedSeniorCitizenDiscount.ToString("#,##0.00");
            String _totalAccumulatedPWDDiscount = totalAccumulatedPWDDiscount.ToString("#,##0.00");
            String _totalAccumulatedSalesReturn = totalAccumulatedSalesReturn.ToString("#,##0.00");

            Decimal _totalAccumulatedPreviousNetSales = Convert.ToDecimal(_totalAccumulatedGrossSales) -
                                                    Convert.ToDecimal(_totalAccumulatedRegularDiscount) -
                                                    Convert.ToDecimal(_totalAccumulatedSeniorCitizenDiscount) -
                                                    Convert.ToDecimal(_totalAccumulatedPWDDiscount) -
                                                    (Convert.ToDecimal(_totalAccumulatedSalesReturn) * -1);

            repMegaWorldEntity.OldTotalAccumulated = _totalAccumulatedPreviousNetSales;
            repMegaWorldEntity.NewTotalAccumulated = repMegaWorldEntity.TotalNetSalesAmount + repMegaWorldEntity.OldTotalAccumulated;
            repMegaWorldEntity.TotalSalesPerSalesType = repMegaWorldEntity.TotalNetSalesAmount;

            var firstCollection = from d in db.TrnCollections
                                  where d.IsLocked == true
                                  select d;

            if (firstCollection.Any())
            {
                Double totalDays = (filterDate - firstCollection.FirstOrDefault().CollectionDate).TotalDays + 1;
                repMegaWorldEntity.ControlNumber = totalDays.ToString();
            }


            megaWorldEntity = repMegaWorldEntity;
        }


        public void createTextFile()
        {
            try
            {
                var dataSource = megaWorldEntity;
                String tCode = dataSource.TenantCode.Remove(dataSource.TenantCode.Length - 4);
                String currentTerminal = dataSource.Terminal.Substring(1);
                String batchNumber = "1";
                String month = getMonth(Convert.ToInt32(dataSource.Date.Month)).Replace("/", "");
                String day = dataSource.Date.Day.ToString("00");
                var filename = @"C:\MegaWorld\";
                foreach (string files in Directory.GetFiles(filename, "S" + tCode + currentTerminal + batchNumber + "*." + month + day))
                {
                    if (files.Any())
                    {
                        string lastFile = files;
                        string filepath = lastFile.Substring(20, 1);
                        Int32 newBatchnumber = Convert.ToInt32(filepath) + 1;
                        batchNumber = Convert.ToString(newBatchnumber);
                    }
                }
                String path = @"C:\MegaWorld\" + "S" + tCode + currentTerminal + batchNumber + "." + month + day;
                StreamWriter file = new StreamWriter(path);

                file.WriteLine("01" + dataSource.TenantCode);
                file.WriteLine("02" + FillLeadingZeroes(Convert.ToInt32(dataSource.Terminal), 4));
                file.WriteLine("03" + filterDate.ToShortDateString().Replace("/", ""));
                file.WriteLine("04" + dataSource.OldTotalAccumulated.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("05" + dataSource.NewTotalAccumulated.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("06" + dataSource.TotalGrossSalesAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("07" + dataSource.TotalNonTaxableSalesAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("08" + dataSource.TotalSeniorPWDDiscount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("09" + dataSource.TotalOtherDiscount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("10" + dataSource.TotalRefundAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("11" + dataSource.TotalVATAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("12" + dataSource.TotalServiceChargeAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("13" + dataSource.TotalNetSalesAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("14" + dataSource.TotalCashSalesAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("15" + dataSource.TotalCreditDebitAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("16" + dataSource.TotalOtherPaymentAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("17" + dataSource.TotalVoidAmount.ToString("#,##0.00").Replace(",", "").Replace(".", ""));
                file.WriteLine("18" + dataSource.TotalCustomerCount.ToString());
                file.WriteLine("19" + dataSource.ControlNumber);
                file.WriteLine("20" + dataSource.TotalOfSalesTransaction.ToString());
                file.WriteLine("21" + dataSource.SalesType);
                file.WriteLine("22" + dataSource.TotalSalesPerSalesType.ToString("#,##0.00").Replace(",", "").Replace(".", ""));

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void createHourlyTextFile()
        {
            try
            {
                Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());
                var dataSource = megaWorldEntity;

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

                String tCode = dataSource.TenantCode.Remove(dataSource.TenantCode.Length - 4);
                String currentTerminal = dataSource.Terminal.Substring(1);
                String batchNumber = "1";
                String month = getMonth(Convert.ToInt32(dataSource.Date.Month)).Replace("/", "");
                String day = dataSource.Date.Day.ToString("00");
                var filename = @"C:\MegaWorld\";
                foreach (string files in Directory.GetFiles(filename, "H" + tCode + currentTerminal + batchNumber + "*." + month + day))
                {
                    if (files.Any())
                    {
                        string lastFile = files;
                        string filepath = lastFile.Substring(20, 1);
                        Int32 newBatchnumber = Convert.ToInt32(filepath) + 1;
                        batchNumber = Convert.ToString(newBatchnumber);
                    }
                }
                String path = @"C:\MegaWorld\" + "H" + tCode + currentTerminal + batchNumber + "." + month + day;
                StreamWriter file = new StreamWriter(path);

                file.WriteLine("01" + dataSource.TenantCode);
                file.WriteLine("02" + FillLeadingZeroes(Convert.ToInt32(dataSource.Terminal), 4));
                file.WriteLine("03" + filterDate.ToShortDateString().Replace("/", ""));

                List<Entities.TrnSalesLineEntity> rowList = new List<Entities.TrnSalesLineEntity>();

                var listSalesInvoices = from d in db.TrnSalesLines
                                        where d.TrnSale.TrnCollections.Any() == true
                                        && d.TrnSale.TrnCollections.Where(
                                            c => c.TerminalId == filterTerminalId &&
                                                 c.CollectionDate == filterDate &&
                                                 c.IsLocked == true &&
                                                 c.IsCancelled == false &&
                                                 c.SalesId != null).Any() == true
                                        && d.TrnSale.IsLocked == true
                                        && d.TrnSale.IsCancelled == false
                                        && d.TrnSale.IsTendered == true
                                        select new Entities.TrnSalesLineEntity
                                        {
                                            Id = d.Id,
                                            SalesId = d.SalesId,
                                            ItemId = d.ItemId,
                                            ItemDescription = d.MstItem.ItemDescription,
                                            ItemKitchen = d.MstItem.DefaultKitchenReport,
                                            UnitId = d.UnitId,
                                            Unit = d.MstUnit.Unit,
                                            Price = d.Price,
                                            DiscountId = d.DiscountId,
                                            Discount = d.MstDiscount.Discount,
                                            DiscountRate = d.DiscountRate,
                                            DiscountAmount = d.DiscountAmount,
                                            NetPrice = d.NetPrice,
                                            Quantity = d.Quantity,
                                            Amount = d.Amount,
                                            TaxId = d.TaxId,
                                            Tax = d.MstTax.Tax,
                                            TaxRate = d.TaxRate,
                                            TaxAmount = d.TaxAmount,
                                            SalesAccountId = d.SalesAccountId,
                                            AssetAccountId = d.AssetAccountId,
                                            CostAccountId = d.CostAccountId,
                                            TaxAccountId = d.TaxAccountId,
                                            SalesLineTimeStamp = d.SalesLineTimeStamp.ToShortTimeString(),
                                            UserId = d.UserId,
                                            Preparation = d.Preparation,
                                            IsPrepared = d.IsPrepared,
                                            Price1 = d.Price1,
                                            Price2 = d.Price2,
                                            Price2LessTax = d.Price2LessTax,
                                            PriceSplitPercentage = d.PriceSplitPercentage,
                                            TableId = d.TrnSale.TableId,
                                            TableCode = d.TrnSale.TableId != null ? d.TrnSale.MstTable.TableCode : "",
                                            IsPrinted = d.IsPrinted,
                                            Hour = d.TrnSale.UpdateDateTime.Hour,
                                            Minute = d.TrnSale.UpdateDateTime.Minute,
                                            OutTaxRate = d.MstItem.MstTax1.Rate,
                                            TaxCode = d.MstTax.Code,
                                            IsReturned = d.TrnSale.IsReturned,
                                            CustomerCount = d.TrnSale.Pax.GetValueOrDefault(0)
                                        };
                rowList = listSalesInvoices.ToList();


                IEnumerable<IGrouping<Int32, Entities.TrnSalesLineEntity>> hourlyGroup = listSalesInvoices.GroupBy(x => x.Hour);
                IEnumerable<Entities.TrnSalesLineEntity> salesLine = hourlyGroup.SelectMany(group => group);
                List<Entities.TrnSalesLineEntity> newList = salesLine.ToList();

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
                Int32 totalSalesTransactionPerHour = 0;
                Int32 totalCustomerCountPerHoour = 0;

                if (hourlyGroup.Any()) 
                {
                    foreach (var hourlyGroupSales in hourlyGroup)
                    {
                        var hourlySalesLinesQuery = from d in hourlyGroupSales
                                                    select d;
                        if (hourlySalesLinesQuery.Any())
                        {
                            var salesLines = hourlySalesLinesQuery.ToArray();

                            totalGrossSales = salesLines.Sum(d => d.Price * d.Quantity);
                            totalSalesTransactionPerHour = salesLines.GroupBy(x => x.Id).Count();
                            totalCustomerCountPerHoour = salesLines.GroupBy(x => x.CustomerCount).Count();

                            totalNetGrossSales = salesLines.Sum(d => d.NetPrice * d.Quantity);

                            totalRegularDiscount = salesLines.Sum(d =>
                                d.Discount != "Senior Citizen Discount" && d.Discount != "PWD" ? ((d.Price * d.Quantity) * (d.DiscountRate / 100)) : 0
                            );

                            totalSeniorCitizenDiscount = salesLines.Sum(d =>
                                d.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0
                            );

                            totalPWDDiscount = salesLines.Sum(d =>
                                d.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0
                            );

                            totalVATSales = salesLines.Sum(d =>
                               d.TaxCode == "VAT" && (d.Discount != "Senior Citizen Discount" || d.Discount != "PWD") ? ((d.Price * d.Quantity) - d.TaxAmount) : 0
                            );

                            totalVATAmount = salesLines.Sum(d =>
                                d.TaxCode == "VAT" ? d.TaxAmount : 0
                            );

                            totalNonVATSales = salesLines.Sum(d =>
                                d.TaxCode == "NONVAT" ? d.Amount : 0
                            );

                            totalVATExemptSales = salesLines.Sum(d =>
                                d.TaxCode == "EXEMPTVAT" && (d.Discount == "Senior Citizen Discount" || d.Discount == "PWD") ? ((d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.OutTaxRate / 100)) * (d.OutTaxRate / 100))) - d.DiscountAmount : 0
                            );

                            totalVATZeroRatedSales = salesLines.Sum(d =>
                                d.TaxCode == "ZEROVAT" ? d.Amount : 0
                            );

                            Decimal VATSalesReturn = 0;
                            Decimal VATAmountSalesReturn = 0;
                            Decimal VATExemptSalesReturn = 0;
                            Decimal VATAmountExemptSalesReturn = 0;

                            VATSalesReturn = salesLines.Where(d => d.IsReturned == true).Sum(d =>
                                      d.TaxCode == "VAT" ? d.Amount : 0
                                  );

                            VATAmountSalesReturn = salesLines.Where(d => d.IsReturned == true).Sum(d =>
                                d.TaxCode == "VAT" ? d.TaxAmount : 0
                            ) * -1;

                            VATExemptSalesReturn = salesLines.Where(d => d.IsReturned == true).Sum(d =>
                                d.TaxCode == "EXEMPTVAT" ? d.Amount : 0
                            );

                            VATAmountExemptSalesReturn = salesLines.Where(d => d.IsReturned == true).Sum(d =>
                                d.TaxCode == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.OutTaxRate / 100)) * (d.OutTaxRate / 100)) : d.TaxAmount
                            ) * -1;

                            totalSalesReturn = (VATSalesReturn + VATExemptSalesReturn);

                            String _totalNonTaxableSales = (totalNonTaxableSales * currentDeclareRate).ToString("#,##0.00");
                            String _totalNetGrossSales = (totalNetGrossSales * currentDeclareRate).ToString("#,##0.00");
                            String _totalGrossSales = (totalGrossSales * currentDeclareRate).ToString("#,##0.00");
                            String _totalRegularDiscount = (totalRegularDiscount * currentDeclareRate).ToString("#,##0.00");
                            String _totalSeniorCitizenDiscount = (totalSeniorCitizenDiscount * currentDeclareRate).ToString("#,##0.00");
                            String _totalPWDDiscount = (totalPWDDiscount * currentDeclareRate).ToString("#,##0.00");
                            String _totalSalesReturn = (totalSalesReturn * currentDeclareRate).ToString("#,##0.00");


                            Decimal TotalHourlyNetSalesAmount = Convert.ToDecimal(_totalGrossSales) -
                                                                    Convert.ToDecimal(_totalRegularDiscount) -
                                                                    Convert.ToDecimal(_totalSeniorCitizenDiscount) -
                                                                    Convert.ToDecimal(_totalPWDDiscount) -
                                                                    (Convert.ToDecimal(_totalSalesReturn) * -1);
                            megaWorldEntity.TotalHourlyNetSalesAmount = TotalHourlyNetSalesAmount;

                            Decimal TotalVATSales = totalVATSales - (VATSalesReturn * -1);
                            //repMegaWorldEntity.TotalVATAmount = totalVATAmount - VATAmountSalesReturn - VATAmountExemptSalesReturn;
                            Decimal TotalNonVAT = totalNonVATSales;
                            Decimal TotalVATExempt = totalVATExemptSales - (VATExemptSalesReturn * -1);
                            Decimal TotalVATZeroRated = totalVATZeroRatedSales;
                            file.WriteLine("04" + getHourCode(hourlyGroupSales.FirstOrDefault().Hour, hourlyGroupSales.FirstOrDefault().Hour));
                            file.WriteLine("05" + dataSource.TotalHourlyNetSalesAmount.ToString("#,##0.00").Replace(".", "").Replace(",",""));
                            file.WriteLine("06" + totalSalesTransactionPerHour);
                            file.WriteLine("07" + totalCustomerCountPerHoour);
                        }
                    }
                }
                else
                {
                    file.WriteLine("0400");
                    file.WriteLine("05000");
                    file.WriteLine("060");
                    file.WriteLine("070");
                }
                file.WriteLine("08" + dataSource.TotalNetSalesAmount);
                file.WriteLine("09" + dataSource.TotalOfSalesTransaction);
                file.WriteLine("10" + dataSource.TotalCustomerCount);

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CreateDiscountFile()
        {
            try
            {
                Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

                var dataSource = megaWorldEntity;
                String tCode = dataSource.TenantCode.Remove(dataSource.TenantCode.Length - 4);
                String currentTerminal = dataSource.Terminal.Substring(1);
                String batchNumber = "1";
                String month = getMonth(Convert.ToInt32(dataSource.Date.Month)).Replace("/", "");
                String day = dataSource.Date.Day.ToString("00");
                var filename = @"C:\MegaWorld\";
                foreach (string files in Directory.GetFiles(filename, "D" + tCode + currentTerminal + batchNumber + "*." + month + day))
                {
                    if (files.Any())
                    {
                        string lastFile = files;
                        string filepath = lastFile.Substring(20, 1);
                        Int32 newBatchnumber = Convert.ToInt32(filepath) + 1;
                        batchNumber = Convert.ToString(newBatchnumber);
                    }
                }
                String path = @"C:\MegaWorld\" + "D" + tCode + currentTerminal + batchNumber + "." + month + day;

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
                StringBuilder csv = new StringBuilder();

                if (currentCollectionSalesLineQuery.Any())
                {
                    var salesLinesQuery = from d in currentCollectionSalesLineQuery
                                          where d.Quantity > 0
                                          && d.MstDiscount.Discount != "Zero Discount"
                                          group d by new
                                          {
                                              d.MstDiscount.DiscountCode,
                                              d.MstDiscount.Discount,
                                          } into g
                                          select new
                                          {
                                              g.Key.DiscountCode,
                                              g.Key.Discount,
                                              DiscountAmount = g.Sum(s => s.DiscountAmount != null ? s.DiscountAmount : 0)
                                          };

                    if (salesLinesQuery.Any())
                    {
                        var sales = salesLinesQuery.ToArray();

                        foreach (var salesDetail in salesLinesQuery)
                        {
                            String[] data = {
                                salesDetail.DiscountCode,
                                salesDetail.Discount,
                                salesDetail.DiscountAmount.ToString("#,##0.00"),
                            };
                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                }

                String executingUser = WindowsIdentity.GetCurrent().Name;

                DirectorySecurity securityRules = new DirectorySecurity();
                securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(@"C:\MegaWorld\", securityRules);
                File.WriteAllText(path, csv.ToString(), Encoding.GetEncoding("iso-8859-1"));
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
            createTextFile();
            createHourlyTextFile();
            CreateDiscountFile();
        }
    }
}

