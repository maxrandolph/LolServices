using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolMetrics.API.Classes
{
    public class StaticData
    {
        public List<Items> Items { get; set; }
        public List<Runes> Runes { get; set; }
        public List<Champions> Champions { get; set; }

    }
}
