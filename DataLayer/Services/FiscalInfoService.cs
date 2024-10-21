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
    }
}