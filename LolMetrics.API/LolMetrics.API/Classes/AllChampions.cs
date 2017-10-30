using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Classes
{
    public class AllChampions
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, Champion> Champions { get; set; }
    }
}
