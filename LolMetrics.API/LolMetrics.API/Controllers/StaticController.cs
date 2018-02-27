using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LolMetrics.API.Models;
using LolMetrics.API.Factories;
using Newtonsoft.Json;
using LolMetrics.API.BL;

namespace LolMetrics.API.Controllers
{
    [Route("api/static")]
    public class StaticController : Controller
    {
        SummonerLogic myLogic = new SummonerLogic();
        // GET: api/Static
        [HttpGet("")]
        public string GetStatic()
        {
            return JsonConvert.SerializeObject(myLogic.GetStaticData()).ToString();
        }
        [HttpGet("{name}")]
        public string GetMatchHisotry(string name)
        {
            return JsonConvert.SerializeObject(myLogic.GetMatchHistory(name)).ToString();
        }
    }
}
