using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolMetrics.API.Classes
{
    public class MasteryList
    {
        [JsonProperty("data")]
        public Dictionary<string, Mastery> Data { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("masterTree")]
        public MasteryTree MasteryTree { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Mastery
    {
        [JsonProperty("prereq")]
        public string Prereq { get; set; }
        [JsonProperty("masteryTree")]
        public string MasteryTree { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ranks")]
        public int Ranks { get; set; }
        [JsonProperty("image")]
        public Image Image { get; set; }
        [JsonProperty("sanitizedDescription")]
        public List<string> SanitizedDescription { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("description")]
        public List<string> Description { get; set; }

    }
    public class MasteryTree
    {
        [JsonProperty("Resolve")]
        public List<MasterTreeList> Resolve { get; set; }
        [JsonProperty("Ferocity")]
        public List<MasterTreeList> Ferocity { get; set; }
        [JsonProperty("Cunning")]
        public List<MasterTreeList> Cunning { get; set; }
    }
    public class MasterTreeList
    {
        [JsonProperty("MasteryItems")]
        public List<MasteryTreeItem> MasteryItems { get; set; }

    }
    public class MasteryTreeItem
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }
        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }
    public class Image
    {
        [JsonProperty("full")]
        public string Full { get; set; }
        [JsonProperty("group")]
        public string Group { get; set; }
        [JsonProperty("sprite")]
        public string Sprite { get; set; }
        [JsonProperty("h")]
        public int H { get; set; }
        [JsonProperty("w")]
        public int W { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
