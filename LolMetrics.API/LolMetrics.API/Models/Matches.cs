using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using LolMetrics.API.Factories;

namespace LolMetrics.API.Models
{
    public class Matches
    {
        [JsonProperty("matches")]
        public List<Match> MatchStats { get; set; }
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }

    public class Match
    {
        [JsonProperty("lane")]
        public string Lane { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("champion")]
        public int Champion { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("season")]
        public int Season { get; set; }
        [JsonProperty("queue")]
        public int Queue { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        public string ChampionName { get; set; }
    }
}