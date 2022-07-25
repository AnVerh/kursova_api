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
    public class WeeklyChController : ControllerBase
    {
        [HttpGet(Name = "Weekly Chinese")]
        public CModel get_monthly_ch(string sign)
        {
            CClient client = new CClient();
            return client.WeeklyHoroscope(sign).Result;
        }
    }
}
