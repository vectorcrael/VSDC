using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SavePurchasesRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public int invcNo { get; set; }
        public int orgInvcNo { get; set; }
        public string spplrTpin { get; set; }
        public string spplrBhfId { get; set; }
        public string spplrNm { get; set; }
        public string spplrInvcNo { get; set; }
        public string regTyCd { get; set; }
        public string pchsTyCd { get; set; }
        public string rcptTyCd { get; set; }
        public string pmtTyCd { get; set; }
        public string pchsSttsCd { get; set; }
        public string cfmDt { get; set; }
        public string pchsDt { get; set; }
        public string? cnclReqDt { get; set; }
        public string? cnclDt { get; set; }
        public int totItemCnt { get; set; }
        public double totTaxblAmt { get; set; }
        public double totTaxAmt { get; set; }
        public double totAmt { get; set; }
        public string remark { get; set; }
        public string regrNm { get; set; }
        public string regrId { get; set; }
        public string modrNm { get; set; }
        public string modrId { get; set; }
        public List<ItemList2> itemList { get; set; }
    }

    public class ItemList2
    {
        public int itemSeq { get; set; }
        public string itemCd { get; set; }
        public string itemClsCd { get; set; }
        public string itemNm { get; set; }
        public object bcd { get; set; }
        public string pkgUnitCd { get; set; }
        public int pkg { get; set; }
        public string qtyUnitCd { get; set; }
        public int qty { get; set; }
        public int prc { get; set; }
        public int splyAmt { get; set; }
        public int dcRt { get; set; }
        public int dcAmt { get; set; }
        public string taxTyCd { get; set; }
        public object iplCatCd { get; set; }
        public object tlCatCd { get; set; }
        public double taxblAmt { get; set; }
        public string vatCatCd { get; set; }
        public object iplTaxblAmt { get; set; }
        public object tlTaxblAmt { get; set; }
        public double taxAmt { get; set; }
        public double totAmt { get; set; }
    }
}