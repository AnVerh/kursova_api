using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace kursova_1._2.Aztro
{
    public class Aztro_Client
    {
        public async Task<Aztro_Model> GetHoro(string sign, string day)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"https://sameer-kumar-aztro-v1.p.rapidapi.com/?sign={sign}&day={day}"),
                Headers =
                {
                    { "X-RapidAPI-Key", "1ebed1ec97msh55ca7fdfe5c1bcap1714f7jsnb3feba8e0a73" },
                    { "X-RapidAPI-Host", "sameer-kumar-aztro-v1.p.rapidapi.com" },
                },
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Aztro_Model>(result);
        }
        
    }
}
