using System;
using DataLayer.Models;
using DataLayer.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace DataLayer.Services
{

    public class DataService (AppDbContext context) : IDataService
    {
        public async Task<List<FiscalInfo>> GetAllFiscalInfosAsync()
        {
            return await context.FiscalInfos.ToListAsync();
        }

        public async Task AddFiscalInfoAsync(FiscalInfo fiscalInfo)
        {
            context.FiscalInfos.Add(fiscalInfo);
            await context.SaveChangesAsync();
        }

        // Methods for ZraInvoice
        public async Task<List<ZraInvoice>> GetZraInvoicesAsync()
        {
            var invoices = await context.ZraInvoices
                .FromSqlRaw("SELECT * FROM ZraInvoice")
                .ToListAsync();

            foreach (var invoice in invoices)
            {
                var dbInvoices = await GetInvoiceItemsAsync(invoice.Id);
                if (dbInvoices.Count > 0)
                    invoice.Items = dbInvoices.ToList();
            }

            return invoices;
        }

        public async Task<List<ZraInvoiceItem>> GetInvoiceItemsAsync(string refId)
        {
            return await context.ZraInvoiceItems
                .FromSqlRaw("EXEC GetZraInvoiceItem @RefId={0}", refId)
                .ToListAsync();
        }

        public async Task<List<ZraPurchaseItem>> GetPurchaseItemsAsync(string refId)
        {
            return await context.ZraPurchaseItems
                .FromSqlRaw("EXEC GetZraPurchaseItem @RefId={0}", refId)
                .ToListAsync();
        }

        // Methods for PurchaseInfo
        public async Task<List<PurchaseInfo>> GetAllPurchasesAsync()
        {
            return await context.PurchaseInfos
                .FromSqlRaw("SELECT * FROM PurchaseInfo")
                .ToListAsync();
        }

        public async Task<int> UpdateFiscalDetailsAsync(byte[] qrCodeBinary, string internalData, string invoiceNumber, string invoiceType, string invoiceSequence, string signature, string vsdcDate)
        {
            var parameters = new[]
            {
                new SqlParameter("@QrCode", qrCodeBinary),
                new SqlParameter("@InternalData", internalData),
                new SqlParameter("@InvNumber", invoiceNumber),
                new SqlParameter("@InvoiceType", invoiceType),
                new SqlParameter("@InvoiceSequence", invoiceSequence),
                new SqlParameter("@Signature", signature),
                new SqlParameter("@VsdcDate", vsdcDate)
            };

            return await context.Database.ExecuteSqlRawAsync("EXEC UpdateFiscalDetails @Signature, @InternalData, @InvNumber, @InvoiceType, @InvoiceSequence, @QrCode, @VsdcDate", parameters);
        }

        public async Task<List<ZraStockMaster>> GetStockMastersAsync()
        {
            var masters = await context.ZraStockMasters
                .FromSqlRaw("SELECT * FROM ZraStockMaster")
                .ToListAsync();

            // foreach (var master in masters)
            // {
            //     var dbInvoices = await GetInvoiceItemsAsync(master.ItemCode);
            //     if (dbInvoices.Count > 0)
            //         master.Items = dbInvoices.ToList();
            // }

            return masters;
        }

        public async Task<List<DeviceInit>> GetAllDeviceInitsAsync()
        {
            var deviceInits = await context.DeviceInits
                .FromSqlRaw("SELECT * FROM DeviceInit")
                .ToListAsync();
            return deviceInits;
        }
        public async Task<int> SetDeviceInitsAsync(DeviceInit deviceInit)
        {
            var parameters = new[]
            {
                new SqlParameter("@resultCd", deviceInit.ResultCd),
                new SqlParameter("@resultMsg", deviceInit.ResultMsg),
                new SqlParameter("@resultDt", deviceInit.ResultDt),
                new SqlParameter("@tpin", deviceInit.Tpin),
                new SqlParameter("@taxprNm", deviceInit.TaxprNm),
                new SqlParameter("@bsnsActv", deviceInit.BsnsActv),
                new SqlParameter("@bhfId", deviceInit.BhfId),
                new SqlParameter("@bhfNm", deviceInit.BhfNm),
                new SqlParameter("@bhfOpenDt", deviceInit.BhfOpenDt),
                new SqlParameter("@prvncNm", deviceInit.PrvncNm),
                new SqlParameter("@dstrtNm", deviceInit.DstrtNm),
                new SqlParameter("@sctrNm", deviceInit.SctrNm),
                new SqlParameter("@locDesc", deviceInit.LocDesc),
                new SqlParameter("@hqYn", deviceInit.HqYn),
                new SqlParameter("@mgrNm", deviceInit.MgrNm),
                new SqlParameter("@mgrTelNo", deviceInit.MgrTelNo),
                new SqlParameter("@mgrEmail", deviceInit.MgrEmail),
                new SqlParameter("@sdicId", deviceInit.SdicId),
                new SqlParameter("@mrcNo", deviceInit.MrcNo),
                new SqlParameter("@lastSaleInvcNo", deviceInit.LastSaleInvcNo.HasValue ? (object)deviceInit.LastSaleInvcNo.Value : DBNull.Value),
                new SqlParameter("@lastPchsInvcNo", deviceInit.LastPchsInvcNo.HasValue ? (object)deviceInit.LastPchsInvcNo.Value : DBNull.Value),
                new SqlParameter("@lastSaleRcptNo", deviceInit.LastSaleRcptNo.HasValue ? (object)deviceInit.LastSaleRcptNo.Value : DBNull.Value),
                new SqlParameter("@lastInvcNo", deviceInit.LastInvcNo.HasValue ? (object)deviceInit.LastInvcNo.Value : DBNull.Value),
                new SqlParameter("@lastTrainInvcNo", deviceInit.LastTrainInvcNo.HasValue ? (object)deviceInit.LastTrainInvcNo.Value : DBNull.Value),
                new SqlParameter("@lastProfrmInvcNo", deviceInit.LastProfrmInvcNo.HasValue ? (object)deviceInit.LastProfrmInvcNo.Value : DBNull.Value),
                new SqlParameter("@lastCopyInvcNo", deviceInit.LastCopyInvcNo.HasValue ? (object)deviceInit.LastCopyInvcNo.Value : DBNull.Value)
            };

            return await context.Database.ExecuteSqlRawAsync("EXEC UpdateDeviceDetails @resultCd, @resultMsg, @resultDt, @tpin, @taxprNm, @bsnsActv, @bhfId, @bhfNm, @bhfOpenDt, @prvncNm, @dstrtNm, @sctrNm, @locDesc, @hqYn, @mgrNm, @mgrTelNo, @mgrEmail, @sdicId, @mrcNo, @lastSaleInvcNo, @lastPchsInvcNo, @lastSaleRcptNo, @lastInvcNo, @lastTrainInvcNo, @lastProfrmInvcNo, @lastCopyInvcNo", parameters);
        }

        public async Task<List<ZraSelectCode>> GetAllZraSelectCodesAsync()
        {
            var zraCodes = await context.ZraSelectCodes
                .FromSqlRaw("SELECT * FROM ZRAStandardCodes")
                .ToListAsync();
            return zraCodes;
        }

        public async Task<int> SetZraSelectCodesAsync(ZraSelectCode zraSelectCode)
        {
            var parameters = new[]
            {
                new SqlParameter("@resultDt", string.IsNullOrEmpty(zraSelectCode.ResultDt) ? DateTime.Now.ToString("yyyyMMddHHmmss") : zraSelectCode.ResultDt),
                new SqlParameter("@cdCls", zraSelectCode.CdCls),
                new SqlParameter("@cdClsNm", zraSelectCode.CdClsNm),
                new SqlParameter("@cd", zraSelectCode.Cd),
                new SqlParameter("@cdNm", zraSelectCode.CdNm),
                new SqlParameter("@userDfnNm1", string.IsNullOrEmpty(zraSelectCode.UserDfnNm1) ? "": zraSelectCode.UserDfnNm1)
            };

            return await context.Database.ExecuteSqlRawAsync("EXEC UpdateZRAStandardCodes @resultDt, @cdCls, @cdClsNm, @cd, @cdNm, @userDfnNm1", parameters);
        }

        public async Task<List<ZraClassCode>> GetAllZraClassCodesAsync()
        {
            var zraCodes = await context.ZraClassCodes
                .FromSqlRaw("SELECT * FROM ZRAClassCodes")
                .ToListAsync();
            return zraCodes;
        }

        public async Task<int> SetZraClassCodeAsync(ZraClassCode zraClassCodes)
        {
            var parameters = new[]
            {
                new SqlParameter("@resultDt", string.IsNullOrEmpty(zraClassCodes.ResultDt) ? DateTime.Now.ToString("yyyyMMddHHmmss") : zraClassCodes.ResultDt),
                new SqlParameter("@temClsCd", zraClassCodes.TemClsCd),
                new SqlParameter("@itemClsNm", zraClassCodes.ItemClsNm),
                new SqlParameter("@itemClsLvl", zraClassCodes.ItemClsLvl),
                new SqlParameter("@taxTyCd", zraClassCodes.TaxTyCd ?? (object)DBNull.Value),
                new SqlParameter("@mjrTgYn", zraClassCodes.MjrTgYn ?? (object)DBNull.Value),
                new SqlParameter("@useYn", zraClassCodes.UseYn ?? (object)DBNull.Value)
            };

            return await context.Database.ExecuteSqlRawAsync("EXEC UpdateZRAClassCodes @resultDt, @temClsCd, @itemClsNm, @itemClsLvl, @taxTyCd, @mjrTgYn, @useYn", parameters);
        }

        public async Task<int> SetImportsAsync(ZraImportData item)
        {
            var parameters = new[]
            {
                new SqlParameter("@taskCd", item.taskCd),
                new SqlParameter("@dclDe", item.dclDe),
                new SqlParameter("@itemSeq", item.itemSeq ?? (object)DBNull.Value),
                new SqlParameter("@dclNo", item.dclNo),
                new SqlParameter("@hsCd", item.hsCd),
                new SqlParameter("@itemNm", item.itemNm),
                new SqlParameter("@orgnNatCd", item.orgnNatCd),
                new SqlParameter("@exptNatCd", item.exptNatCd),
                new SqlParameter("@pkg", item.pkg ?? (object)DBNull.Value),
                new SqlParameter("@pkgUnitCd", item.pkgUnitCd),
                new SqlParameter("@qty", item.qty ?? (object)DBNull.Value),
                new SqlParameter("@qtyUnitCd", item.qtyUnitCd),
                new SqlParameter("@totWt", item.totWt ?? (object)DBNull.Value),
                new SqlParameter("@netWt", item.netWt ?? (object)DBNull.Value),
                new SqlParameter("@spplrNm", item.spplrNm ?? (object)DBNull.Value),
                new SqlParameter("@agntNm", item.agntNm ?? (object)DBNull.Value),
                new SqlParameter("@invcFcurAmt", item.invcFcurAmt ?? (object)DBNull.Value),
                new SqlParameter("@invcFcurCd", item.invcFcurCd),
                new SqlParameter("@invcFcurExcrt", item.invcFcurExcrt ?? (object)DBNull.Value),
                new SqlParameter("@dclRefNum", item.dclRefNum)
            };

            return await context.Database.ExecuteSqlRawAsync("EXEC UpdateZRAImports @taskCd, @dclDe, @itemSeq, @dclNo, @hsCd, @itemNm, @orgnNatCd, @exptNatCd, @pkg, @pkgUnitCd, @qty, @qtyUnitCd, @totWt, @netWt, @spplrNm, @agntNm, @invcFcurAmt, @invcFcurCd, @invcFcurExcrt, @dclRefNum", parameters);
        }

        public async Task<List<ZraPurchase>> GetZraPurchasesAsync()
        {
            var purchases = await context.ZraPurchases
              .FromSqlRaw("SELECT * FROM ZraPurchase")
              .ToListAsync();

            foreach (var purchase in purchases)
            {
                var dbPurchase = await GetPurchaseItemsAsync(purchase.Id);
                if (dbPurchase.Count > 0)
                    purchase.Items = dbPurchase.ToList();
            }

            return purchases;
        }

        public async Task<int> UpdatePurchaseAsync(int invcNo, string message, string resultDt)
        {
            var parameters = new[]
            {
                new SqlParameter("@invcNo", invcNo),
                new SqlParameter("@message", message),
                new SqlParameter("@resultDt", resultDt)
            };

            return await context.Database.ExecuteSqlRawAsync("insert into  PurchaseInfo ( InvoiceNumber,  Message, CreateDate ) values  ( @invcNo,  @message, @resultDt );", parameters);
        }

        public async Task<List<ZraImportData>> GetReceivedImportAsync()
        {
            return await context.ZraImportDatas
                .FromSqlRaw("SELECT * FROM RecievedImports")
                .ToListAsync();
        }

        public async Task<int> SetSmartInvoiceAsync(SmartPurchase smartPurchase)
        {
            if (smartPurchase == null)
            {
                throw new ArgumentNullException(nameof(smartPurchase), "SmartPurchase cannot be null.");
            }

            var parameters = new[]
            {
                new SqlParameter("@spplrTpin", (object)smartPurchase.SpplrTpin ?? DBNull.Value),
                new SqlParameter("@spplrNm", (object)smartPurchase.SpplrNm ?? DBNull.Value),
                new SqlParameter("@spplrBhfId", (object)smartPurchase.SpplrBhfId ?? DBNull.Value),
                new SqlParameter("@spplrInvcNo", smartPurchase.SpplrInvcNo.HasValue ? (object)smartPurchase.SpplrInvcNo.Value : DBNull.Value),
                new SqlParameter("@rcptTyCd", (object)smartPurchase.RcptTyCd ?? DBNull.Value),
                new SqlParameter("@pmtTyCd", (object)smartPurchase.PmtTyCd ?? DBNull.Value),
                new SqlParameter("@cfmDt", (object)smartPurchase.CfmDt ?? DBNull.Value),
                new SqlParameter("@salesDt", (object)smartPurchase.SalesDt ?? DBNull.Value),
                new SqlParameter("@stockRlsDt", (object)smartPurchase.StockRlsDt ?? DBNull.Value),
                new SqlParameter("@totItemCnt", smartPurchase.TotItemCnt.HasValue ? (object)smartPurchase.TotItemCnt.Value : DBNull.Value),
                new SqlParameter("@totTaxblAmt", smartPurchase.TotTaxblAmt.HasValue ? (object)smartPurchase.TotTaxblAmt.Value : DBNull.Value),
                new SqlParameter("@totTaxAmt", smartPurchase.TotTaxAmt.HasValue ? (object)smartPurchase.TotTaxAmt.Value : DBNull.Value),
                new SqlParameter("@totAmt", smartPurchase.TotAmt.HasValue ? (object)smartPurchase.TotAmt.Value : DBNull.Value),
                new SqlParameter("@remark", (object)smartPurchase.Remark ?? DBNull.Value),
                new SqlParameter("@itemSeq", smartPurchase.ItemSeq.HasValue ? (object)smartPurchase.ItemSeq.Value : DBNull.Value),
                new SqlParameter("@itemCd", (object)smartPurchase.ItemCd ?? DBNull.Value),
                new SqlParameter("@itemClsCd", (object)smartPurchase.ItemClsCd ?? DBNull.Value),
                new SqlParameter("@itemNm", (object)smartPurchase.ItemNm ?? DBNull.Value),
                new SqlParameter("@bcd", (object)smartPurchase.Bcd ?? DBNull.Value),
                new SqlParameter("@pkgUnitCd", (object)smartPurchase.PkgUnitCd ?? DBNull.Value),
                new SqlParameter("@pkg", smartPurchase.Pkg.HasValue ? (object)smartPurchase.Pkg.Value : DBNull.Value),
                new SqlParameter("@qtyUnitCd", (object)smartPurchase.QtyUnitCd ?? DBNull.Value),
                new SqlParameter("@qty", smartPurchase.Qty.HasValue ? (object)smartPurchase.Qty.Value : DBNull.Value),
                new SqlParameter("@prc", smartPurchase.Prc.HasValue ? (object)smartPurchase.Prc.Value : DBNull.Value),
                new SqlParameter("@splyAmt", smartPurchase.SplyAmt.HasValue ? (object)smartPurchase.SplyAmt.Value : DBNull.Value),
                new SqlParameter("@dcRt", smartPurchase.DcRt.HasValue ? (object)smartPurchase.DcRt.Value : DBNull.Value),
                new SqlParameter("@dcAm", smartPurchase.DcAm.HasValue ? (object)smartPurchase.DcAm.Value : DBNull.Value),
                new SqlParameter("@vatCatCd", (object)smartPurchase.VatCatCd ?? DBNull.Value),
                new SqlParameter("@iplCatCd", (object)smartPurchase.IplCatCd ?? DBNull.Value),
                new SqlParameter("@tlCatCd", (object)smartPurchase.TlCatCd ?? DBNull.Value),
                new SqlParameter("@exciseTxCatC", (object)smartPurchase.ExciseTxCatC ?? DBNull.Value),
                new SqlParameter("@vatTaxblAmt", smartPurchase.VatTaxblAmt.HasValue ? (object)smartPurchase.VatTaxblAmt.Value : DBNull.Value),
                new SqlParameter("@exciseTaxblAmt", smartPurchase.ExciseTaxblAmt.HasValue ? (object)smartPurchase.ExciseTaxblAmt.Value : DBNull.Value),
                new SqlParameter("@iplTaxblAmt", smartPurchase.IplTaxblAmt.HasValue ? (object)smartPurchase.IplTaxblAmt.Value : DBNull.Value),
                new SqlParameter("@tlTaxblAmt", smartPurchase.TlTaxblAmt.HasValue ? (object)smartPurchase.TlTaxblAmt.Value : DBNull.Value),
                new SqlParameter("@taxblAmt", smartPurchase.TaxblAmt.HasValue ? (object)smartPurchase.TaxblAmt.Value : DBNull.Value),
                new SqlParameter("@vatAmt", smartPurchase.VatAmt.HasValue ? (object)smartPurchase.VatAmt.Value : DBNull.Value),
                new SqlParameter("@iplAmt", smartPurchase.IplAmt.HasValue ? (object)smartPurchase.IplAmt.Value : DBNull.Value),
                new SqlParameter("@tlAmt", smartPurchase.TlAmt.HasValue ? (object)smartPurchase.TlAmt.Value : DBNull.Value),
                new SqlParameter("@exciseTxAmt", smartPurchase.ExciseTxAmt.HasValue ? (object)smartPurchase.ExciseTxAmt.Value : DBNull.Value),
                new SqlParameter("@ttotAmt", smartPurchase.TtotAmt.HasValue ? (object)smartPurchase.TtotAmt.Value : DBNull.Value)
            };
            
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    var result = await context.Database.ExecuteSqlRawAsync(
                        "EXEC dbo.UpdateZRASmartInvoices @spplrTpin, @spplrNm, @spplrBhfId, @spplrInvcNo, @rcptTyCd, @pmtTyCd, @cfmDt, @salesDt, @stockRlsDt, @totItemCnt, @totTaxblAmt, @totTaxAmt, @totAmt, @remark, @itemSeq, @itemCd, @itemClsCd, @itemNm, @bcd, @pkgUnitCd, @pkg, @qtyUnitCd, @qty, @prc, @splyAmt, @dcRt, @dcAm, @vatCatCd, @iplCatCd, @tlCatCd, @exciseTxCatC, @vatTaxblAmt, @exciseTaxblAmt, @iplTaxblAmt, @tlTaxblAmt, @taxblAmt, @vatAmt, @iplAmt, @tlAmt, @exciseTxAmt, @ttotAmt", parameters);
                    await transaction.CommitAsync();

                    return result;
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw; // Rethrow the exception after rolling back
                }
            }
        }

        public async Task<ZraPurchase?> GetZraSinglePurchaseAsync(string refId)
        {
             return await context.ZraPurchases
              .FromSqlRaw("SELECT * FROM ZraPurchase WHERE InvoiceNumber =  {0} ", refId)
              .FirstOrDefaultAsync();
        }

        public Task<int> UpdateZraPurchaseAsync(ZraPurchase zraPurchase)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateZraPurchaseRegTcdAsync(string refId)
        {
            return await context.Database.ExecuteSqlRawAsync("UPDATE InvNum SET RegTcd = 'A' WHERE InvoiceNumber = {0};", refId);
        }

        public void Dispose()
        {
            //_context?.Dispose();
        }
    }
}