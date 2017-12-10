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
            return matches;
        }
        public StaticData GetStaticData()
        {
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
