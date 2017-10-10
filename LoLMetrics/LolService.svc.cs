using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using LoLMetrics.Models;

namespace LoLMetrics
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LolService: ILolService
    {
        static string apiKey = "?api_key=RGAPI-7d77857b-7017-4406-99c0-51f339869a21";

        public Summoner GetSummonerByName (string summoner)
        {
            var url = BuildSummonerUrl(summoner);
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result = JsonConvert.DeserializeObject<Summoner>(resultString);
            return result;
        }
        public Matches GetMatchesById (string summoner)
        {
            Summoner tempSummoner = GetSummonerByName(summoner);
            var url = BuildMatchesUrl(tempSummoner.AccountId.ToString());
            var response = Get(url);
            var resultString = ReadAsString(response);
            var result= JsonConvert.DeserializeObject<Matches>(resultString);
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
            Uri url =new Uri ( getSummonerUrl + summoner + apiKey);
            return url;
        }
        public static Uri BuildMatchesUrl(string summonerId)
        {
            string getMatchesUrl = "https://na1.api.riotgames.com/lol/match/v3/matchlists/by-account/";
            Uri url = new Uri(getMatchesUrl + summonerId + apiKey);
            return url;
        }
    }
}
