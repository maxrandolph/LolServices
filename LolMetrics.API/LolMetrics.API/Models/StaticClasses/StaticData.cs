using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolMetrics.API.Models
{
    public class StaticData
    {
        public StaticData()
        {
            Items = new List<Items>();
            Runes = new List<Runes>();
            Champions = new List<Champions>();
            Masteries = new List<MasteryList>();
        }
        public List<Items> Items { get; set; }
        public List<Runes> Runes { get; set; }
        public List<Champions> Champions { get; set; }
        public List<MasteryList> Masteries { get; set; }

    }
}
