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
    public partial class AddName : Form
    {
        public AddName()
        {
            InitializeComponent();
        }

        private void AddName_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the accept button of the form to button1.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
