using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grindpipe_app
{
    class MetaDataLibrary
    {
        public string library_name { get; set; }
        public DateTime library_date { get; set; }
        public int library_num_collections { get; set; }
        public string library_path { get; set; }
        public string inventory { get; set; } // opis
    }
}
