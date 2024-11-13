using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class DeviceInitializationRequest
    {
        public string tpin { get; set; }
        public string bhfId { get; set; }
        public string dvcSrlNo { get; set; }
    }
}