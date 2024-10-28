using System;
using DataLayer.Models;
using DataLayer.Models2;
using DataLayer.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Services
{

    public class FiscalInfoService : IFiscalInfoService
    {
        private readonly AppDBContext _context;

        public FiscalInfoService(AppDBContext context)
        {
            _context = context;
        }

        // Methods for FiscalInfo
        public async Task<List<FiscalInfo>> GetAllFiscalInfosAsync()
        {
            return await _context.FiscalInfos.ToListAsync();
        }

        public async Task AddFiscalInfoAsync(FiscalInfo fiscalInfo)
        {
            _context.FiscalInfos.Add(fiscalInfo);
            await _context.SaveChangesAsync();
        }

        // Methods for ZraInvoice
        public async Task<List<ZraInvoice>> GetZraInvoicesAsync()
        {
            var invoices = await _context.ZraInvoices
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
            return await _context.ZraInvoiceItems
                .FromSqlRaw("EXEC GetZraInvoiceItem @RefId={0}", refId)
                .ToListAsync();
        }

        public async Task<List<ZraInvoiceItem>> GetPurchaseItemsAsync(string refId)
        {
            return await _context.ZraInvoiceItems
                .FromSqlRaw("EXEC GetZraPurchaseItem @RefId={0}", refId)
                .ToListAsync();
        }

        // Methods for PurchaseInfo
        public async Task<List<PurchaseInfo>> GetAllPurchasesAsync()
        {
            return await _context.PurchaseInfos
                .FromSqlRaw("SELECT * FROM PurchaseInfo")
                .ToListAsync();
        }

        public async Task<int> UpdateFiscalDetailsAsync(byte[] signature, string internalData, string invoiceNumber, string invoiceType, string invoiceSequence, string qrCode, string vsdcDate)
        {
            var parameters = new[]
            {
                new SqlParameter("@Signature", signature),
                new SqlParameter("@InternalData", internalData),
                new SqlParameter("@InvNumber", invoiceNumber),
                new SqlParameter("@InvoiceType", invoiceType),
                new SqlParameter("@InvoiceSequence", invoiceSequence),
                new SqlParameter("@QrCode", qrCode),
                new SqlParameter("@VsdcDate", vsdcDate)
            };

            return await _context.Database.ExecuteSqlRawAsync("EXEC UpdateFiscalDetails @Signature, @InternalData, @InvNumber, @InvoiceType, @InvoiceSequence, @QrCode, @VsdcDate", parameters);
        }

        public async Task<List<ZraStockMaster>> GetStockMastersAsync()
        {
            var masters = await _context.ZraStockMasters
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
            var deviceInits = await _context.DeviceInits
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

            return await _context.Database.ExecuteSqlRawAsync("EXEC UpdateDeviceDetails @resultCd, @resultMsg, @resultDt, @tpin, @taxprNm, @bsnsActv, @bhfId, @bhfNm, @bhfOpenDt, @prvncNm, @dstrtNm, @sctrNm, @locDesc, @hqYn, @mgrNm, @mgrTelNo, @mgrEmail, @sdicId, @mrcNo, @lastSaleInvcNo, @lastPchsInvcNo, @lastSaleRcptNo, @lastInvcNo, @lastTrainInvcNo, @lastProfrmInvcNo, @lastCopyInvcNo", parameters);
        }

        public async Task<List<ZraSelectCode>> GetAllZraSelectCodesAsync()
        {
            var zraCodes = await _context.ZraSelectCodes
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
                new SqlParameter("@userDfnNm1", zraSelectCode.UserDfnNm1)
            };

            return await _context.Database.ExecuteSqlRawAsync("EXEC UpdateZRAStandardCodes @resultDt, @cdCls, @cdClsNm, @cd, @cdNm, @userDfnNm1", parameters);
        }

        public async Task<List<ZraClassCode>> GetAllZraClassCodesAsync()
        {
            var zraCodes = await _context.ZraClassCodes
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
                new SqlParameter("@taxTyCd", zraClassCodes.TaxTyCd),
                new SqlParameter("@mjrTgYn", zraClassCodes.MjrTgYn),
                new SqlParameter("@useYn", zraClassCodes.UseYn)
            };

            return await _context.Database.ExecuteSqlRawAsync("EXEC UpdateZRAClassCodes @resultDt, @temClsCd, @itemClsNm, @itemClsLvl, @taxTyCd, @mjrTgYn, @useYn", parameters);
        }
    }
}