using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grindpipe_app
{
    class MetaDataCollection
    {
        public string library_name { get; set; }
        public string collection_name { get; set; }
        public DateTime collection_date { get; set; }
        public string collection_path { get; set; }
        public int collection_num_images { get; set; }

    }
}
