using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetricsForms.Models
{
    public class Matches
    {
   
        public List<Match> MatchStats { get; set; }

        public int TotalGames { get; set; }

        public int StartIndex { get; set; }

        public int EndIndex { get; set; }
    }

    public class Match
    {

        public string Lane         { get; set; }

        public long GameId         { get; set; }

        public int Champion        { get; set; }

        public string PlatformId   { get; set; }

        public int Season          { get; set; }

        public int Queue           { get; set; }

        public string Role         { get; set; }

        public long Timestamp      { get; set; }
    }
}