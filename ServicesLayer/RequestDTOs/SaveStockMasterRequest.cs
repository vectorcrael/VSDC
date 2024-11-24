using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SaveStockMasterRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string regrId { get; set; }
        public string regrNm { get; set; }
        public string modrNm { get; set; }
        public string modrId { get; set; }
        public List<StockItemList> stockItemList { get; set; }
    }

    public class StockItemList
    {
        public string itemCd { get; set; }
        public int rsdQty { get; set; }
    }
}