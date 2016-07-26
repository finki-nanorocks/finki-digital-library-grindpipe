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

        public ViewAndAddCollection()
        {
            InitializeComponent();
        }

        private void collectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collectionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grindpipe_dbDataSet);

        }

        private void ViewAndAddCollection_Load(object sender, EventArgs e)
        {
           
           txt_col_name.Enabled = txt_lib_name.Enabled = txt_col_path.Enabled = false;
            // TODO: This line of code loads data into the 'grindpipe_dbDataSet.collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter.Fill(this.grindpipe_dbDataSet.collection);
            // TODO: This line of code loads data into the 'grindpipe_dbDataSet.collection' table. You can move, or remove it, as needed.
            this.collectionTableAdapter.Fill(this.grindpipe_dbDataSet.collection);

        }

        private void collectionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.collectionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grindpipe_dbDataSet);
            grindpipe_dbDataSet.Tables[0].AcceptChanges();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
       
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       
    }
}
