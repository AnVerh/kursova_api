using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kursova_1._2.ChTranslate.ChTranslateModels
{
    public class RequestModel
    {
        public string fromLang { get; set; }
        public string text { get; set; }
        public string to { get; set; }
    }
}
