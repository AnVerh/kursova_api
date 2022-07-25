using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using kursova_1._2.Constans;

namespace kursova_1._2.AHoroscope
{
    public class AClient
    {
        public HttpClient client;
        private static string _ApiKey;
        private static string _ApiHost;
        public AClient()
        {
            _ApiKey = Constant.ApiKey;
            _ApiHost = Constant.ApiHostA;
            client = new HttpClient();
        }
        public async Task<AModel> GetDailyHoro(string sign, string day)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://astro-daily-live-horoscope.p.rapidapi.com/horoscope/{sign}/{day}"),
                Headers =
                {
                    { "X-RapidAPI-Key", _ApiKey },
                    { "X-RapidAPI-Host", _ApiHost },
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AModel>(result);
        }
        public async Task<AModel> GetWeeklyHoro(string sign)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://astro-daily-live-horoscope.p.rapidapi.com/horoscope-weekly/{sign}"),
                Headers =
                {
                    { "X-RapidAPI-Key", _ApiKey },
                    { "X-RapidAPI-Host", _ApiHost },
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AModel>(result);
        }
        public async Task<AModel> GetMonthlyHoro(string sign)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://astro-daily-live-horoscope.p.rapidapi.com/horoscope-monthly/{sign}"),
                Headers =
                {
                    { "X-RapidAPI-Key", _ApiKey },
                    { "X-RapidAPI-Host", _ApiHost },
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AModel>(result);
        }
    }
}
