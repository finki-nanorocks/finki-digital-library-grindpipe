using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace grindpipe_app
{
    static class Global_img
    {
        private static string _globalVar_img = "";

        public static string GlobalVar_img
        {
            get { return _globalVar_img; }
            set { _globalVar_img = value; }
        }
    }
    static class Global_coll
    {
        private static string _globalVar_coll = "";

        public static string GlobalVar_coll
        {
            get { return _globalVar_coll ; }
            set { _globalVar_coll = value; }
        }
    }
    static class Global_lib
    {
        private static string _globalVar_lib = "";

        public static string GlobalVar_lib
        {
            get { return _globalVar_lib; }
            set { _globalVar_lib = value; }
        }
    }
    class ClassesDigitalLibrary
    {
        ClassesImageMagic classesIM = new ClassesImageMagic();
        public string START_PATH_BAT_DL = Path.GetTempPath() + "digital_library_file.bat"; // finding path of the application
        public string FINISH_PATH_DL = @"start """" /d";
        public string ShowDialog(string text, string caption, string type = "dl_")
        {
            Form prompt = new Form()
            {
                Width = 380,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 30, Top = 20, Text = text };
            Label textLabel1 = new Label() { Left = 7, Top = 55, Text = type };
            TextBox textBox = new TextBox() { Left = 30, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "Add", Left = 231, Width = 100, Top = 75, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textLabel1);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        public string ShowKeyword(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 380,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 30, Top = 20, Text = text };
            ComboBox cb = new ComboBox() { Left = 30, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "Add keyword", Left = 231, Width = 100, Top = 75, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            string[] tmp_l = { "sport", "love", "fanny", "programming", "newyear", "sex", "girls", "boys", "vacation", "faculty", "cars", "nature", "drinks", "party", "space", "technology", "tv", "shopping","beauty","style","other" }; 
            
            cb.Items.AddRange(tmp_l);

            prompt.Controls.Add(cb);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            try
            {
                return prompt.ShowDialog() == DialogResult.OK ? cb.SelectedItem.ToString() : "other";
            }catch(Exception err)
            {
              //  MessageBox.Show("You must select keyword.");
                return "";
            }
        }
        public string library_new_metod(string text_dialog, string caption_dialog,string f_description)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = f_description;
            f.ShowNewFolderButton = false;
            f.ShowDialog();


            string path = f.SelectedPath.ToString();
            if (path == "" || path == null)
            {
                MessageBox.Show("Failed, to create.");
                return "";
            }
            string name = ShowDialog(text_dialog, caption_dialog).Replace(" ", string.Empty);
            //MessageBox.Show(name.Replace(" ", string.Empty));
            
            if(name == "" || name == null || path == "" || path == null)
            {
                MessageBox.Show("Failed, to create.");
                return "";
            }
            else
            {
                return "dl_" + name + " "+path.ToString();
            }
        }
        public string rm_dir(string name)
        {
            return "rmdir " + name + " /s /q";
        }
        public string del_img_code(string name)
        {
            return "del " + name ;
        }
        public void del_img_batfile(string apsolut_path, string image_name)
        {
            string code = "";
            code += del_img_code(image_name);
            classesIM.MAKE_BAT_AND_START(START_PATH_BAT_DL, apsolut_path, code);
        }
        public void del_dl_or_del_col(string apsolut_path, string lib_name_or_col_name)
        {
            string code = "";
            code += rm_dir(lib_name_or_col_name);
            classesIM.MAKE_BAT_AND_START(START_PATH_BAT_DL, apsolut_path, code);
        }
        public string make_dir(string name)
        {
            return "mkdir " + name;
        }
        public string move_file(string first_path, string last_path) // from path to path 
        {
            return "move " + first_path + " " + last_path;
        }
        public void create_digital_library(string apsolut_path, string library_name)
        {
            string code = "";
            code += make_dir(library_name);
            classesIM.MAKE_BAT_AND_START(START_PATH_BAT_DL, apsolut_path, code);
        }
        public void current_digital_library_overview_and_collection(string apsolut_path, string library_name)
        {
            string code = "start "+library_name;
            classesIM.MAKE_BAT_AND_START(START_PATH_BAT_DL, apsolut_path, code);
        }
        public void current_image_move(string image_name,string image_path, string collection_path)
        {
            string code = "\ncopy " + image_name+" "+collection_path;
           // MessageBox.Show(START_PATH_BAT_DL + "\n" + image_path + "\n" + code);
            classesIM.MAKE_BAT_AND_START(START_PATH_BAT_DL, image_path, code);
        }
        public void create_collection(string apsolut_path, string collection_name)
        {
            create_digital_library(apsolut_path, collection_name);
        }
        public string add_image(string image_path, string collection_path)
        {
            string code = "";
            code += move_file(image_path, collection_path);
            return code;
        }






        /*                      All about data base                     */

        public static string database_path = System.Configuration.ConfigurationManager.ConnectionStrings["grindpipe_db"].ConnectionString.ToString();
        SqlConnection con = new SqlConnection(database_path.ToString());


        public List<string> select_all_from_library_metadata()
        {
            List<string> l = new List<string>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM library", con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string[] tmp = r[2].ToString().Split(' ');
                    string full = r[1].ToString() + " " + tmp[0] + " " + r[3].ToString() + " " + r[4].ToString() + " " + r[5].ToString();
                    l.Add(full); 
                }
                con.Close();
                return l;

            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load library metadata from database.");
                return l;

            }
        }
        public List<string> select_all_from_collection_metadata()
        {
            List<string> l = new List<string>();
            string path = "";
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM collection", con);
                con.Open();
               // cmd.Parameters.AddWithValue("@collection_name", collection_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string[] tmp = r[3].ToString().Split(' ');
                    path = r[1].ToString() + " " + r[2].ToString() + " " + tmp[0] + " " + r[4].ToString() + " " + r[5].ToString(); // return string of library_path
                    l.Add(path);
                }
                con.Close();
                return l;

            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load collections data from database.");
                return l;
            }
        }
        public List<string> select_all_from_library()
        {
            List<string> l = new List<string>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM library", con);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    l.Add(r.GetString(1) + " " + r.GetString(4)); // return list of library_name and library_path
                }
                con.Close();
                return l;
                
            }catch(Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load library data from database.");
                return l;
                
            }
        }
        public List<string> select_from_collection_where_library_name_is(string library_name)
        {
         
            List<string> l = new List<string>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM collection WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    l.Add(r.GetString(2) + " " + r.GetString(4)); // return list of library_name and library_path
                }
                con.Close();
                return l;
                
            }
            catch(Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load collections from database.");
                return l;
            }
        }
        public string select_collection_path_for_collection_name(string collection_name,string library_name)
        {

            string path = "";
            try
            {
               // MessageBox.Show(collection_name + "\n" + library_name);
                SqlCommand cmd = new SqlCommand("SELECT collection_path FROM collection WHERE library_name=@library_name AND collection_name=@collection_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    path = r[0].ToString(); // return string of library_path
                    break;
                }
                con.Close();
                return path;

            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load collections path from database.");
                return path;
            }
        }
        public string select_image_path_for_image_name(string image_name,string library_name, string collection_name)
        {

            string path = "";
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM image WHERE image_name=@image_name AND library_name=@library_name AND collection_name=@collection_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@image_name", image_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    path = r.GetString(7); // return string of library_path
                    break;
                }
                con.Close();
                return path;

            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load image path from database.");
                return path;
            }
        }
      
        public string select_library_name_get_library_inventory(string library_name)
        {
            try
            {
                string path = "";
                SqlCommand cmd = new SqlCommand("SELECT * FROM library WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    path += r.GetString(5); // return library_path
                }
                con.Close();
                return path;

            }
            catch (Exception err)
            {
                con.Close();
                //MessageBox.Show("Can't load collections from database.");
                return "";
            }
        }
        public string select_library_name_get_library_path(string library_name)
        {
            try
            {
                string path = "";
                SqlCommand cmd = new SqlCommand("SELECT * FROM library WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    path+= r.GetString(4); // return library_path
                }
                con.Close();
                return path;

            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't load collections from database.");
                return "";
            }
        }
        public List<string> select_from_image_where_collection_name_is(string collection_name, string library_name)
        {
            List<string> l = new List<string>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM image WHERE collection_name=@collection_name AND library_name = @library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string path = r.GetString(7);

                    l.Add(r.GetString(1) + " " + path); // return list of library_name and library_path
                }
                con.Close();
                return l;
            }
            catch(Exception err)
            {
                MessageBox.Show("Can't select data from image table in database.");
                return l;
            }

        }
        public List<string> select_images_by_keyword(string image_keyword)
        {
            List<string> l = new List<string>();

            con.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM image WHERE image_keyword=@image_keyword", con);
            con.Open();
            cmd.Parameters.AddWithValue("@image_keyword", image_keyword);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                l.Add(r.GetString(1) + "/" + r.GetString(2) + "/" + r.GetString(3)); // return list of library_name and library_path
            }
            con.Close();
            return l;
        }

        public string select_from_image_selected(string image_name,string collection_name, string library_name)
        {
            string l = "";

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM image WHERE image_name = @image_name AND collection_name=@collection_name AND library_name = @library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@image_name", image_name);
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string width = r[4].ToString();
                    string height = r[5].ToString();
                    string image_path = r[7].ToString();
                    string print = r[8].ToString();
                    string inventory = r[9].ToString();
                    string keyword = r[10].ToString();

                    if(width==null && height==null || width == "" || height == "")
                    {
                        width = height = "0";
                    }
                    if(print == "" || print==null)
                    {
                        print = "false";
                    }
                    if(inventory == "" || inventory == null)
                    {
                        inventory = "max20caracters";
                    }
                    if(keyword == "" || keyword == null)
                    {
                        keyword = "other";
                    }
                    l = width + "/" + height + "/" + image_path + "/" + print + "/" + inventory + "/" + keyword; // return list item of all variables
                }
                con.Close();
                return l;
            }
            catch (Exception err)
            {
                MessageBox.Show("Can't select data from image table in database.");
                return l;
            }

        }
        public void insert_to_library(string library_name, string library_path)
        {
            try
            {
                DateTime library_date = DateTime.Now;
                SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[library] ([library_name],[library_date], [library_path]) VALUES (@library_name,@library_date, @library_path)", con);
                insert.Parameters.AddWithValue("@library_name", library_name);
                insert.Parameters.AddWithValue("@library_date", library_date);
                insert.Parameters.AddWithValue("@library_path", library_path);
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }catch(Exception err)
            {
                con.Close();
            }
        }
        public void insert_to_collection(string library_name, string collection_name, string collection_path)
        {
            try
            {
                DateTime collection_date = DateTime.Now;
                SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[collection] ([library_name], [collection_name], [collection_date], [collection_path]) VALUES (@library_name,@collection_name,@collection_date, @collection_path)", con);
                insert.Parameters.AddWithValue("@library_name", library_name);
                insert.Parameters.AddWithValue("@collection_name", collection_name);
                insert.Parameters.AddWithValue("@collection_date", collection_date);
                insert.Parameters.AddWithValue("@collection_path", collection_path);
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
            }
        }
        public void insert_to_image(string image_name, string collection_name,string library_name, string image_path, string image_keyword)
        {
            try
            {

                SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[image] ([image_name], [collection_name],[library_name], [image_path], [image_keyword]) VALUES (@image_name,@collection_name,@library_name, @image_path, @image_keyword)", con);
                insert.Parameters.AddWithValue("@image_name", image_name);
                insert.Parameters.AddWithValue("@collection_name", collection_name);
                insert.Parameters.AddWithValue("@library_name", library_name);
                insert.Parameters.AddWithValue("@image_path", image_path);
                insert.Parameters.AddWithValue("@image_keyword", image_keyword);
                con.Open();
                insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
            }
        }
       

        public void update_library(string library_name,string library_date,string library_num_collections,string library_inventory)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE library SET library_date=@library_date, library_num_collections=@library_num_collections,library_inventory=@library_inventory  WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.Parameters.AddWithValue("@library_date", Convert.ToDateTime(library_date));
                cmd.Parameters.AddWithValue("@library_num_collections", library_num_collections);
                cmd.Parameters.AddWithValue("@library_inventory", library_inventory);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't update selected digital library");
                return;
            }



        }
        public void update_collection(string library_name,string collection_name, string collection_date, string collection_num_images)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE collection SET collection_date=@collection_date, collection_num_images=@collection_num_images WHERE collection_name=@collection_name AND library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@collection_date", Convert.ToDateTime(collection_date));
                cmd.Parameters.AddWithValue("@collection_num_images", collection_num_images);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't update selected collection.");
                return;
            }



        }
        public void update_image(string image_name, string collection_name, string library_name, string image_width, string image_height, string image_extension, string image_path, string image_allow_print, string image_inventory, string image_keyword)
        {
            try
            {
            if (image_extension == "" || image_extension == null) image_extension = "max20caracters";
            SqlCommand cmd = new SqlCommand("UPDATE image SET image_width=@image_width,image_height=@image_height,image_extension=@image_extension,image_path=@image_path,image_allow_print=@image_allow_print,image_inventory=@image_inventory,image_keyword=@image_keyword WHERE image_name=@image_name AND collection_name=@collection_name AND library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@image_width", image_width);
                cmd.Parameters.AddWithValue("@image_height", image_height);
                cmd.Parameters.AddWithValue("@image_extension", image_extension);
                cmd.Parameters.AddWithValue("@image_path", image_path);
                cmd.Parameters.AddWithValue("@image_allow_print", image_allow_print);
                cmd.Parameters.AddWithValue("@image_inventory", image_inventory);
                cmd.Parameters.AddWithValue("@image_keyword", image_keyword);
                cmd.Parameters.AddWithValue("@image_name", image_name);
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
              

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't update selected image.");
                return;
            }

        }


        public void delete_row_for_image_coll_and_lb(string collection_name, string library_name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM image WHERE collection_name=@collection_name AND library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.ExecuteNonQuery();
                con.Close();
               // MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't delete image from database.");
            }
        }
        public void delete_row_for_image(string image_name, string collection_name, string library_name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM image WHERE image_name=@image_name AND collection_name=@collection_name AND library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@image_name", image_name);
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                   cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't delete image from database.");
            }
        }
        public void delete_row_by_collection_name_in_collection(string collection_name, string library_name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM collection WHERE collection_name=@collection_name AND library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@collection_name", collection_name);
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't delete collection from database.");
            }
        }
        public void delete_row_by_library_name_in_collection(string library_name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM collection WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.ExecuteNonQuery();
                con.Close();
               
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't delete collection from collection database.");
            }
        }
        public void delete_row_by_library_name_in_library(string library_name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM library WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't delete library from library database.");
            }
        }
        public void delete_row_by_library_name_in_image(string library_name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM image WHERE library_name=@library_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@library_name", library_name);
                cmd.ExecuteNonQuery();
                con.Close();
               // MessageBox.Show("Success!");
            }
            catch (Exception err)
            {
                con.Close();
                MessageBox.Show("Can't delete library from image database.");
            }
        }

    }


}
