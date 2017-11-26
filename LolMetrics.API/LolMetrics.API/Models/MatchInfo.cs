using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Models
{
    public class MatchInfo
    {
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        [JsonProperty("")]
        public List<Participants> Players { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("map")]
        public int Map { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }
        [JsonProperty("")]
        public List<ParticipantsIdentities> Identities { get; set; }
        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }
        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }
    }
}
