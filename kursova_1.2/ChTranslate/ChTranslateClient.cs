using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using kursova_1._2.ChTranslate.ChTranslateModels;
using Newtonsoft.Json;

namespace kursova_1._2.ChTranslate
{
    public class ChTranslateClient
    {
		public async Task<TranslateModel> CheapTranslate(string fromlang, string text, string to)
		{
			var client = new HttpClient();
			RequestModel jsonReques = new RequestModel
			{
				fromLang = fromlang,
				text = text,
				to = to,
			};
			var json = JsonConvert.SerializeObject(jsonReques);
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri("https://cheap-translate.p.rapidapi.com/translate"),
				Headers =
				{
					{ "X-RapidAPI-Key", "1ebed1ec97msh55ca7fdfe5c1bcap1714f7jsnb3feba8e0a73" },
					{ "X-RapidAPI-Host", "cheap-translate.p.rapidapi.com" },
				},
				Content = new StringContent(json)
				{
					Headers =
					{
						ContentType = new MediaTypeHeaderValue("application/json")
					}
				}
			};
			var response = await client.SendAsync(request);
			response.EnsureSuccessStatusCode();
			var result = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TranslateModel>(result);
		}
	}
}
