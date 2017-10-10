using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetricsForms.Models
{
    public class Summoner
    {

        public long Id { get; set; }

        public long AccountId { get; set; }
 
        public string Name { get; set; }

        public long SummonerLevel { get; set; }

        public long RevisionDate { get; set; }

        public int ProfileIconId { get; set; }
    }
}