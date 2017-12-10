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
            Items = new Items();
            Runes = new Runes();
            Champions = new Champions();
            Masteries = new MasteryList();
            Maps = new MapData();
        }
        public Items Items { get; set; }
        public Runes Runes { get; set; }
        public Champions Champions { get; set; }
        public MasteryList Masteries { get; set; }
        public MapData Maps { get; set; }

    }
}
