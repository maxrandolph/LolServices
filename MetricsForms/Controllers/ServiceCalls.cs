using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolServiceClient = LoLMetrics.LolService;
using MetricsForms.Models;
using AutoMapper;
using LoLMetrics.Models;
using Summoner = MetricsForms.Models.Summoner;
using Match = MetricsForms.Models.Match;

namespace MetricsForms.Controllers
{
    public class ServiceCalls
    {
        public Summoner GetSummoner(string summoner)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<LoLMetrics.Models.Summoner, Summoner>();
            });
            LolServiceClient client = new LolServiceClient();
            var tempSummoner = client.GetSummonerByName(summoner);
            Summoner result = Mapper.Map<Summoner>(tempSummoner);
            return result;
        }
        public Match GetMatches(string summoner)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<LoLMetrics.Models.Match, Match>();
            });
            LolServiceClient client = new LolServiceClient();
            var matches = client.GetMatchesById(summoner);
            Match result = Mapper.Map<Match>(matches);

            return result;
        }
    }
}
