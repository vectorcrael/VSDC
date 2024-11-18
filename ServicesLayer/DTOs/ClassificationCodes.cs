using System;
using System.Collections.Generic;

namespace ServicesLayer.DTOs;

public class ClassificationCodes
{
    public List<ItemClass> itemClsList { get; set; }
}

public class ItemClass
{
    public string itemClsCd { get; set; }
    public string itemClsNm { get; set; }
    public int itemClsLvl { get; set; }
    public string? taxTyCd { get; set; } // Nullable
    public string? mjrTgYn { get; set; } // Nullable
    public string useYn { get; set; }
}