using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kursova_1._2.ChTranslate.ChTranslateModels;
using kursova_1._2.ChTranslate;
    

namespace kursova_1._2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChTranslateController : ControllerBase
    {
        [HttpPost(Name = "Cheap Translate")]
        public TranslateModel ChTranslate(string fromLang, string text, string to)
        {
            ChTranslateClient client = new ChTranslateClient();
            return client.CheapTranslate(fromLang, text, to).Result;
        }
    }
    
}
