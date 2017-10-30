using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using LolMetrics.API.Classes;

namespace LolMetrics.API.Factories
{
    public class SummonerFactory
    {
        static string apiKey = "?api_key=RGAPI-4d2ed532-6f02-44b3-9634-04c0f89f2c54";
        static string apiKeyParams = "api_key=RGAPI-4d2ed532-6f02-44b3-9634-04c0f89f2c54";

        public string GetSummonerByName(string summoner)
        {
            var url = BuildSummonerUrl(summoner);
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.SerializeObject(resultString);
            return result;
        }
        public Matches GetMatchesBySummoner(string summoner)
        {
            Summoner tempSummoner = JsonConvert.DeserializeObject<Summoner>(GetSummonerByName(summoner));
            var url = BuildMatchesUrl(tempSummoner.AccountId.ToString());
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Matches>(resultString);
            return result;

        }
        public Champion GetChampionById(int id)
        {
            var url = BuildChampionUrl(id);
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Champion>(resultString);
            return result;
        }
        public Matches GetMatchesById(string id)
        {
            var url = BuildMatchesUrl(id);
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Matches>(resultString);
            return result;
        }

        public Matches GetMatchesInfoById(string id)
        {
            var url = BuildMatchesUrl(id);
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Matches>(resultString);
            return result;
        }
        public Champions GetChampions()
        {
            var url = BuildChampionUrl();
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Champions>(resultString);
            return result;
        }
        public Items GetItems()
        {
            var url = BuildItemsUrl();
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Items>(resultString);
            return result;
        }




        public HttpResponseMessage Get(Uri uri)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(uri).Result;
            response.EnsureSuccessStatusCode();

            return response;
        }
        public string GetData(string summoner, string url)
        {
            Uri uri = new Uri(url + summoner + apiKey);
            var response = Get(uri);
            var result = ReadAsString(response);
            return result.ToString();
        }
        private static string ReadAsString(HttpResponseMessage msg)
        {
            var response = msg.Content.ReadAsStringAsync().Result;

            return response;
        }





        public static Uri BuildSummonerUrl(string summoner)
        {
            string getSummonerUrl = "https://na1.api.riotgames.com/lol/summoner/v3/summoners/by-name/";
            Uri url = new Uri(getSummonerUrl + summoner + apiKey);
            return url;
        }
        public static Uri BuildMatchesUrl(string summonerId)
        {
            string getMatchesUrl = "https://na1.api.riotgames.com/lol/match/v3/matchlists/by-account/";
            Uri url = new Uri(getMatchesUrl + summonerId + apiKey);
            return url;
        }
        public static Uri BuildChampionUrl(int id)
        {
            string getChampionUrl = "https://na1.api.riotgames.com/lol/static-data/v3/champions/";
            string locale = "?locale=en_US&";
            Uri url = new Uri(getChampionUrl + id + locale + apiKeyParams);
            return url;
        }
        public static Uri BuildChampionUrl()
        {
            string getChampionUrl = "https://na1.api.riotgames.com/lol/static-data/v3/champions";
            string locale = "?locale=en_US&";
            string dataSort = "dataById=true&";
            Uri url = new Uri(getChampionUrl + locale + dataSort + apiKeyParams);
            return url;
        }
        public static Uri BuildItemsUrl()
        {
            string getItemsUrl = "https://na1.api.riotgames.com/lol/static-data/v3/items";
            string locale = "?locale=en_US&";
            Uri url = new Uri(getItemsUrl + locale + apiKeyParams);
            return url;
        }
        public static Uri BuildMatchInfoUrl(string id)
        {
            string getItemsUrl = "https://na1.api.riotgames.com/lol/match/v3/matches/";
            Uri url = new Uri(getItemsUrl + apiKey);
            return url;
        }
    }
}