using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace grindpipe_app
{

    class ClassesImageMagic
    {
        public string START_PATH_BAT = Path.GetTempPath() + "temp_grindpipe.bat"; // finding path of the application
        public string FINISH_PATH = @"start """" /d";

        public void MAKE_BAT_AND_START(string start, string new_s_path, string code_fin)
        {

            File.WriteAllText(start, "cd /d " + new_s_path + "\n" + code_fin);
            System.Diagnostics.Process.Start(start);
        }
        public void btn_info_and_view(string txt_path, string fin, int type, bool deff)
        {
            if (txt_path != "")
            {
                string pom_path = Path.GetFileName(txt_path); // get image from path for txt_path.Text
                string code = (type == 1) ? info_image(pom_path) : view_image(pom_path); //ternary operator 
                if (deff)
                {
                    code = view_image_deff(pom_path);
                }
                int ind_pom_path = txt_path.IndexOf(pom_path);
                string new_s = txt_path.Remove(ind_pom_path);

                MAKE_BAT_AND_START(START_PATH_BAT, new_s, code + fin);
            }
            else
            {
                MessageBox.Show("Please, first upload image");
            }

        }
        public bool is_number(string txt)
        {
            int n;
            bool isNumeric = int.TryParse(txt, out n);
            return isNumeric;
        }


        bool rb_is_selected(string radiobutton)
        {
            if (radiobutton != "" || radiobutton != null)
            {
                return true;
            }
            return false;
        }

        public string GetUniqueKey(int maxSize, string format)       // return picture whit format e.g adkdk32a.jpg
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString() + format;
        }

        public string width_height(string width, string height, string img_path, string gen_img)
        {
            string img = Path.GetFileName(img_path); // get image from path for txt_path.Text
            if (width == "" && height == "")
            {
                return "";
            }
            return "convert " + img + " -resize " + width + "x" + height + "! " + gen_img + "\n";
        }
        public string rotation(int rot_value, string img_path, string gen_img)
        {
            string img = Path.GetFileName(img_path);
            if (rot_value == 45 || rot_value == 90 || rot_value == 180 || rot_value == 270)
            {
                return "convert -rotate " + "-" + rot_value + " -background transparent " + img + " " + gen_img + "\n";
            }
            return "";
        }
        public string format_met(string img_path, string gen_img)
        {
            string img = Path.GetFileName(img_path); // get image from path for txt_path.Text
            return "convert " + img + " " + gen_img + "\n";
        }
        public string format_met(string img_path)
        {
            string img = Path.GetFileName(img_path); // get image from path for txt_path.Text
            return "convert " + img + " " + img + "\n";
        }
        public string water_effect(string img_path, string img_gen)
        {
            String full_code = "";
            System.Drawing.Image imgWH = System.Drawing.Image.FromFile(img_path);
            //MessageBox.Show("Width: " + img.Width + ", Height: " + img.Height);
            string img = Path.GetFileName(img_path);
            full_code += "convert -size " + imgWH.Width + "x" + imgWH.Height + " gradient: -evaluate sin 16 pom1.png\n";
            full_code += "composite pom1.png " + img + " -displace 10x10 pom2.png\n";
            full_code += "convert pom2.png " + img + " +swap -append " + img_gen + "\n";
            full_code += "del pom1.png\n";
            full_code += "del pom2.png\n";
            return full_code;
        }

        public string threshold_image(string img_path, string gen_img)
        {
            string img = Path.GetFileName(img_path); // get image from path for txt_path.Text
            return "convert " + img + " -threshold 5 " + gen_img + "\n";
        }
        public string black_white(string img_path, string gen_img)
        {
            string img = Path.GetFileName(img_path); // get image from path for txt_path.Text
            return "convert " + img + " -type grayscale " + gen_img + "\n";
        }
        public string view_image(string img)
        {
            return "imdisplay " + img + "\n";
        }
        public string view_image_deff(string img)
        {
            return "start " + img + "\n";
        }
        public string info_image(string img)
        {
            return "identify -verbose " + img + "\n";
        }
        public string smaller_image50(string img_path, string img_gen)
        {
            string img = Path.GetFileName(img_path);
            return "convert " + img + " -resize 50% " + img_gen + "\n";
        }

    }
}
