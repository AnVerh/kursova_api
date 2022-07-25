using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kursova_1._2.CHoroscope;

namespace kursova_1._2.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class DailyChController : ControllerBase
    {
        [HttpGet(Name = "Daily Chinese")]
        public CModel get_daily_ch(string sign,string day)
        {
            CClient client = new CClient();
            return client.DailyHoroscope(sign,day).Result;
        }
    }
    
}
