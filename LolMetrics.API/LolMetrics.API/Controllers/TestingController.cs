using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LolMetrics.API.BL;
using LolMetrics.API.Models;
using Newtonsoft.Json;

namespace LolMetrics.API.Controllers
{
    [Route("api/testing")]
    public class TestingController : Controller
    {
        SummonerLogic myLogic = new SummonerLogic();
        // GET: api/Static
        [HttpGet("")]
        public string Get()
        {
            return null;
        }
        [HttpGet("{name}")]
        public string GetMatchHistory(string name)
        {
            return JsonConvert.SerializeObject(myLogic.GetMatchHistory(name)).ToString();
        }
    }
}