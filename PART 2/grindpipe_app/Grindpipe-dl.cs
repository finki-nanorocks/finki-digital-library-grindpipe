using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grindpipe_app
{
    public partial class Grindpipe_dl : Form
    {
        List<string> digital_library, digital_collection, digital_images;

        ClassesDigitalLibrary dl = new ClassesDigitalLibrary();
        ClassesImageMagic c = new ClassesImageMagic();
        public Grindpipe_dl()
        {
            InitializeComponent();
        }

        private void Grindpipe_dl_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

           digital_library =  dl.select_all_from_library();
           for (int i = 0; i < digital_library.Count; i++ )
           {
               string[] tmp = digital_library[i].Split(' ');
               lb_library.Items.Add(tmp[0]);
           }
        }

        private void Images_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openDigiralLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_sel_Click(object sender, EventArgs e)
        {
            if(lb_library.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Digital Library from, Digital Librarys list.");
                return;
            }
            else
            {
                string library_name = lb_library.SelectedItem.ToString();
                string library_path = dl.select_library_name_get_library_path(library_name);
                if (library_path != "")
                {
                    dl.current_digital_library_overview_and_collection(library_path, library_name);
                }
                else
                {
                    MessageBox.Show("Path is empty.");
                }


            }
        }

        private void bnt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://grindpipe.ml/Contact.php");
            Process.Start(sInfo);
        }

        private void communityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://grindpipe.ml/Community.php");
            Process.Start(sInfo);  
        }

        private void documentationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://grindpipe.ml/Documentation.php");
            Process.Start(sInfo);  
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://grindpipe.ml/index.php");
            Process.Start(sInfo);  
           


        }

        private void btn_img_editor_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_image_keyword.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Image.");
                return;
            }
            else
            {
                string image_keyword = lb_image_keyword.SelectedItem.ToString();
                string[] tmp = image_keyword.Split('/');
                string image_path = dl.select_image_path_for_image_name(tmp[0],tmp[2]);
                c.btn_info_and_view(image_path, c.FINISH_PATH, 2, true);
            }
        }

        private void btn_new_dl_Click(object sender, EventArgs e)
        {
            string item = dl.library_new_metod("Digital Library name", "Enter the name of the Digital Library","Where do you want to create Digital Library?");
            if (item != "")
            {
                string[] item_part = item.Split(' ');
                string library_name = item_part[0];
                for (int i = 0; i < lb_library.Items.Count; i++ )
                {
                    if (lb_library.Items[i].ToString().Contains(library_name))
                    {
                        MessageBox.Show("You can't create digital library with same name.");
                        return;
                    }
                }

                string library_path = item_part[1];
                dl.insert_to_library(library_name, library_path);
                dl.create_digital_library(library_path, library_name);
                lb_library.Items.Add(item_part[0]);
                //proveri dali vo digitali library lista da se dodade itemov od ime,date, pateka
            }
            
        }

        private void lb_library_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_collection.Items.Clear();
            lb_images.Items.Clear();
            if(lb_library.SelectedIndex != -1)
            {
              //  MessageBox.Show(lb_library.SelectedItem.ToString());
                digital_collection = dl.select_from_collection_where_library_name_is(lb_library.SelectedItem.ToString());
                for (int i = 0; i < digital_collection.Count; i++)
                {
                    string[] tmp = digital_collection[i].Split(' ');
                    lb_collection.Items.Add(tmp[0]);
                }

            }
        }

        private void btn_new_coll_Click(object sender, EventArgs e)
        {
            if(lb_library.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Digital Library.");
            }
            else
            {
                string collection_name = dl.ShowDialog("Collection name", "Enter the name of the Collection", "col_").Replace(" ", string.Empty);
                if (collection_name == "" || collection_name == null)
                {
                    MessageBox.Show("Failed, to create.");
                    return;
                }
                for (int i = 0; i < lb_collection.Items.Count; i++ )
                {
                    if(lb_collection.Items[i].ToString().Contains(collection_name))
                    {
                        MessageBox.Show("You can't create collection with same name.");
                        return;
                    }
                }
                string library_name = lb_library.SelectedItem.ToString();
                string library_path = dl.select_library_name_get_library_path(library_name);
         
                dl.insert_to_collection(library_name, "col_" + collection_name, library_path + "\\" + library_name + "\\col_" + collection_name);
                dl.create_collection(library_path + "//" + library_name , "col_" + collection_name); //for bat
                lb_collection.Items.Add("col_"+collection_name);
               
            }
        }

        private void lb_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_images.Items.Clear();
            if (lb_collection.SelectedIndex != -1 && lb_library.SelectedIndex != -1)
            {
                digital_images = dl.select_from_image_where_collection_name_is(lb_collection.SelectedItem.ToString(), lb_library.SelectedItem.ToString());
                for (int i = 0; i < digital_images.Count; i++)
                {
                    string[] tmp = digital_images[i].Split(' ');
                    lb_images.Items.Add(tmp[0]);
                }
            }


        }

        private void btn_keyword_Click(object sender, EventArgs e)
        {
            lb_image_keyword.Items.Clear();
            if (cb_keyword.Text != "" && cb_keyword.Text != null)
            {
                digital_images = dl.select_images_by_keyword(cb_keyword.Text.ToString());
                if(digital_images.Count == 0)
                {
                    MessageBox.Show("There are no images with that keyword");
                    return;
                }
                else
                {
                    MessageBox.Show("Found: " + digital_images.Count + " image/s with keyword " + cb_keyword.Text);
                    for (int i = 0; i < digital_images.Count; i++)
                    {
                      //  string[] tmp = digital_images[i].Split(' ');
                        lb_image_keyword.Items.Add(digital_images[i]);
                    }

                }

            }
            else
            {
                MessageBox.Show("Fill the box with only text word that it's keyword");
            }
        }

   

        private void btn_view_add_dl_Click(object sender, EventArgs e)
        {
            if (lb_library.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Digital Library.");
                return;
            }

               Global_lib.GlobalVar_lib = lb_library.SelectedItem.ToString();
                // should supplement
                ViewAndAddLibrary v = new ViewAndAddLibrary();
               
                v.Show();
          
        }

        private void btn_view_add_col_Click(object sender, EventArgs e)
        {
            if (lb_collection.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Collection.");
                return;
            }
            Global_coll.GlobalVar_coll = lb_collection.SelectedItem.ToString() + "/" + lb_library.SelectedItem.ToString();
                ViewAndAddCollection v = new ViewAndAddCollection();
                v.Show();
        }

        private void btn_view_add_img_Click(object sender, EventArgs e)
        {
            if (lb_images.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select image.");
            }
            else
            {
                Global_img.GlobalVar_img = lb_images.SelectedItem.ToString()+" "+lb_collection.SelectedItem.ToString()+" "+lb_library.SelectedItem.ToString();
                // should supplement
                ViewAndAddImage v = new ViewAndAddImage();
                v.Show();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //lb_library.Items.Clear();
            //lb_collection.Items.Clear();
            //lb_images.Items.Clear();

            //digital_library = dl.select_all_from_library();
            //for (int i = 0; i < digital_library.Count; i++)
            //{
            //    string[] tmp = digital_library[i].Split(' ');
            //    lb_library.Items.Add(tmp[0]);
            //}
            MessageBox.Show("Comming in next version.");
        }

        private void createDigitalLibraryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string item = dl.library_new_metod("Digital Library name", "Enter the name of the Digital Library", "Where do you want to create Digital Library?");
            if (item != "")
            {
                string[] item_part = item.Split(' ');
                string library_name = item_part[0];
                string library_path = item_part[1];
                dl.create_digital_library(library_path, library_name);
                lb_library.Items.Add(item_part[0]);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lb_collection.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Collection, from Collections list.");
                return;
            }
            else
            {
                string library_name = lb_library.SelectedItem.ToString();
                string library_path = dl.select_library_name_get_library_path(library_name);
                string collection_name = lb_collection.SelectedItem.ToString();
                string collection_path = dl.select_collection_path_for_collection_name(collection_name, library_name);
                
                if ((library_path != "" || library_path != null))
                {
                    dl.current_digital_library_overview_and_collection(library_path + "\\" +library_name, collection_name);
                }
                else
                {
                    MessageBox.Show("Collection_path is empty. Collection not exist.");
                   
                }


            }
        }

        private void btn_new_img_Click(object sender, EventArgs e)
        {

            if(lb_collection.SelectedIndex == -1)
            {

                MessageBox.Show("You must first select Collection.");
                return;


            }else{
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult dr = ofd.ShowDialog();
                string path = ofd.FileName.ToString(); // take path (zema pateka od izbraj fajl)

                if (path.Contains(".jpg") || path.Contains(".png") || path.Contains(".gif") || path.Contains(".ico") || path.Contains(".JPG") || path.Contains(".PNG") || path.Contains(".GIF") || path.Contains(".ICO"))
                {
                   string image_path = ofd.FileName.ToString(); // ja pokazuva celosnata pateka od izbraj fajl
                   string collection_path = dl.select_collection_path_for_collection_name(lb_collection.SelectedItem.ToString(),lb_library.SelectedItem.ToString());
                  
                   string image_name = Path.GetFileName(image_path); //ja zema slikata od pateka
                  
                   for (int i = 0; i<lb_images.Items.Count; i++ ) // proverka za isto ime vo lista
                   {
                       if (image_name.Contains(lb_images.Items[i].ToString()))
                       {
                           MessageBox.Show("Can't add image with same Image name."); return;
                       }
                   }

                  //// forma za keyword
                   string image_keyword = dl.ShowKeyword("Select keyword", "Select keyword for Image");
                   if (image_keyword == "" || image_keyword == null)
                   {
                       MessageBox.Show("You must select keyword.");
                       return;
                   }
                   dl.current_image_move(image_name, Path.GetDirectoryName(image_path), collection_path); // za bat
                   lb_images.Items.Add(image_name); // vo lista
                   dl.insert_to_image(image_name, lb_collection.SelectedItem.ToString(), lb_library.SelectedItem.ToString(), collection_path+"\\"+image_name, image_keyword);
                }
                else
                {
                    MessageBox.Show("You haven't uploaded any image or file isn't an image");
                    return;
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (lb_images.SelectedIndex == -1 && lb_collection.SelectedIndex == -1 || lb_library.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Image, from Images list.");
                return;
            }
            else
            {
                string image_path = dl.select_image_path_for_image_name(lb_images.SelectedItem.ToString(), lb_library.SelectedItem.ToString());
                if (image_path == "" || image_path == null) return;
                c.btn_info_and_view(image_path, c.FINISH_PATH, 2, true);
            }
        }

        private void btn_del_sel_db_Click(object sender, EventArgs e)
        {
            if (lb_library.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Digital Library");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Аre you sure you want to delete Digital Library \nwith name: " + lb_library.SelectedItem.ToString(), "Digital Library delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string lb_path = dl.select_library_name_get_library_path(lb_library.SelectedItem.ToString());
                    dl.delete_row_by_library_name_in_library(lb_library.SelectedItem.ToString());
                    dl.delete_row_by_library_name_in_collection(lb_library.SelectedItem.ToString());
                    dl.delete_row_by_library_name_in_image(lb_library.SelectedItem.ToString());
                


                    dl.del_dl_or_del_col(lb_path, lb_library.SelectedItem.ToString());
                    for (int i = 0; i < lb_library.SelectedItems.Count; i++)
                        lb_library.Items.Remove(lb_library.SelectedItems[i]);
                }
              
              

            }
        }

        private void btn_del_sel_coll_Click(object sender, EventArgs e)
        {
            if (lb_collection.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Collection");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Аre you sure you want to delete Collection \nwith name: " + lb_collection.SelectedItem.ToString(), "Collection delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string collection_path = dl.select_collection_path_for_collection_name(lb_collection.SelectedItem.ToString(),lb_library.SelectedItem.ToString());
                    DirectoryInfo parentDir = Directory.GetParent(collection_path);
              //      MessageBox.Show(parentDir.ToString());
                    dl.delete_row_by_collection_name_in_collection(lb_collection.SelectedItem.ToString(), lb_library.SelectedItem.ToString());
                    dl.del_dl_or_del_col(parentDir.ToString(), lb_collection.SelectedItem.ToString());
                    dl.delete_row_for_image_coll_and_lb(lb_collection.SelectedItem.ToString(), lb_library.SelectedItem.ToString());
                    for (int i = 0; i < lb_collection.SelectedItems.Count; i++)
                        lb_collection.Items.Remove(lb_collection.SelectedItems[i]);
                }
               


            }
        }

        private void disclaimersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Any manual changes that are made to the files of the software will not be updated.");
        }

        private void btn_del_sel_img_Click(object sender, EventArgs e)
        {
            if (lb_collection.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Image");
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Аre you sure you want to delete image \nwith name: " + lb_images.SelectedItem.ToString(), "Image delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        string image_path = dl.select_image_path_for_image_name(lb_images.SelectedItem.ToString(), lb_library.SelectedItem.ToString());
                        DirectoryInfo parentDir = Directory.GetParent(image_path);
                        dl.delete_row_for_image(lb_images.SelectedItem.ToString(), lb_collection.SelectedItem.ToString(), lb_library.SelectedItem.ToString());
                        dl.del_img_batfile(parentDir.ToString(), lb_images.SelectedItem.ToString());

                        for (int i = 0; i < lb_images.SelectedItems.Count; i++)
                            lb_images.Items.Remove(lb_images.SelectedItems[i]);
                    }
                }
                catch (Exception err) { }


            }
        }

        
    }
}
