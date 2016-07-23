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
    public partial class Editor : Form
    {
        ClassesImageMagic c = new ClassesImageMagic();
        
        public Editor()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void Editor_Load(object sender, EventArgs e)
        {
           this.FormBorderStyle = FormBorderStyle.FixedDialog;
           this.MaximizeBox = false;
           this.MinimizeBox = false;
           this.StartPosition = FormStartPosition.CenterParent;


           txt_path.ReadOnly = true;
           rb_none.Checked = true;
           ddl_box.DropDownStyle = ComboBoxStyle.DropDownList;
           txt_width.ReadOnly = true;
           txt_height.ReadOnly = true; 

             
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void btn_view_image_Click(object sender, EventArgs e)
        {
            c.btn_info_and_view(txt_path.Text, c.FINISH_PATH,2,false);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            c.btn_info_and_view(txt_path.Text, "pause",1,false);
        }

        private void rb_bw_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            string path = ofd.FileName.ToString(); // zema pateka od izbraj fajl

            if (path.Contains(".jpg") || path.Contains(".png") || path.Contains(".gif") || path.Contains(".ico") || path.Contains(".JPG") || path.Contains(".PNG") || path.Contains(".GIF") || path.Contains(".ICO"))
            {
                txt_path.Text = ofd.FileName.ToString(); // ja pokazuva celosnata pateka od izbraj fajl
                lbl_path1.Text = "";
              //  label6.Text = Path.GetFileName(txt_path.Text); //ja zema slikata od pateka
            }
            else
            {
                lbl_path1.Text = "You haven't uploaded any image or file isn't an image";
                txt_path.Text = "";
            }
        }



        private void btn_convert_Click(object sender, EventArgs e)
        {

            string format, rotation, black_white, width_height, treshold_img, smaller_effect,water_effect;
            format = rotation = black_white = width_height = treshold_img = smaller_effect = water_effect = "";
            string CODE = "";

            if (txt_path.Text != "")
            {
                if (lb_format.SelectedIndex != -1)
                {
                    if(txt_path.Text.Contains(lb_format.Text))
                    {
                        format = c.format_met(txt_path.Text);
                    }
                    else
                    {
                        format = c.format_met(txt_path.Text, c.GetUniqueKey(8, lb_format.Text));
                    }
                    if (ddl_box.Text != "")
                    {
                        rotation = c.rotation(Int32.Parse(ddl_box.Text), txt_path.Text, c.GetUniqueKey(8, lb_format.Text));
                    }
                    if (rb_bw.Checked)
                    {
                        black_white = c.black_white(txt_path.Text, c.GetUniqueKey(8, lb_format.Text));
                    }
                    if(cb_threshold.Checked)
                    {
                        treshold_img = c.threshold_image(txt_path.Text, c.GetUniqueKey(8, lb_format.Text));
                    }
                    if(cb_smaller.Checked)
                    {
                        smaller_effect = c.smaller_image50(txt_path.Text,c.GetUniqueKey(8,lb_format.Text));
                    }
                    if(cb_water_effect.Checked)
                    {
                       // System.Drawing.Image img = System.Drawing.Image.FromFile(txt_path.Text);
                        water_effect = c.water_effect(txt_path.Text, c.GetUniqueKey(8, lb_format.Text)); 
                        //MessageBox.Show(c.water_effect(txt_path.Text, c.GetUniqueKey(8, lb_format.Text)));
                        
                        // here put the code about wather effect
                    }
                    if ( (txt_width.ReadOnly && txt_height.ReadOnly) || ( c.is_number(txt_width.Text) && c.is_number(txt_height.Text) ) )// TREBA DA SE SREDI
                    {
                        width_height = c.width_height(txt_width.Text, txt_height.Text, txt_path.Text, c.GetUniqueKey(8, lb_format.Text));
                    }
                    else
                    {
                        MessageBox.Show("It must consist only numerical values in text fields width and height");
                        txt_width.Text = txt_height.Text = "";
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("First select a new format before editing an image. Then, choose any type of editing image like width/height, rotation, black and white image or, special imaging.");
                    format = rotation = black_white = width_height = treshold_img = smaller_effect = water_effect = "";
                    return;
                }
                CODE = format + water_effect + rotation + black_white + width_height + treshold_img + smaller_effect;
              
                string pom_path = Path.GetFileName(txt_path.Text); // get image from path for txt_path.Text
                int ind_pom_path = txt_path.Text.IndexOf(pom_path);
                string new_s = txt_path.Text.Remove(ind_pom_path);
             //   label6.Text = new_s;

                c.MAKE_BAT_AND_START(c.START_PATH_BAT, new_s, CODE+c.FINISH_PATH);
                MessageBox.Show("Success!");
            }else
            {
                MessageBox.Show("You must first upload an image");
                format = rotation = black_white = width_height = treshold_img = smaller_effect = "";
            }
           
        }

        private void btn_clear_format_Click(object sender, EventArgs e)
        {
            lb_format.ClearSelected();
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            txt_width.ReadOnly = false;
            txt_height.ReadOnly = false;
          
        }

        private void btn_disable_Click(object sender, EventArgs e)
        {
            txt_width.ReadOnly = true;
            txt_height.ReadOnly = true;
            txt_width.Text = txt_height.Text = "";
        }

        private void cb_threshold_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_view_windows_Click(object sender, EventArgs e)
        {
            c.btn_info_and_view(txt_path.Text, c.FINISH_PATH, 2,true);
        }

        private void cb_smaller_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_water_effect_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_path.Text == "")
            {
                MessageBox.Show("You must first upload an image");
                return;
            }
            if (!cb_water_effect.Checked)
            {
                return;
            }
            System.Drawing.Image imgWH = System.Drawing.Image.FromFile(txt_path.Text);
            int width = Int32.Parse(imgWH.Width.ToString());
            int height = Int32.Parse(imgWH.Height.ToString());
            if(width > 301 || height > 301)
            {
                MessageBox.Show("Width and height must be under 300 px.");
                cb_water_effect.Checked = false;
                return;
            }
        }

     
      
    }
}
