using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace grindpipe_app
{
    public partial class ViewAndAddImage : Form
    {
        ClassesDigitalLibrary dl = new ClassesDigitalLibrary();
        public ViewAndAddImage()
        {
            InitializeComponent();
        }

        private void imageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }

        private void ViewAndAddImage_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


            txt_img_name.Enabled = txt_col_name.Enabled = txt_lb_name.Enabled = txt_extenzion.Enabled = txt_img_path.Enabled = false;
         
        

            string []part =  Global_img.GlobalVar_img.ToString().Split(' ');
            txt_img_name.Text = part[0];
            txt_col_name.Text = part[1];
            txt_lb_name.Text = part[2];
            txt_extenzion.Text = Path.GetExtension(part[0]);
            string []data = dl.select_from_image_selected(part[0], part[1], part[2]).Split('/');
            
            numeric_width.Value =  Int32.Parse(data[0].ToString());
            //MessageBox.Show(data[1].ToString());
            numeric_height.Value = Int32.Parse(data[1].ToString());
            txt_img_path.Text = data[2].ToString();
            cb_print.Text = data[3].ToString();
            txt_inventory_img.Text = data[4].ToString();
            cb_img_keyword.Text = data[5].ToString();
            pictureBox1.ImageLocation = data[2].ToString();
           
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_update_image_Click(object sender, EventArgs e)
        {
            string image_allow_print = cb_print.Text;
            string image_inventory = txt_inventory_img.Text;
            string image_keyword = cb_img_keyword.Text;
            string image_width = numeric_width.Value.ToString();
            string image_height = numeric_height.Value.ToString();
            string image_name = txt_img_name.Text;
            string image_path = txt_img_path.Text;
            string collection_name = txt_col_name.Text;
            string library_name = txt_lb_name.Text;
            string image_extenzion = Path.GetExtension(image_name);

            if (image_inventory.Length > 21)
            {
                MessageBox.Show("Image description must have max 20 caracters.");
                return;
            }
            dl.update_image(image_name, collection_name, library_name, image_width, image_height, image_extenzion, image_path, image_allow_print, image_inventory, image_keyword);
            this.Close();
        }
    }
}
