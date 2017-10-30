using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolMetrics.API.Classes
{
    public class MatchInfo
    {
        public int SeasonId { get; set; }
        public int QueueId { get; set; }
        public long GameId { get; set; }
        public string GameVersion { get; set; }
        public List<Participants> Players { get; set; }
        public string GameMode { get; set; }
        public int Map { get; set; }
        public string GameType { get; set; }
        public List<Team> Teams { get; set; }
        public List<ParticipantsIdentities> Identities { get; set; }
        public long GameDuration { get; set; }
        public long GameCreation { get; set; }
    }
}
