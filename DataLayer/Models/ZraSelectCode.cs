using System;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

[Keyless]
public class ZraSelectCode
{
    public string ResultDt { get; set; }    // Corresponds to @resultDt
    public string CdCls { get; set; }        // Corresponds to @cdCls
    public string CdClsNm { get; set; }      // Corresponds to @cdClsNm
    public string Cd { get; set; }           // Corresponds to @cd
    public string CdNm { get; set; }         // Corresponds to @cdNm
    public string UserDfnNm1 { get; set; }   // Corresponds to @userDfnNm1
}
