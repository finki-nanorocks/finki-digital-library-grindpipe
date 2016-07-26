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
    public partial class ViewAndAddImage : Form
    {
        public ViewAndAddImage()
        {
            InitializeComponent();
        }

        private void imageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grindpipe_dbDataSet);

        }

        private void ViewAndAddImage_Load(object sender, EventArgs e)
        {
           
          //  this.libraryTableAdapter.Fill(this.grindpipe_dbDataSet.image);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
         

        }
    }
}
