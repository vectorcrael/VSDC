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
                //TaxRtRvat =zraInvoice.,
                //TaxRtE =zraInvoice.,
                //TaxRtF =zraInvoice.,
                //TaxRtIpl1 =zraInvoice.,
                //TaxRtIpl2 =zraInvoice.,
                //TaxRtTl =zraInvoice.,
                //TaxRtEcm =zraInvoice.,
                //TaxRtExeeg =zraInvoice.,
                //TaxRtTot =zraInvoice.,
                //TaxAmtA =zraInvoice.,
                //TaxAmtB =zraInvoice.,
                //TaxAmtC1 =zraInvoice.,
                //TaxAmtC2 =zraInvoice.,
                //TaxAmtC3 =zraInvoice.,
                //TaxAmtD =zraInvoice.,
                //TaxAmtRvat =zraInvoice.,
                //TaxAmtE =zraInvoice.,
                //TaxAmtF =zraInvoice.,
                //TaxAmtIpl1 =zraInvoice.,
                //TaxAmtIpl2 =zraInvoice.,
                //TaxAmtTl =zraInvoice.,
                //TaxAmtEcm =zraInvoice.,
                //TaxAmtExeeg =zraInvoice.,
                //TaxAmtTot =zraInvoice.,
                //TotTaxblAmt =zraInvoice.,
                //TotTaxAmt =zraInvoice.,
                //TotAmt =zraInvoice.,
                //PrchrAcptcYn =zraInvoice.,
                //Remark =zraInvoice.,
                regrId = zraInvoice.RefundReasonCode,
                //RegrNm =zraInvoice.,
                //ModrId =zraInvoice.,
                //ModrNm =zraInvoice.,
                //SaleCtyCd =zraInvoice.,
                lpoNumber = zraInvoice.LocalPurchaseOrder,
                currencyTyCd = zraInvoice.CurrencyType,
                //ExchangeRt =zraInvoice.,
                destnCountryCd = zraInvoice.DestinationCountryCode,
                //DbtRsnCd =zraInvoice.,
                //InvcAdjustReason =zraInvoice
            };

            invoice.ItemList = new List<ItemList3>();

            foreach (var item in zraInvoice.Items)
            {
                invoice.ItemList.Add(new ItemList3
                {
                    itemSeq = item.ItemSequenceNumber,
                    itemCd = item.ItemCode,
                    itemClsCd = item.ItemClassificationCode!.ToString(),
                    itemNm = item.RefId,
                    //Bcd = item. ,
                    pkgUnitCd = item.PackagingUnitCode!.ToString(),
                    pkg = 0 ,
                    qtyUnitCd = item.QuantityUnitCode!.ToString(),
                    qty = (double)item.Quantity,
                    prc = (int)item.RRP,
                    splyAmt = 0 ,
                    //DcRt = item. ,
                    //DcAmt = item. ,
                    isrccCd = item.IsTaxInclusive.ToString(),
                    //IsrccNm = item.,
                    //IsrcRt = item. ,
                    //IsrcAmt = item. ,
                    //VatCatCd = item. ,
                    //ExciseTxCatCd = item,
                    tlCatCd = item.TaxLabel,
                    //IplCatCd = item.,
                    //VatTaxblAmt = item. ,
                    //VatAmt = item. ,
                    //ExciseTaxblAmt = item.,
                    //TlTaxblAmt = item. ,
                    //IplTaxblAmt = item. ,
                    //IplAmt = item. ,
                    //TlAmt = item,
                    //ExciseTxAmt = item. ,
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
                ItemCd = item.itemCd,
                ItemClsCd = item.itemClsCd,
                ItemNm = item.itemNm,
                PkgUnitCd = item.pkgUnitCd,
                QtyUnitCd = item.qtyUnitCd,
                VatCatCd = item.vatCatCd,
                IplCatCd = item.iplCatCd,
                TlCatCd = item.tlCatCd,
                ExciseTxCatCd = item.exciseTxCatCd,
                Bcd = item.bcd,
                DftPrc = item.prc, 
                Tpin = DeviceDetails.Tpin,
                BhfId = DeviceDetails.BhfId,
                ItemTyCd = null,
                ItemStdNm = null,
                OrgnNatCd = null,
                BtchNo = null,
                AddInfo = null,
                SftyQty = 0, 
                IsrcAplcbYn = null,
                UseYn = null,
                RegrNm = null,
                RegrId = null,
                ModrNm = null,
                ModrId = null
            };
        }
    }
}

