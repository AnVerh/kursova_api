using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using kursova_1._2.Constans;
using Newtonsoft.Json;


namespace kursova_1._2.CHoroscope
{
    public class CClient
    {
        public HttpClient client;
        private static string _ApiKey;
        private static string _ApiHost;
        public CClient() 
        {
            _ApiKey = Constant.ApiKey;
            _ApiHost = Constant.ApiHostCh;
            client = new HttpClient();
        }
        public async Task<CModel> MonthlyHoroscope(string sign)
        {
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://daily-live-chinese-horoscope-free.p.rapidapi.com/horoscope-monthly/{sign}"),
                Headers =
                {
                    { "X-RapidAPI-Key", _ApiKey },
                    { "X-RapidAPI-Host", _ApiHost},
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CModel>(result);
        }
        public async Task<CModel> WeeklyHoroscope(string sign)
        {

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://daily-live-chinese-horoscope-free.p.rapidapi.com/horoscope-weekly/{sign}"),
                Headers =
                {
                    { "X-RapidAPI-Key", _ApiKey },
                    { "X-RapidAPI-Host", _ApiHost},
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CModel>(result);
        }
        public async Task<CModel> DailyHoroscope(string sign, string day)
        {
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://daily-live-chinese-horoscope-free.p.rapidapi.com/horoscope/{sign}/{day}"),
                Headers =
                {
                    { "X-RapidAPI-Key", _ApiKey },
                    { "X-RapidAPI-Host", _ApiHost},
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CModel>(result);
        }
    }
}
