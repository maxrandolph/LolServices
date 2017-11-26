using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Models
{
    public class Runes
    {
    }
    public class Rune
    {
        [JsonProperty("runeId")]
        public int RuneId { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
