using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class UpdateItemRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string itemCd { get; set; }
        public string itemClsCd { get; set; }
        public string itemTyCd { get; set; }
        public string itemNm { get; set; }
        public string itemStdNm { get; set; }
        public string orgnNatCd { get; set; }
        public string pkgUnitCd { get; set; }
        public string qtyUnitCd { get; set; }
        public string vatCatCd { get; set; }
        public string iplCatCd { get; set; }
        public object tlCatCd { get; set; }
        public object exciseTxCatCd { get; set; }
        public object btchNo { get; set; }
        public object bcd { get; set; }
        public int dftPrc { get; set; }
        public object addInfo { get; set; }
        public int sftyQty { get; set; }
        public string isrcAplcbYn { get; set; }
        public string useYn { get; set; }
        public string regrNm { get; set; }
        public string regrId { get; set; }
        public string modrNm { get; set; }
        public string modrId { get; set; }
    }
}