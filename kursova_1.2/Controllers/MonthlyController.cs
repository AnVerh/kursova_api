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
    public class MonthlyChController : ControllerBase
    {
         [HttpGet(Name = "Monthly Chinese")]
         public CModel get_monthly_ch(string sign)
         {
            CClient client = new CClient();
            return client.MonthlyHoroscope(sign).Result;
         }
    }
}
