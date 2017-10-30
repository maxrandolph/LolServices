using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Classes
{
    public class Items
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, Item> ChampionsList { get; set; }
    }
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("stats")]
        public ItemStats Stats { get; set; }
    }
}
