using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using LolMetrics.API.Models;
using System.IO;
using Newtonsoft.Json;

namespace LolMetrics.API.BL
{
    public class Caching
    {
        const string path = (@"C:\lolservices.txt");
        public bool CacheSet(StaticData data)
        {

            // Look for cache key.
            if (!DoesFileExist())
            {
                using (StreamWriter file = File.CreateText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, data);
                }
            }
            return false;
       
        }
        public StaticData CacheGet()
        {

            // Look for cache key.
                var reader = new StreamReader(path);
                var temp = reader.ReadToEnd();
            //serialize object directly into file stream
            var staticData = JsonConvert.DeserializeObject<StaticData>(temp);
            return staticData;

        }
        public bool DoesFileExist()
        {
            var file = File.ReadAllLines(path);
            if (!file.Any())
            {
                return false;
            }
            return true;
        }


    }
}
