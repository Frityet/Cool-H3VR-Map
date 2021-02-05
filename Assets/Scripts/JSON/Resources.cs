using System.Net;
using Valve.Newtonsoft.Json;

public class Resources
{
    [JsonIgnore] private const string ResourceURL = "https://raw.githubusercontent.com/Frityet/Cool-H3VR-Map/master/Resources.json";

    [JsonProperty("Resources Revision")] public int ResourcesRevision { get; set; }

    [JsonProperty("MOTD")] public string Motd { get; set; }

    [JsonProperty("Linked Files")] public string[] LinkedFiles { get; set; }

    public static Resources GetResources()
    {
        var getter = new WebClient();

        var resourcesFile = getter.DownloadString(ResourceURL);
        
        return JsonConvert.DeserializeObject<Resources>(resourcesFile);
    }
}