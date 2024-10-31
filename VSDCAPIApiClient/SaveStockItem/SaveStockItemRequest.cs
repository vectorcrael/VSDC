using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SaveStockItemRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public int SarNo { get; set; }
        public int OrgSarNo { get; set; }
        public string RegTyCd { get; set; }
        public object CustTpin { get; set; }
        public object CustNm { get; set; }
        public object CustBhfId { get; set; }
        public string SarTyCd { get; set; }
        public string OcrnDt { get; set; }
        public int TotItemCnt { get; set; }
        public double TotTaxblAmt { get; set; }
        public double TotTaxAmt { get; set; }
        public double TotAmt { get; set; }
        public string Remark { get; set; }
        public string RegrId { get; set; }
        public string RegrNm { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
        public List<ItemList> ItemList { get; set; }
    }

    public class ItemList
    {
        public int ItemSeq { get; set; }
        public string ItemCd { get; set; }
        public string ItemClsCd { get; set; }
        public string itemTyCd {get;set;}
        public string ItemNm { get; set; }
        public string PkgUnitCd { get; set; }
        public string QtyUnitCd { get; set; }
        public decimal Qty { get; set; }
        public double Prc { get; set; }
        public double SplyAmt { get; set; }
        public double TaxblAmt { get; set; }
        public string VatCatCd { get; set; }
        public double TaxAmt { get; set; }
        public double TotAmt { get; set; }
    }
}