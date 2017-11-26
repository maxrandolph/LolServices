using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolMetrics.API.Models
{
    public class Team
    {
    }
    public class TeamStats
    {
        public bool firstDragon { get; set; }
        public bool firstInhibitor { get; set; }
        public List<TeamBans> bans { get; set; }
        public int baronKills { get; set; }
        public bool firstRiftherald { get; set; }
        public bool firstBaron { get; set; }
        public int riftHeraldKills { get; set; }
        public bool firstBlood { get; set; }
        public int teamId { get; set; }
        public bool firstTower { get; set; }
        public int vilemawKills { get; set; }
        public int inhibitorKills { get; set; }
        public int towerKills { get; set; }
        public int dominionVictoryScore { get; set; }
        public int win { get; set; }
        public int dragonKills { get; set; }
    }
    public class TeamBans
    {
        public Player player { get; set; }
        public int participantId { get; set; }
    }
}
