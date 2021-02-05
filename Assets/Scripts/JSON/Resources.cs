using System;
using System.Collections.Generic;
using System.Globalization;

using Valve.Newtonsoft.Json;
using Valve.Newtonsoft.Json.Converters;

public class Resources
{
    [JsonIgnore] public readonly string ResourceURL = "";
    
    [JsonProperty("Resources Revision")] public int ResourcesRevision { get; set; }

    [JsonProperty("MOTD")] public string Motd { get; set; }

    [JsonProperty("Linked Files")] public string[] LinkedFiles { get; set; }

    public Resources GetResources()
    {
        return null;
    }
}