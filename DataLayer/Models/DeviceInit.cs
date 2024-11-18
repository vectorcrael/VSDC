using System;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Keyless]
    public class DeviceInit
    {
        public string ResultCd { get; set; }
        public string ResultMsg { get; set; }
        public string ResultDt { get; set; }
        public string Tpin { get; set; }
        public string TaxprNm { get; set; }
        public string? BsnsActv { get; set; }
        public string BhfId { get; set; }
        public string BhfNm { get; set; }
        public string BhfOpenDt { get; set; }
        public string PrvncNm { get; set; }
        public string? DstrtNm { get; set; }
        public string SctrNm { get; set; }
        public string LocDesc { get; set; }
        public string HqYn { get; set; }
        public string MgrNm { get; set; }
        public string MgrTelNo { get; set; }
        public string MgrEmail { get; set; }
        public string SdicId { get; set; }
        public string MrcNo { get; set; }
        public decimal? LastSaleInvcNo { get; set; }
        public decimal? LastPchsInvcNo { get; set; }
        public decimal? LastSaleRcptNo { get; set; }
        public decimal? LastInvcNo { get; set; }
        public decimal? LastTrainInvcNo { get; set; }
        public decimal? LastProfrmInvcNo { get; set; }
        public decimal? LastCopyInvcNo { get; set; }
    }
}