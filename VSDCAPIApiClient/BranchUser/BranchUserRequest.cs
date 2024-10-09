using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class BranchUserRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string userId { get; set; }
        public string userNm { get; set; }
        public string adrs { get; set; }
        public string useYn { get; set; }
        public string regrNm { get; set; }
        public string regrId { get; set; }
        public string modrNm { get; set; }
        public string modrId { get; set; }
    }
}