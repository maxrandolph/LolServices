using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Models
{
    public class Champions
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("data")]
        public Dictionary<string, Champion> ChampionsList { get; set; }
    }
    public class Champion
    {
        [JsonProperty("spells")]
        public List<Spells> Spells { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
