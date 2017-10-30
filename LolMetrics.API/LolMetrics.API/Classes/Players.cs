using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolMetrics.API.Classes
{
    public class Participants
    {
        public PlayerStats Stats { get; set; }
        public int ParticipantId { get; set; }
        public List<Runes> Runes { get; set; }
        public int TeamId { get; set; }
        public int Spell1Id { get; set; }
        public int Spell2Id { get; set; }
        public List<Masteries> Masteries { get; set; }
        public string HighestAchievedSeasonTier { get; set; }
        public int ChampionId { get; set; }
    }
    public class ParticipantsIdentities
    {
        public Player Player { get; set; }
        public int ParticipantId { get; set; }
    }
    public class PlayerStats
    {
    
    }
    public class Player
    {

    }

}
