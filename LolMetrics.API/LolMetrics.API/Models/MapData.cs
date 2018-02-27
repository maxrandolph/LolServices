using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Models
{
    public class MapData
    {
        [JsonProperty("data")]
        public Dictionary<string, MapDetails> Map { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public class MapDetails
    {
        [JsonProperty("mapName")]
        public string Name { get; set; }
        [JsonProperty("mapId")]
        public long MapId { get; set; }
        [JsonProperty("unpurchasableItemList")]
        public List<long> UnpurchaseableItemList { get; set; }
    }
}
