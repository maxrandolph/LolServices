using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LolMetrics.API.Classes;
using LolMetrics.API.Factories;
using Newtonsoft.Json;
using LolMetrics.API.BL;

namespace LolMetrics.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        SummonerFactory myFactory = new SummonerFactory();
        SummonerLogic myLogic = new SummonerLogic();
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return JsonConvert.SerializeObject( myLogic.GetMatchHistory(name)).ToString();
        }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
