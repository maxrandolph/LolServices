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
        public List<MatchReference> MatchStats { get; set; }
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }

    public class MatchReference
    {
        public MatchReference()
        {
            MatchDetails = new Match();
        }
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
        public Match MatchDetails { get; set; }
    }
    public class Match
    {
        public Match()
        {
            Time = "00.00";
        }
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("participantIdentities")]
        public List<ParticipantsIdentities> Identities { get; set; }
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("participants")]
        public List<Participants> Participants { get; set; }
        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }
        [JsonProperty("teams")]
        public List<TeamStats> Teams { get; set; }
        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }
        public string Time { get; set; }
        public string KdaLong { get; set; }
        public string KdaShort { get; set; }
    }
}