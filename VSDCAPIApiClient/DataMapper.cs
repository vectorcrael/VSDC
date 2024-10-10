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
                custTpin = zraInvoice.CustomerTpin,
                custNm = zraInvoice.CustomerName,
                salesTyCd ="N",
                rcptTyCd = zraInvoice.ReceiptTypeCode,
                pmtTyCd = zraInvoice.PaymentTypeCode,
                salesSttsCd ="02",
                cfmDt =zraInvoice.SaleDate.ToString(),
                salesDt = zraInvoice.SaleDate.ToString(),
                stockRlsDt =null,
                cnclReqDt =null,
                cnclDt =null,
                rfdDt =null,
                rfdRsnCd = zraInvoice.RefundReasonCode,
                totItemCnt =2,
                taxblAmtA =zraInvoice.invtotexcl,
                taxblAmtB =0,
                taxblAmtC1 =0,
                taxblAmtC2 =0,
                taxblAmtC3 =0,
                taxblAmtD =0,
                taxblAmtRvat =0,
                taxblAmtE =0,
                taxblAmtF =0,
                taxblAmtIpl1 =0,
                taxblAmtIpl2 =0,
                taxblAmtTl =0,
                taxblAmtEcm =0,
                taxblAmtExeeg =0,
                taxblAmtTot =zraInvoice.invtottax,
                taxRtA =0,
                taxRtB =0,
                taxRtC1 =0,
                taxRtC2 =0,
                taxRtC3 =0,
                taxRtD =0,
                tlAmt =zraInvoice.invtotincl,
                taxRtRvat =0,
                taxRtE =0,
                taxRtF =0,
                taxRtIpl1 =0,
                taxRtIpl2 =0,
                taxRtTl =0,
                taxRtEcm =0,
                taxRtExeeg =0,
                
                taxRtTot =0,
                tAmtA =0,
                tAmtB =0,
                tAmtC1 =0,
                tAmtC2 =0,
                tAmtC3 =0,
                tAmtD =0,
                tAmtRvat =0,
                tAmtE =0,
                tAmtF =0,
                tAmtIpl1 =0,
                tAmtIpl2 =0,
                tAmtTl =0,
                tAmtEcm =0,
                tAmtExeeg =0,
                tAmtTot =zraInvoice.invtotincl,
                totTaxblAmt =0,
                totTaxAmt =0,
                totAmt =0,
                prchrAcptcYn ="N",
                remark =null,
                regrId = zraInvoice.RefundReasonCode,
                regrNm ="admin",
                modrId ="admin",
                modrNm ="admin",
                saleCtyCd ="1",
                lpoNumber = zraInvoice.LocalPurchaseOrder,
                currencyTyCd = zraInvoice.CurrencyType,
                exchangeRt =zraInvoice.ConversionRate,
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
                    itemClsCd = item.ItemClassificationCode!.ToString(),
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
                    plCatCd = "",
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
                regrId = null,
                modrNm = null,
                modrId = null
            };
        }
    }
}

