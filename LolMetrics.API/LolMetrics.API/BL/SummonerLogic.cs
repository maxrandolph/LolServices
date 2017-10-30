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
        public Matches GetMatchHistory(string summoner)
        {
            SummonerFactory factory = new SummonerFactory();
            Matches matches = factory.GetMatchesById(summoner);
            AllChampions champions = factory.GetAllChampions();

            foreach (Match match in matches.MatchStats)
            {
                Champion tempChampion = new Champion();
                if(champions.Champions.TryGetValue(match.Champion.ToString(), out tempChampion))
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
    }
}
