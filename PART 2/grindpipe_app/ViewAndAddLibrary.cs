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
        public ViewAndAddLibrary()
        {
            InitializeComponent();
        }

        private void libraryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libraryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grindpipe_dbDataSet);

        }

        private void ViewAndAddLibrary_Load(object sender, EventArgs e)
        {
            //this.grindpipe_dbDataSet.Reset();
            this.libraryTableAdapter.Fill(this.grindpipe_dbDataSet.library);
           
        }

        private void btn_close_library_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
