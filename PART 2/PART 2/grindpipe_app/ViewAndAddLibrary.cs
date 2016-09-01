using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grindpipe_app
{
    public partial class ViewAndAddLibrary : Form
    {
        List<string> digital_library;
        ClassesDigitalLibrary dl = new ClassesDigitalLibrary();
        public ViewAndAddLibrary()
        {
            InitializeComponent();
        }

        private void libraryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void ViewAndAddLibrary_Load(object sender, EventArgs e)
        {



            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            txt_library_name_metadata.Enabled = false;
            txt_library_path_metadata.Enabled = false;

            digital_library = dl.select_all_from_library_metadata();
            for (int i = 0; i < digital_library.Count; i++)
            {
                string[] tmp = digital_library[i].Split(' '); 
                lb_lib_name.Items.Add(tmp[0]);
                if (Global_lib.GlobalVar_lib.ToString().Contains(tmp[0]))
                {
                    lb_lib_name.Text = Global_lib.GlobalVar_lib;
                }
            }
           
        }

        private void btn_close_library_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_lib_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lb_lib_name.SelectedItem.ToString() != "" || lb_lib_name.SelectedItem.ToString() != null)
            {
                for (int i = 0; i < digital_library.Count; i++)
                {
                    string[] tmp = digital_library[i].Split(' ');
                    if (lb_lib_name.SelectedItem.ToString().Contains(tmp[0]))
                    {
                       
                        txt_library_name_metadata.Text = tmp[0];
                        dt_library_date.Text = tmp[1];
                        if (tmp[2] == "") tmp[2] = "0";
                        numericUpDown1.Value = Int32.Parse(tmp[2]);
                        txt_library_path_metadata.Text = tmp[3];
                       // txt_inventory.Text = tmp[4];
                        break;
                    }
                }


             txt_inventory.Text =  dl.select_library_name_get_library_inventory(txt_library_name_metadata.Text);
            
            }
        }

        private void btn_update_library_Click(object sender, EventArgs e)
        {
            if(txt_inventory.Text.ToString().Length > 56)
            {
                MessageBox.Show("library description must be less than 57 characters.");
                txt_inventory.Text = "";
                return;
            }
            dl.update_library(txt_library_name_metadata.Text, dt_library_date.Text, numericUpDown1.Value.ToString(), txt_inventory.Text);
           
        }

        private void txt_inventory_TextChanged(object sender, EventArgs e)
        {
            if(txt_inventory.Text.ToString().Length > 56)
            {
                lbl_char.Text = "Must be less than 57 characters.";
            }
            else
            {
                lbl_char.Text = "Description is okey.";
            }
        }
    }
}
