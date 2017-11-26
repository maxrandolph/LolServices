using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Models
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
        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }
             [JsonProperty("neutralMinionsKilledTeamJungle")]
        public int NeutralMinionsKilledTeamJungle { get; set; }
            [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }
            [JsonProperty("totalPlayerScore")]
        public int TotalPlayerScore { get; set; }
                 [JsonProperty("deaths")]
        public int Deaths { get; set; }
                 [JsonProperty("win")]
        public bool Win { get; set; }
            [JsonProperty("neutralMinionsKilledEnemyJungle")]
            public int NeutralMinionsKilledEnemyJungle { get; set; }
            [JsonProperty("altarsCaptured")]
        public int AltarsCaptured { get; set; }
            [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }
            [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }
            [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }
            [JsonProperty("visionWardsBoughtInGame")]
        public int VisionWardsBoughtInGame { get; set; }
            [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }
            [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }
            [JsonProperty("item1")]
        public int Item1 { get; set; }
            [JsonProperty("quadraKills")]
        public int QuadraKills { get; set; }
            [JsonProperty("teamObjective")]
        public int TeamObjective { get; set; }
            [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }
            [JsonProperty("longestTimeSpentLiving")]
        public int LongestTimeSpentLiving { get; set; }
            [JsonProperty("wardsKilled")]
        public int WardsKilled { get; set; }
            [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }
            [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }
            [JsonProperty("item2")]
        public int Item2 { get; set; }
            [JsonProperty("item3")]
        public int Item3 { get; set; }
            [JsonProperty("item0")]
        public int Item0 { get; set; }
            [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }
            [JsonProperty("visionScore")]
        public long VisionScore { get; set; }
            [JsonProperty("wardsPlaced")]
        public int WardsPlaced { get; set; }
            [JsonProperty("item4")]
        public int Item4 { get; set; }
            [JsonProperty("item5")]
        public int Item5 { get; set; }
            [JsonProperty("item6")]
        public int Item6 { get; set; }
            [JsonProperty("turretKills")]
        public int TurretKills { get; set; }
            [JsonProperty("tripleKills")]
        public int TripleKills { get; set; }
            [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }
            [JsonProperty("champLevel")]
        public int ChampLevel { get; set; }
            [JsonProperty("nodeNeutralizeAssist")]
        public int NodeNeutralizeAssist { get; set; }
            [JsonProperty("firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }
            [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }
            [JsonProperty("magicalDamageTaken")]
        public long MagicalDamageTaken { get; set; }
            [JsonProperty("kills")]
        public int Kills { get; set; }
            [JsonProperty("doubleKills")]
        public int DoubleKills { get; set; }
            [JsonProperty("nodeCaptureAssist")]
        public int NodeCaptureAssist { get; set; }
            [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }
            [JsonProperty("nodeNeutralize")]
        public int NodeNeutralize { get; set; }
            [JsonProperty("firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }
            [JsonProperty("assists")]
        public int Assists { get; set; }
            [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }
            [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }
            [JsonProperty("objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }
            [JsonProperty("combatPlayerScore")]
        public int CombatPlayerScore { get; set; }
            [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }
            [JsonProperty("altarsNeutralized")]
        public int AltarsNeutralized { get; set; }
            [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }
            [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }
            [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }
            [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }
            [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
            [JsonProperty("pentaKills")]
        public int PentaKills { get; set; }
            [JsonProperty("totalHeal")]
        public long TotalHeal { get; set; }
            [JsonProperty("totalMinionsKilled")]
        public int TotalMinionsKilled { get; set; }
            [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }
            [JsonProperty("nodeCapture")]
        public int NodeCapture { get; set; }
            [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }
            [JsonProperty("sightWardsBoughtInGame")]
        public int SightWardsBoughtInGame { get; set; }
            [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }
            [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }
            [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }
            [JsonProperty("totalScoreRank")]
        public int TotalScoreRank { get; set; }
            [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }
            [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }
            [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }
            [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

    }
    
    public class Player
    {
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("currentAccountId")]
        public string CurrentAccountId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }
        [JsonProperty("accountId")]
        public int AccountId { get; set; }          
    }

}
