using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LolMetrics.API.Classes;
using LolMetrics.API.Factories;

namespace LolMetrics.API.BL
{
    public class SummonerLogic
    {
        public Matches GetMatchHistory(string query)
        {
            var factory = new SummonerFactory();
            var summoner = new Summoner();
            summoner = factory.GetSummonerByName(query);
            var matches = factory.GetMatchesById(summoner.AccountId.ToString());
            var champions = factory.GetChampions();

            foreach (Match match in matches.MatchStats)
            {
                var tempChampion = new Champion();
                if(champions.ChampionsList.TryGetValue(match.Champion.ToString(), out tempChampion))
                {
                    match.ChampionName = tempChampion.Name;

                }
                else
                {
                    continue;
                }
           
            }
            return matches;
        }
        public StaticData GetStaticData()
        {
            var staticData = new StaticData();
            var factory = new SummonerFactory();

            staticData.Champions.Add(factory.GetChampions());
            staticData.Items.Add(factory.GetItems());
            staticData.Runes.Add(factory.GetRunes());
            staticData.Masteries.Add(factory.GetMasteries());

            return staticData;
        }
    }
}
