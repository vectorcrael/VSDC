using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class RequestParameters
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string lastReqDt { get; set; }
    }
}