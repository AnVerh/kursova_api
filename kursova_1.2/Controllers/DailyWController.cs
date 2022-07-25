using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kursova_1._2.AHoroscope;

namespace kursova_1._2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DailyWController : ControllerBase
    {
        [HttpGet(Name = "Daily Western")]
        public AModel get_daily_w(string sign, string day)
        {
            AClient client = new AClient();
            return client.GetDailyHoro(sign, day).Result;
        }
    }
}
