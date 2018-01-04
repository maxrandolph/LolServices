using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LolMetrics.API.Models;
using LolMetrics.API.Factories;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace LolMetrics.API.BL
{
    public class SummonerLogic
    {
        private Caching cache = new Caching();
        //this gets called on any intial summoner search
        public Matches GetMatchHistory(string query)
        {
            var factory = new SummonerFactory();
            var summoner = new Summoner();
            var staticData = new StaticData();
            staticData = GetStaticData();
            summoner = factory.GetSummonerByName(query);
            var matches = factory.GetMatchesById(summoner.AccountId.ToString());
            var champions = staticData.Champions;

            foreach (MatchReference match in matches.MatchStats)
            {
                var tempChampion = new Champion();
                if(champions.ChampionsList.TryGetValue(match.Champion.ToString(), out tempChampion))
                {
                    match.ChampionName = tempChampion.Name;

                }
           
            }
            matches = GetMatchDetails(query, matches, summoner.Id);
            return matches;
        }

        //using this to grab match details and put them directly into the Matches object
        public Matches GetMatchDetails(string query, Matches matches, long summonerId)
        {
            var factory = new SummonerFactory();
            foreach (var match in matches.MatchStats)
            {
                match.MatchDetails= factory.GetMatchInfoById(match.GameId.ToString());

                //doing a time conversion
                TimeSpan gameTime = TimeSpan.FromSeconds(match.MatchDetails.GameDuration);
                match.MatchDetails.Time = gameTime.ToString();


                //probably going to want to modularize this at some point: getting the kda here
                var identity = match.MatchDetails.Identities.Where(x => x.Player.SummonerId == summonerId).FirstOrDefault();
                var stats = match.MatchDetails.Participants.Where(x => x.ParticipantId == identity.ParticipantId).FirstOrDefault();
                var kdaLong = stats.Stats.Kills.ToString() + "/" + stats.Stats.Deaths.ToString() + "/" + stats.Stats.Assists.ToString();
                decimal kdaShort = Math.Round((Convert.ToDecimal(stats.Stats.Kills) + Convert.ToDecimal(stats.Stats.Assists))/stats.Stats.Deaths,2);
                match.MatchDetails.KdaLong = kdaLong;
                match.MatchDetails.KdaShort = kdaShort.ToString();
                                
            }

            return matches;

        }
        public StaticData GetStaticData()
        {
            //requests to static endpoint are capped, so always check for caching of data
            if (cache.DoesFileExist())
            {
                var temp = cache.CacheGet();
                return temp;
            }
            var staticData = new StaticData();
            var factory = new SummonerFactory();    
            staticData.Champions = factory.GetChampions();
            staticData.Items = factory.GetItems();
            staticData.Runes = factory.GetRunes();
            staticData.Masteries = factory.GetMasteries();
            staticData.Maps = factory.GetMaps();
            cache.CacheSet(staticData);
            return staticData;
        }
        public MatchModel GetMatchModel(string id, string summoner)
        {
            var factory = new SummonerFactory();
            var staticData = GetStaticData();
            var matchModel = new MatchModel();
            var match = factory.GetMatchById(id);

            var map = new MapDetails();
            if ( staticData.Maps.Map.TryGetValue(match.MapId.ToString(), out map))
            {
                matchModel.Map = map.Name;
            }
            var tempChampion = new Champion();
            matchModel.GameLength = match.GameDuration.ToString();
            matchModel.Players = match.Participants;
            matchModel.SummonerName = summoner;

            return matchModel;


        }
    }
}
