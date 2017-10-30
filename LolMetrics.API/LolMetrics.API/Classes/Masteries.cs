using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Classes
{
    public class Masteries
    {
    }
    public class ChampionMastery
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
