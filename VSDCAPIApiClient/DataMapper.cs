﻿using System;
using System.IO.Compression;
using DataLayer.Models2;
using VSDCAPI;

namespace VSDCAPIApiClient
{
    public class DataMapper
    {

        public static class DeviceDetails
        {
            public static string Tpin { get; set; } = "1002546945";
            public static string BhfId { get; set; } = "000";
            public static string DvcSrlNo { get; set; } = "CHC-EVO";
        }

        public static SaveSalesRequest ConvertInvoice(ZraInvoice zraInvoice)
        {
            var noVatOnPatent = zraInvoice.invtottax == 0 ? true : false;

            SaveSalesRequest invoice = new SaveSalesRequest
            {
                bhfId = DeviceDetails.BhfId,
                tpin = DeviceDetails.Tpin,
                orgInvcNo = (int)zraInvoice.OriginalInvoiceNumber,
                cisInvcNo = zraInvoice.InvoiceNumber,
                custTpin = new string(zraInvoice.CustomerTpin!.Where(char.IsDigit).ToArray()), //verify this
                custNm = zraInvoice.CustomerName,
                salesTyCd = "N",
                rcptTyCd = zraInvoice.ReceiptTypeCode,
                pmtTyCd = zraInvoice.PaymentTypeCode,
                salesSttsCd = "02",
                cfmDt = zraInvoice.SaleDate.ToString("yyyyMMddHHmmss"),
                salesDt = (zraInvoice.SaleDate.Date < DateTime.Today.AddDays(-30)) ? DateTime.Today.ToString("yyyyMMdd") : zraInvoice.SaleDate.ToString("yyyyMMdd"),
                rfdRsnCd = zraInvoice.RefundReasonCode,
                taxblAmtA = noVatOnPatent? 0: zraInvoice.invtotexcl,
                taxblAmtTot = noVatOnPatent? 0: zraInvoice.invtotexcl,
                taxAmtTot = noVatOnPatent? 0: zraInvoice.invtottax,
                prchrAcptcYn = "N",
                //regrId = zraInvoice.RefundReasonCode,
                regrNm = "admin",
                modrId = "admin",
                modrNm = "admin",
                saleCtyCd = "1",
                lpoNumber = zraInvoice.LocalPurchaseOrder,
                currencyTyCd = zraInvoice.CurrencyType,
                exchangeRt = zraInvoice.ConversionRate.ToString("F2"),
                destnCountryCd = zraInvoice.DestinationCountryCode,
                dbtRsnCd = "",
                invcAdjustReason = "",
                totAmt = zraInvoice.invtotincl,
                vatTaxblAmt = noVatOnPatent? 0: zraInvoice.invtotexcl,
                taxRtRvat = noVatOnPatent ?  "0" :"16"
            };

            invoice.itemList = new List<ItemList3>();

            foreach (var item in zraInvoice.Items)
            {
                var noVat = item.fQuantityLineTotExcl > 0;

                invoice.itemList.Add(new ItemList3
                {
                    itemSeq = item.ItemSequenceNumber,
                    itemCd = item.ItemCode,
                    //itemClsCd = item.ItemClassificationCode,
                    itemNm = item.RefId.ToString(),
                    bcd = "",
                    pkgUnitCd = item.PackagingUnitCode!.ToString(),
                    pkg = 0,
                    qtyUnitCd = item.QuantityUnitCode!.ToString(),
                    qty = (double)item.Quantity,
                    prc = (int)item.UnitPrice,
                    splyAmt = (int)item.TotalAmount,
                    dcRt = 0,
                    dcAmt = 0,
                    isrccCd = item.IsTaxInclusive.ToString(),
                    isrccNm = "",
                    isrcRt = 0,
                    isrcAmt = 0,
                    vatCatCd = noVat ? "D" : "A",
                    exciseTxCatCd = "",
                    tlCatCd = item.TaxLabel,
                    iplCatCd = "",
                    vatTaxblAmt = noVat ? 0 : item.fQuantityLineTotExcl,
                    vatAmt = item.fQuantityLineTaxAmount,
                    exciseTaxblAmt = 0,
                    tlTaxblAmt = 0,
                    iplTaxblAmt = 0,
                    iplAmt = 0,
                    tlAmt = 0,
                    exciseTxAmt = 0,
                    totAmt = (int)item.TotalAmount
                });
            };

            return invoice;
        }

        public static UpdateItemRequest MapToUpdateItemRequest(ItemList3 item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            return new UpdateItemRequest
            {
                itemCd = item.itemCd,
                itemClsCd = item.itemClsCd,
                itemNm = item.itemNm,
                pkgUnitCd = item.pkgUnitCd,
                qtyUnitCd = item.qtyUnitCd,
                vatCatCd = item.vatCatCd,
                iplCatCd = item.iplCatCd,
                tlCatCd = item.tlCatCd,
                exciseTxCatCd = item.exciseTxCatCd,
                bcd = item.bcd,
                dftPrc = item.prc,
                tpin = DeviceDetails.Tpin,
                bhfId = DeviceDetails.BhfId,
                itemTyCd = null,
                itemStdNm = null,
                orgnNatCd = null,
                btchNo = null,
                addInfo = null,
                sftyQty = 0,
                isrcAplcbYn = null,
                useYn = null,
                regrNm = null,
                modrNm = null,
                modrId = null
            };
        }
    }
}

