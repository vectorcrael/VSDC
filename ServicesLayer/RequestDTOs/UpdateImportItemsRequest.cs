using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class UpdateImportItemsRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string taskCd { get; set; }
        public string dclDe { get; set; }
        public List<ImportItem> importItemList { get; set; }
    }

    public class ImportItem
    {
        public int itemSeq { get; set; }
        public string hsCd { get; set; }
        public string itemClsCd { get; set; }
        public string itemCd { get; set; }
        public string imptItemSttsCd { get; set; }
        public string remark { get; set; }
        public string modrNm { get; set; }
        public string modrId { get; set; }
    }

}