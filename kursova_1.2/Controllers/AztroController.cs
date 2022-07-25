using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kursova_1._2.Aztro;

namespace kursova_1._2.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AztroController : ControllerBase
    {
        [HttpPost(Name = "Aztro")]
        public Aztro_Model AZHoro(string sign, string day)
        {
            Aztro_Client client = new Aztro_Client();
            return client.GetHoro(sign, day).Result;
        }
    }
    
}
