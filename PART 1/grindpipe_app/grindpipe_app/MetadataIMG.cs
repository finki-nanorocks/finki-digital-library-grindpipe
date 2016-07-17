using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grindpipe_app
{
    class MetadataIMG
    {
        public DateTime data { get; set; }
        public string name { get; set; }
        public string creator { get; set; }
        public string keyword { get; set; }
        public string inventory { get; set; } // opis
        public string language { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string extension { get; set; }
        public string path { get; set; }
        public int allow_print { get; set; }

       
    }
}
