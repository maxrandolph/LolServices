using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolMetrics.API.Models
{
    public class MatchModel
    {
        public int Id { get; set; }
        public string QueueType { get; set; }
        public string SummonerName { get; set; }
        public string GameLength { get; set; }
        public string ChampionName { get; set; }
        public List<Participants> Players { get; set; }
        public string Map { get; set; }
    }
}
