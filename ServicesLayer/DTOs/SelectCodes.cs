using System;
using System.Collections.Generic;

namespace ServicesLayer.DTOs;

public class SelectCodes
{
    public List<ClassInfo> clsList { get; set; }
}

public class ClassInfo
{
    public string cdCls { get; set; }
    public string cdClsNm { get; set; }
    public string? userDfnNm1 { get; set; }
    public List<DetailInfo> dtlList { get; set; }
}

public class DetailInfo
{
    public string cd { get; set; }
    public string cdNm { get; set; }
    public string? userDfnCd1 { get; set; }
}