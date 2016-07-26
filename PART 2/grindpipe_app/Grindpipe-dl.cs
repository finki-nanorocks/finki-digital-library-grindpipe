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
                string image_path = dl.select_image_path_for_image_name(tmp[0]);
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
                string library_path = item_part[1];
                dl.create_digital_library(library_path, library_name);
                lb_library.Items.Add(item_part[0]);
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
                string collection_name = dl.ShowDialog("Collection name", "Enter the name of the Collection", "col_");
                if (collection_name == "" || collection_name == "")
                {
                    MessageBox.Show("Failed, to create.");
                    return;
                }
                string library_name = lb_library.SelectedItem.ToString();
                string library_path = dl.select_library_name_get_library_path(library_name);
              //  MessageBox.Show(library_path);
                dl.insert_to_collection(library_name, "col_" + collection_name, library_path + "\\" + library_name + "\\col_" + collection_name);
                dl.create_collection(library_path + "//" + library_name , "col_" + collection_name);
                lb_collection.Items.Add("col_"+collection_name);
               
            }
        }

        private void lb_collection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_images.Items.Clear();
            if (lb_collection.SelectedIndex != -1)
            {
                digital_images = dl.select_from_image_where_collection_name_is(lb_collection.SelectedItem.ToString());
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
                MessageBox.Show("You must first select digital library.");
            }
            else
            {
                // should supplement
                ViewAndAddLibrary v = new ViewAndAddLibrary();
               
                v.Show();

            }
        }

        private void btn_view_add_col_Click(object sender, EventArgs e)
        {
            if (lb_collection.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select collection.");
            }
            else
            {
                // should supplement
                ViewAndAddCollection v = new ViewAndAddCollection();
                
                v.Show();

            }
        }

        private void btn_view_add_img_Click(object sender, EventArgs e)
        {
            if (lb_images.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select image.");
            }
            else
            {
                // should supplement
                ViewAndAddImage v = new ViewAndAddImage();
                v.Show();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lb_library.Items.Clear();
            lb_collection.Items.Clear();
            lb_images.Items.Clear();

            digital_library = dl.select_all_from_library();
            for (int i = 0; i < digital_library.Count; i++)
            {
                string[] tmp = digital_library[i].Split(' ');
                lb_library.Items.Add(tmp[0]);
            }
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
                if (library_path != "")
                {
                    dl.current_digital_library_overview_and_collection(library_path + "\\" +library_name, collection_name);
                }
                else
                {
                    MessageBox.Show("Path is empty.");
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

                if (path.Contains(".jpg") || path.Contains(".png") || path.Contains(".gif") || path.Contains(".ico"))
                {
                   string image_path = ofd.FileName.ToString(); // ja pokazuva celosnata pateka od izbraj fajl
                
                   string image_name = Path.GetFileName(image_path); //ja zema slikata od pateka
                   for (int i = 0; i<lb_images.Items.Count; i++ )
                   {
                       if(image_name.Contains(lb_images.Items[i].ToString()))
                       {
                           MessageBox.Show("Can't add image with same Image name.");
                           return;
                       }
                   }
                   string collection_path = dl.select_collection_path_for_collection_name(lb_collection.SelectedItem.ToString());
                  // forma za keyword
                   string image_keyword = dl.ShowKeyword("Select keyword", "Select keyword for Image");
                   if (image_keyword == "" || image_keyword == null)
                   {
                       MessageBox.Show("You must select keyword.");
                       return;
                   }
                   dl.current_image_move(image_name, Path.GetDirectoryName(image_path), collection_path);
                   lb_images.Items.Add(image_name);
                    dl.insert_to_image(image_name, lb_collection.SelectedItem.ToString(), collection_path + "\\" + image_name, image_keyword);
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
            if(lb_images.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select Image, from Images list.");
                return;
            }
            else
            {
                string image_path = dl.select_image_path_for_image_name(lb_images.SelectedItem.ToString());
                c.btn_info_and_view(image_path, c.FINISH_PATH, 2, true);
            }
        }

        
    }
}
