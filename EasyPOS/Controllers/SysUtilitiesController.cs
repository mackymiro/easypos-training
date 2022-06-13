using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class SysUtilitiesController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // =====================
        // Truncate Transactions
        // =====================
        public String[] TruncateTransaction()
        {
            try
            {
                var disbursements = from d in db.TrnDisbursements
                                    select d;

                if (disbursements.Any())
                {
                    var deleteDisbursements = disbursements;
                    db.TrnDisbursements.DeleteAllOnSubmit(deleteDisbursements);
                    db.SubmitChanges();
                }


                var stockIns = from d in db.TrnStockIns
                               select d;

                if (stockIns.Any())
                {
                    var deleteStockIns = stockIns;
                    db.TrnStockIns.DeleteAllOnSubmit(deleteStockIns);
                    db.SubmitChanges();
                }

                var collections = from d in db.TrnCollections
                                  select d;

                if (collections.Any())
                {
                    var deleteCollection = collections;
                    db.TrnCollections.DeleteAllOnSubmit(deleteCollection);
                    db.SubmitChanges();
                }

                var stockOuts = from d in db.TrnStockOuts
                                select d;

                if (stockOuts.Any())
                {
                    var deleteStockOuts = stockOuts;
                    db.TrnStockOuts.DeleteAllOnSubmit(deleteStockOuts);
                    db.SubmitChanges();
                }

                var stockCounts = from d in db.TrnStockCounts
                                  select d;

                if (stockCounts.Any())
                {
                    var deleteStockCounts = stockCounts;
                    db.TrnStockCounts.DeleteAllOnSubmit(deleteStockCounts);
                    db.SubmitChanges();
                }

                var creditMemos = from d in db.TrnDebitCreditMemos
                                  select d;

                if (creditMemos.Any())
                {
                    var deleteCreditMemos = creditMemos;
                    db.TrnDebitCreditMemos.DeleteAllOnSubmit(deleteCreditMemos);
                    db.SubmitChanges();
                }

                var purchaseOrders = from d in db.TrnPurchaseOrders
                                     select d;

                if (purchaseOrders.Any())
                {
                    var deletePurchaseOrders = purchaseOrders;
                    db.TrnPurchaseOrders.DeleteAllOnSubmit(deletePurchaseOrders);
                    db.SubmitChanges();
                }
 
                var sales = from d in db.TrnSales
                            select d;

                if (sales.Any())
                {
                    var deleteSale = sales;
                    db.TrnSales.DeleteAllOnSubmit(deleteSale);
                    db.SubmitChanges();
                }
                var salesLine = from d in db.TrnSalesLines
                            select d;

                if (salesLine.Any())
                {
                    var deleteSalesLine = salesLine;
                    db.TrnSalesLines.DeleteAllOnSubmit(deleteSalesLine);
                    db.SubmitChanges();
                }

                var items = from d in db.MstItems
                            select d;

                if (items.Any())
                {
                    var UpdateItem = items;
                    foreach (var item in items)
                    {
                        item.OnhandQuantity = 0;
                        db.SubmitChanges();
                    }
                }

                var sysAuditTrails = from d in db.SysAuditTrails
                                     select d;

                if (sysAuditTrails.Any())
                {
                    var deleteSysAuditTrails = sysAuditTrails;
                    db.SysAuditTrails.DeleteAllOnSubmit(deleteSysAuditTrails);
                    db.SubmitChanges();
                }

                var rlcSysAuditTrail = from d in db.SysRLCAuditTrails
                                       select d;
                if (rlcSysAuditTrail.Any())
                {
                    var deleteSysRLCAuditTrail = rlcSysAuditTrail;
                    db.SysRLCAuditTrails.DeleteAllOnSubmit(deleteSysRLCAuditTrail);
                    db.SubmitChanges();
                }
                return new String[] { "", "" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        public String[] UpdateInventory(Int32 itemId)
        {
            try
            {
                if (itemId == 0)
                {
                    var getSalesLineOutQuantity = from d in db.TrnSalesLines
                                                  where d.MstItem.IsInventory == true
                                                  && d.MstItem.IsLocked == true
                                                  && d.TrnSale.IsTendered == true
                                                  && d.TrnSale.IsCancelled == false
                                                  group d by new
                                                  {
                                                      d.ItemId,
                                                      d.UnitId
                                                  } into g
                                                  select new
                                                  {
                                                      g.Key.ItemId,
                                                      g.Key.UnitId,
                                                      Quanity = g.Sum(s => s.Quantity * -1)
                                                  };

                    var getStockInQuantity = from d in db.TrnStockInLines
                                             where d.MstItem.IsInventory == true
                                             && d.MstItem.IsLocked == true
                                             && d.TrnStockIn.IsLocked == true
                                             group d by new
                                             {
                                                 d.ItemId,
                                                 d.UnitId
                                             } into g
                                             select new
                                             {
                                                 g.Key.ItemId,
                                                 g.Key.UnitId,
                                                 Quanity = g.Sum(s => s.Quantity)
                                             };

                    var getStockOutQuantity = from d in db.TrnStockOutLines
                                              where d.MstItem.IsInventory == true
                                              && d.MstItem.IsLocked == true
                                              && d.TrnStockOut.IsLocked == true
                                              group d by new
                                              {
                                                  d.ItemId,
                                                  d.UnitId
                                              } into g
                                              select new
                                              {
                                                  g.Key.ItemId,
                                                  g.Key.UnitId,
                                                  Quanity = g.Sum(s => s.Quantity * -1)
                                              };

                    var getMstItemComponentOutQuantity = from d in db.TrnSalesLines
                                                         where d.MstItem.IsInventory == true
                                                         && d.MstItem.IsLocked == true
                                                         && d.TrnSale.IsTendered == true
                                                         && d.TrnSale.IsCancelled == false
                                                         && d.ItemId == d.MstItem.MstItemComponents.FirstOrDefault().ComponentItemId
                                                         select d;


                    var getMstItemComponentOutQuantitys = from d in getMstItemComponentOutQuantity
                                                          group d by new
                                                          {
                                                              d.ItemId,
                                                              d.UnitId
                                                          } into g
                                                          select new
                                                          {
                                                              g.Key.ItemId,
                                                              g.Key.UnitId,
                                                              Quanity = g.Sum(s => (s.Quantity * s.MstItem.MstItemComponents.FirstOrDefault().Quantity) * -1)
                                                          };
                    var UnionAllQuantity = getSalesLineOutQuantity.Union(getStockInQuantity.Union(getStockInQuantity.Union(getStockOutQuantity.Union(getMstItemComponentOutQuantitys))));
                    if (UnionAllQuantity.Any())
                    {
                        var updateAllUnionQuantities = from d in UnionAllQuantity
                                                       group d by new
                                                       {
                                                           d.ItemId,
                                                           d.UnitId,
                                                       } into g
                                                       select new
                                                       {
                                                           g.Key.ItemId,
                                                           g.Key.UnitId,
                                                           Quantity = g.Sum(s => s.Quanity)
                                                       };

                        foreach (var updateAllUnionQuantity in updateAllUnionQuantities)
                        {
                            var mstItem = from d in db.MstItems
                                          where d.Id == updateAllUnionQuantity.ItemId
                                          select d;

                            var updateOnhandQuantity = mstItem;
                            updateOnhandQuantity.FirstOrDefault().OnhandQuantity = updateAllUnionQuantity.Quantity;
                            db.SubmitChanges();
                        }
                    }

                    return new String[] { "", "" };
                }
                else
                {
                    var getSalesLineOutQuantity = from d in db.TrnSalesLines
                                                  where d.MstItem.IsInventory == true
                                                  && d.MstItem.IsLocked == true
                                                  && d.TrnSale.IsTendered == true
                                                  && d.TrnSale.IsCancelled == false
                                                  && d.ItemId == itemId
                                                  group d by new
                                                  {
                                                      d.ItemId,
                                                      d.UnitId
                                                  } into g
                                                  select new
                                                  {
                                                      g.Key.ItemId,
                                                      g.Key.UnitId,
                                                      Quanity = g.Sum(s => s.Quantity * -1)
                                                  };

                    var getStockInQuantity = from d in db.TrnStockInLines
                                             where d.MstItem.IsInventory == true
                                             && d.MstItem.IsLocked == true
                                             && d.TrnStockIn.IsLocked == true
                                              && d.ItemId == itemId
                                             group d by new
                                             {
                                                 d.ItemId,
                                                 d.UnitId
                                             } into g
                                             select new
                                             {
                                                 g.Key.ItemId,
                                                 g.Key.UnitId,
                                                 Quanity = g.Sum(s => s.Quantity)
                                             };

                    var getStockOutQuantity = from d in db.TrnStockOutLines
                                              where d.MstItem.IsInventory == true
                                              && d.MstItem.IsLocked == true
                                              && d.TrnStockOut.IsLocked == true
                                              && d.ItemId == itemId
                                              group d by new
                                              {
                                                  d.ItemId,
                                                  d.UnitId
                                              } into g
                                              select new
                                              {
                                                  g.Key.ItemId,
                                                  g.Key.UnitId,
                                                  Quanity = g.Sum(s => s.Quantity * -1)
                                              };

                    var getMstItemComponentOutQuantity = from d in db.TrnSalesLines
                                                         where d.MstItem.IsInventory == true
                                                         && d.MstItem.IsLocked == true
                                                         && d.TrnSale.IsTendered == true
                                                         && d.TrnSale.IsCancelled == false
                                                         && d.ItemId == d.MstItem.MstItemComponents.FirstOrDefault().ComponentItemId
                                                         select d;


                    var getMstItemComponentOutQuantitys = from d in getMstItemComponentOutQuantity
                                                          where d.ItemId == itemId
                                                          group d by new
                                                          {
                                                              d.ItemId,
                                                              d.UnitId
                                                          } into g
                                                          select new
                                                          {
                                                              g.Key.ItemId,
                                                              g.Key.UnitId,
                                                              Quanity = g.Sum(s => (s.Quantity * s.MstItem.MstItemComponents.FirstOrDefault().Quantity) * -1)
                                                          };
                    var UnionAllQuantity = getSalesLineOutQuantity.Union(getStockInQuantity.Union(getStockInQuantity.Union(getStockOutQuantity.Union(getMstItemComponentOutQuantitys))));
                    if (UnionAllQuantity.Any())
                    {
                        var updateAllUnionQuantity = from d in UnionAllQuantity
                                                     group d by new
                                                     {
                                                         d.ItemId,
                                                         d.UnitId,
                                                     } into g
                                                     select new
                                                     {
                                                         g.Key.ItemId,
                                                         g.Key.UnitId,
                                                         Quantity = g.Sum(s => s.Quanity)
                                                     };


                        var mstItem = from d in db.MstItems
                                      where d.Id == itemId
                                      select d;

                        var updateOnhandQuantities = mstItem;
                        updateOnhandQuantities.FirstOrDefault().OnhandQuantity = updateAllUnionQuantity.FirstOrDefault().Quantity;
                        db.SubmitChanges();

                    }
                    else
                    {
                        var mstItems = from d in db.MstItems
                                       where d.Id == itemId
                                       select d;
                        if (mstItems.Any())
                        {
                            var updateOnHandQuantity = mstItems;
                            updateOnHandQuantity.FirstOrDefault().OnhandQuantity = 0;
                            db.SubmitChanges();
                        }
                    }
                }
                return new String[] { "", "" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
