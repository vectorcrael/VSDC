using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class CustomersRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string lastReqDt { get; set; }
        //public string CustmTpin { get; set; }
    }
}