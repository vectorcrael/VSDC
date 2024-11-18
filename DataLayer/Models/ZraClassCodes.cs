using System;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Keyless]
    public class ZraClassCode
    {
        public string ResultDt { get; set; }
        public string TemClsCd { get; set; }
        public string ItemClsNm { get; set; }
        public decimal ItemClsLvl { get; set; }
        public string TaxTyCd { get; set; }
        public string MjrTgYn { get; set; }
        public string UseYn { get; set; }
    }
}