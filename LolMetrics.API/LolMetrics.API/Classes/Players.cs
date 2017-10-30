using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Classes
{
    public class Participants
    {
        [JsonProperty("stats")]
        public PlayerStats Stats { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("runes")]
        public List<Runes> Runes { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }
        [JsonProperty("masteries")]
        public List<Masteries> Masteries { get; set; }
        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
    public class ParticipantsIdentities
    {
        [JsonProperty("player")]
        public Player Player { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
    }
    public class PlayerStats
    {
    
    }
    public class Player
    {

    }

}
