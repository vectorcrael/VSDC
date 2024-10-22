using System;

namespace VSDCAPIApiClient.DTOs;

    public class Info
    {
        public string tin { get; set; }
        public string taxprNm { get; set; }
        public string bsnsActv { get; set; }
        public string bhfId { get; set; }
        public string bhfNm { get; set; }
        public string bhfOpenDt { get; set; }
        public string prvncNm { get; set; }
        public string dstrtNm { get; set; }
        public string sctrNm { get; set; }
        public string locDesc { get; set; }
        public string hqYn { get; set; }
        public string mgrNm { get; set; }
        public string mgrTelNo { get; set; }
        public string mgrEmail { get; set; }
        public string sdcId { get; set; }
        public string mrcNo { get; set; }
        public int lastPchsInvcNo { get; set; }
        public int lastSaleRcptNo { get; set; }
        public string lastInvcNo { get; set; }
        public int lastSaleInvcNo { get; set; }
        public string lastTrainInvcNo { get; set; }
        public string lastProfrmInvcNo { get; set; }
        public string lastCopyInvcNo { get; set; }
    }