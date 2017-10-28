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
        static string apiKey = "?api_key=RGAPI-8eba60af-8790-4a13-96c3-fc9a445f260d";

        public string GetSummonerByName(string summoner)
        {
            var url = BuildSummonerUrl(summoner);
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.SerializeObject(resultString);
            return result;
        }
        public Matches GetMatchesById(string summoner)
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

        public string GetData(string summoner, string url)
        {
            Uri uri = new Uri(url + summoner + apiKey);
            var response = Get(uri);
            var result = ReadAsString(response);
            return result.ToString();
        }
        public HttpResponseMessage Get(Uri uri)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(uri).Result;
            response.EnsureSuccessStatusCode();

            return response;
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
            string getChampionUrl = "https://na1.api.riotgames.com/lol/platform/v3/champions/";
            Uri url = new Uri(getChampionUrl + id + apiKey);
            return url;
        }
    }
}