﻿using Newtonsoft.Json.Serialization;

namespace ServicesLayer;

public class LowercaseFirstLetterContractResolver : DefaultContractResolver
{
    protected override string ResolvePropertyName(string propertyName)
    {
        if (string.IsNullOrEmpty(propertyName))
            return propertyName;

        // Convert only the first letter to lowercase
        return char.ToLowerInvariant(propertyName[0]) + propertyName.Substring(1);
    }
}