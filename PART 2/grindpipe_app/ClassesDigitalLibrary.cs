using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace grindpipe_app
{
    class ClassesDigitalLibrary
    {
        public static string database_path = System.Configuration.ConfigurationManager.ConnectionStrings["grindpipe_db"].ConnectionString.ToString();
        SqlConnection con = new SqlConnection(database_path.ToString());

        public List<string> select_all_from_library(string library_name)
        {
            List<string> l = new List<string>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM library", con);
            con.Open();
            cmd.Parameters.AddWithValue("@library_name", library_name);
            SqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                l.Add(r.GetString(1)+" "+r.GetString(4)); // return list of library_name and library_path
            }

            return l;
            con.Close();

        }
        public List<string> select_from_collection_where_library_name_is(string library_name)
        {
            List<string> l = new List<string>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM collection WHERE library_name=@library_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@library_name", library_name);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                l.Add(r.GetString(2) + " " + r.GetString(4)); // return list of library_name and library_path
            }

            return l;
            con.Close();

        }
        public List<string> select_from_image_where_collection_name_is(string collection_name)
        {
            List<string> l = new List<string>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM image WHERE collection_name=@collection_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@collection_name", collection_name);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                l.Add(r.GetString(2) + " " + r.GetString(6)); // return list of library_name and library_path
            }

            return l;
            con.Close();

        }
    


        public void insert_to_library(string library_name, string library_path)
        {
            DateTime library_date = DateTime.Now;
                
            SqlCommand cmd = new SqlCommand("INSERT INTO library (library_name,library_date,library_path) VALUES(@library_name,@library_date,@library_path)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@library_name", library_name);
            cmd.Parameters.AddWithValue("@library_date", library_date);
            cmd.Parameters.AddWithValue("@library_path", library_path);

            cmd.ExecuteNonQuery();


            con.Close();
        }

        public void insert_to_collection(string collection_name, string collection_path)
        {
            DateTime collection_date = DateTime.Now;

            SqlCommand cmd = new SqlCommand("INSERT INTO collection (collection_name,collection_date,collection_path) VALUES(@collection_name,@collection_date,@collection_path)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@collection_name", collection_name);
            cmd.Parameters.AddWithValue("@collection_date", collection_date);
            cmd.Parameters.AddWithValue("@collection_path", collection_path);

            cmd.ExecuteNonQuery();


            con.Close();
        }

        public void insert_to_image()
        {

        }



    }
}
