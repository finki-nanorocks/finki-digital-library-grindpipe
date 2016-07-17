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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterParent;

            lbl_text1.Text = "To work with current software, please visit our \nwebsite section for paperwork on: ";
            lbl_link1.Text = "http://grindpipe.ml/Documentation.php";
            lbl_text2.Text = "or community on:";
            lbl_link2.Text = "http://grindpipe.ml/Community.php";
        }

        private void tb_help_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://grindpipe.ml/Documentation.php");
        }

        private void lbl_link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://grindpipe.ml/Community.php");
        }
    }
}
