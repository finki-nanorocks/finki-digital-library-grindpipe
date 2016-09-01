using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grindpipe_app
{
    public partial class ViewAndAddCollection : Form
    {
        public List<string> collection_list;
        ClassesDigitalLibrary dl = new ClassesDigitalLibrary();
        public ViewAndAddCollection()
        {
            InitializeComponent();
        }

        private void collectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void ViewAndAddCollection_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

           txt_col_name.Enabled = txt_lib_name.Enabled = txt_col_path.Enabled = false;
           collection_list = dl.select_all_from_collection_metadata();
           for (int i = 0; i < collection_list.Count; i++)
           {
               string[] tmp = collection_list[i].Split(' ');
               cb_list_coll.Items.Add(tmp[1] +"/"+tmp[0]);
               if (Global_coll.GlobalVar_coll.Contains(tmp[1]) && Global_coll.GlobalVar_coll.Contains(tmp[0]))
               {
                   cb_list_coll.Text = Global_coll.GlobalVar_coll;
               }
           }
        }

        private void collectionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
         
         
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string []part = cb_list_coll.SelectedItem.ToString().Split('/');
            string collection_name = part[0];
            string library_name = part[1];
            string collection_date = txt_data_time.Text;
            string collection_num_images = txt_num_col_img.Value.ToString();
            dl.update_collection(library_name, collection_name, collection_date, collection_num_images);
           // this.Close();
        
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_list_coll.SelectedItem.ToString() != "" || cb_list_coll.SelectedItem.ToString() != null)
            {
                for (int i = 0; i < collection_list.Count; i++)
                {
                    string[] tmp = collection_list[i].Split(' ');
                    if (cb_list_coll.SelectedItem.ToString().Contains(tmp[1]) && cb_list_coll.SelectedItem.ToString().Contains(tmp[0]))
                    {
                        txt_lib_name.Text = tmp[1];
                        txt_col_name.Text = tmp[0];
                        txt_data_time.Text = tmp[2];
                        txt_col_path.Text = tmp[3];
                        if (tmp[4] == "") tmp[4] = "0";
                        txt_num_col_img.Value = Int32.Parse(tmp[4]);
                        break;
                    }
                }
            }
        }



       
    }
}
