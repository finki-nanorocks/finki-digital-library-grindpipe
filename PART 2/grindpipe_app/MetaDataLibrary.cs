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
        public string library_date { get; set; }
        public string library_num_collections { get; set; }
        public string library_path { get; set; }
        public string inventory { get; set; } // opis

        public MetaDataLibrary(string library_name="", string library_date="", string library_num_collections="", string library_path="", string inventory="")
        {
            this.library_name = library_name;
            this.library_date = library_date;
            this.library_num_collections = library_num_collections;
            this.library_path = library_path;
            this.inventory = inventory;
        }

         public override string ToString()
        {
            return library_name + " " + library_date + " " + library_num_collections + " " + library_path + " " + inventory;
        }
    }
}
