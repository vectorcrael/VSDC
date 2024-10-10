using System;
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
            SaveSalesRequest invoice = new SaveSalesRequest
            {
                bhfId = DeviceDetails.BhfId,
                tpin = DeviceDetails.Tpin,
                orgInvcNo = (int)zraInvoice.OriginalInvoiceNumber,
                cisInvcNo = zraInvoice.InvoiceNumber,
                custTpin = new string(zraInvoice.CustomerTpin!.Where(char.IsDigit).ToArray()) , //verify this
                custNm = zraInvoice.CustomerName,
                salesTyCd ="N",
                rcptTyCd = zraInvoice.ReceiptTypeCode,
                pmtTyCd = zraInvoice.PaymentTypeCode,
                salesSttsCd ="02",
                cfmDt =zraInvoice.SaleDate.ToString("yyyyMMddHHmmss"),
                salesDt = zraInvoice.SaleDate.ToString("yyyyMMdd"),
                rfdRsnCd = zraInvoice.RefundReasonCode,
                taxblAmtA =zraInvoice.invtotexcl,
                taxblAmtTot =zraInvoice.invtottax,
                tlAmt =zraInvoice.invtotincl,
                taxAmtTot =zraInvoice.invtotincl,
                prchrAcptcYn ="N",
                regrId = zraInvoice.RefundReasonCode,
                regrNm ="admin",
                modrId ="admin",
                modrNm ="admin",
                saleCtyCd ="1",
                lpoNumber = zraInvoice.LocalPurchaseOrder,
                currencyTyCd = zraInvoice.CurrencyType,
                exchangeRt =zraInvoice.ConversionRate.ToString("F2"),
                destnCountryCd = zraInvoice.DestinationCountryCode,
                dbtRsnCd ="",
                invcAdjustReason =""
            };

            invoice.itemList = new List<ItemList3>();

            foreach (var item in zraInvoice.Items)
            {
                invoice.itemList.Add(new ItemList3
                {
                    itemSeq = item.ItemSequenceNumber,
                    itemCd = item.ItemCode,
                    //itemClsCd = item.ItemClassificationCode,
                    itemNm = item.RefId.ToString(),
                    bcd = "" ,
                    pkgUnitCd = item.PackagingUnitCode!.ToString(),
                    pkg = 0 ,
                    qtyUnitCd = item.QuantityUnitCode!.ToString(),
                    qty = (double)item.Quantity,
                    prc = (int)item.RRP,
                    splyAmt = 0 ,
                    dcRt = 0 ,
                    dcAmt = 0 ,
                    isrccCd = item.IsTaxInclusive.ToString(),
                    isrccNm = "",
                    isrcRt = 0 ,
                    isrcAmt = 0 ,
                    vatCatCd = "A" ,
                    exciseTxCatCd = "",
                    tlCatCd = item.TaxLabel,
                    iplCatCd = "",
                    vatTaxblAmt = item.fQuantityLineTotExcl ,
                    vatAmt = item.fQuantityLineTaxAmount ,
                    exciseTaxblAmt = 0,
                    tlTaxblAmt = 0 ,
                    iplTaxblAmt = 0 ,
                    iplAmt = 0 ,
                    tlAmt = 0,
                    exciseTxAmt = 0 ,
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

