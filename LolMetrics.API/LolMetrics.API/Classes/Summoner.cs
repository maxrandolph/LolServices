using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace LolMetrics.API.Classes
{
    public class Summoner
    {
        [JsonProperty ("id")]
        public long Id { get; set; }
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
    }
}