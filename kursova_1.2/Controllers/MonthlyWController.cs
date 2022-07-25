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
    public class MonthlyWController : ControllerBase
    {
        [HttpGet(Name = "Monthly Western")]
        public AModel get_monthly_w(string sign)
        {
            AClient client = new AClient();
            return client.GetMonthlyHoro(sign).Result;
        }
    }
}
