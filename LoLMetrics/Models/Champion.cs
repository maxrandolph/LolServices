using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace LoLMetrics.Models
{
    public class Champion
    {
        [JsonProperty ("spells")]
        public List<Spell> Spells { get; set; }
        [JsonProperty ("id")]
        public int Id { get; set; }
        [JsonProperty ("name")]
        public string Name { get; set; }
        [JsonProperty ("key")]
        public string Key { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}