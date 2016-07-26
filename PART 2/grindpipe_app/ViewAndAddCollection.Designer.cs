namespace grindpipe_app
{
    partial class ViewAndAddCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label library_nameLabel;
            System.Windows.Forms.Label collection_nameLabel;
            System.Windows.Forms.Label collection_dateLabel;
            System.Windows.Forms.Label collection_pathLabel;
            System.Windows.Forms.Label collection_num_imagesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndAddCollection));
            this.grindpipe_dbDataSet = new grindpipe_app.grindpipe_dbDataSet();
            this.collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionTableAdapter = new grindpipe_app.grindpipe_dbDataSetTableAdapters.collectionTableAdapter();
            this.tableAdapterManager = new grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager();
            this.collectionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lb_collection_temp = new System.Windows.Forms.ListBox();
            this.collectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_lib_name = new System.Windows.Forms.TextBox();
            this.txt_col_name = new System.Windows.Forms.TextBox();
            this.txt_data_time = new System.Windows.Forms.DateTimePicker();
            this.txt_col_path = new System.Windows.Forms.TextBox();
            this.txt_col_num_images = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.collectionTableAdapter1 = new grindpipe_app.grindpipe_dbDataSetTableAdapters.collectionTableAdapter();
            this.btn_close = new System.Windows.Forms.Button();
            library_nameLabel = new System.Windows.Forms.Label();
            collection_nameLabel = new System.Windows.Forms.Label();
            collection_dateLabel = new System.Windows.Forms.Label();
            collection_pathLabel = new System.Windows.Forms.Label();
            collection_num_imagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingNavigator)).BeginInit();
            this.collectionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // library_nameLabel
            // 
            library_nameLabel.AutoSize = true;
            library_nameLabel.Location = new System.Drawing.Point(132, 62);
            library_nameLabel.Name = "library_nameLabel";
            library_nameLabel.Size = new System.Drawing.Size(66, 13);
            library_nameLabel.TabIndex = 4;
            library_nameLabel.Text = "library name:";
            // 
            // collection_nameLabel
            // 
            collection_nameLabel.AutoSize = true;
            collection_nameLabel.Location = new System.Drawing.Point(132, 36);
            collection_nameLabel.Name = "collection_nameLabel";
            collection_nameLabel.Size = new System.Drawing.Size(84, 13);
            collection_nameLabel.TabIndex = 6;
            collection_nameLabel.Text = "collection name:";
            // 
            // collection_dateLabel
            // 
            collection_dateLabel.AutoSize = true;
            collection_dateLabel.Location = new System.Drawing.Point(132, 88);
            collection_dateLabel.Name = "collection_dateLabel";
            collection_dateLabel.Size = new System.Drawing.Size(79, 13);
            collection_dateLabel.TabIndex = 8;
            collection_dateLabel.Text = "collection date:";
            // 
            // collection_pathLabel
            // 
            collection_pathLabel.AutoSize = true;
            collection_pathLabel.Location = new System.Drawing.Point(132, 114);
            collection_pathLabel.Name = "collection_pathLabel";
            collection_pathLabel.Size = new System.Drawing.Size(79, 13);
            collection_pathLabel.TabIndex = 10;
            collection_pathLabel.Text = "collection path:";
            // 
            // collection_num_imagesLabel
            // 
            collection_num_imagesLabel.AutoSize = true;
            collection_num_imagesLabel.Location = new System.Drawing.Point(132, 140);
            collection_num_imagesLabel.Name = "collection_num_imagesLabel";
            collection_num_imagesLabel.Size = new System.Drawing.Size(96, 13);
            collection_num_imagesLabel.TabIndex = 12;
            collection_num_imagesLabel.Text = "number of  images:";
            // 
            // grindpipe_dbDataSet
            // 
            this.grindpipe_dbDataSet.DataSetName = "grindpipe_dbDataSet";
            this.grindpipe_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collectionBindingSource
            // 
            this.collectionBindingSource.DataMember = "collection";
            this.collectionBindingSource.DataSource = this.grindpipe_dbDataSet;
            // 
            // collectionTableAdapter
            // 
            this.collectionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.collectionTableAdapter = this.collectionTableAdapter;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.libraryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // collectionBindingNavigator
            // 
            this.collectionBindingNavigator.AddNewItem = null;
            this.collectionBindingNavigator.BindingSource = this.collectionBindingSource;
            this.collectionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.collectionBindingNavigator.DeleteItem = null;
            this.collectionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.collectionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.collectionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.collectionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.collectionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.collectionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.collectionBindingNavigator.Name = "collectionBindingNavigator";
            this.collectionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.collectionBindingNavigator.Size = new System.Drawing.Size(517, 25);
            this.collectionBindingNavigator.TabIndex = 0;
            this.collectionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lb_collection_temp
            // 
            this.lb_collection_temp.DataSource = this.collectionBindingSource;
            this.lb_collection_temp.DisplayMember = "collection_name";
            this.lb_collection_temp.FormattingEnabled = true;
            this.lb_collection_temp.Location = new System.Drawing.Point(12, 36);
            this.lb_collection_temp.Name = "lb_collection_temp";
            this.lb_collection_temp.Size = new System.Drawing.Size(114, 147);
            this.lb_collection_temp.TabIndex = 1;
            this.lb_collection_temp.ValueMember = "collection_path";
            // 
            // collectionBindingSource1
            // 
            this.collectionBindingSource1.DataMember = "collection";
            this.collectionBindingSource1.DataSource = this.grindpipe_dbDataSet;
            // 
            // txt_lib_name
            // 
            this.txt_lib_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "library_name", true));
            this.txt_lib_name.Location = new System.Drawing.Point(234, 33);
            this.txt_lib_name.Name = "txt_lib_name";
            this.txt_lib_name.Size = new System.Drawing.Size(271, 20);
            this.txt_lib_name.TabIndex = 5;
            // 
            // txt_col_name
            // 
            this.txt_col_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "collection_name", true));
            this.txt_col_name.Location = new System.Drawing.Point(234, 59);
            this.txt_col_name.Name = "txt_col_name";
            this.txt_col_name.Size = new System.Drawing.Size(271, 20);
            this.txt_col_name.TabIndex = 7;
            // 
            // txt_data_time
            // 
            this.txt_data_time.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.collectionBindingSource, "collection_date", true));
            this.txt_data_time.Location = new System.Drawing.Point(234, 85);
            this.txt_data_time.Name = "txt_data_time";
            this.txt_data_time.Size = new System.Drawing.Size(271, 20);
            this.txt_data_time.TabIndex = 9;
            // 
            // txt_col_path
            // 
            this.txt_col_path.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "collection_path", true));
            this.txt_col_path.Location = new System.Drawing.Point(234, 111);
            this.txt_col_path.Name = "txt_col_path";
            this.txt_col_path.Size = new System.Drawing.Size(271, 20);
            this.txt_col_path.TabIndex = 11;
            // 
            // txt_col_num_images
            // 
            this.txt_col_num_images.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "collection_num_images", true));
            this.txt_col_num_images.Location = new System.Drawing.Point(234, 137);
            this.txt_col_num_images.Name = "txt_col_num_images";
            this.txt_col_num_images.Size = new System.Drawing.Size(271, 20);
            this.txt_col_num_images.TabIndex = 13;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(386, 163);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(119, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update Data";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // collectionTableAdapter1
            // 
            this.collectionTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(234, 163);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 23);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ViewAndAddCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 196);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(library_nameLabel);
            this.Controls.Add(this.txt_lib_name);
            this.Controls.Add(collection_nameLabel);
            this.Controls.Add(this.txt_col_name);
            this.Controls.Add(collection_dateLabel);
            this.Controls.Add(this.txt_data_time);
            this.Controls.Add(collection_pathLabel);
            this.Controls.Add(this.txt_col_path);
            this.Controls.Add(collection_num_imagesLabel);
            this.Controls.Add(this.txt_col_num_images);
            this.Controls.Add(this.lb_collection_temp);
            this.Controls.Add(this.collectionBindingNavigator);
            this.Name = "ViewAndAddCollection";
            this.Text = "View and Add Collection";
            this.Load += new System.EventHandler(this.ViewAndAddCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingNavigator)).EndInit();
            this.collectionBindingNavigator.ResumeLayout(false);
            this.collectionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource collectionBindingSource;
        private grindpipe_dbDataSetTableAdapters.collectionTableAdapter collectionTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator collectionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ListBox lb_collection_temp;
        private System.Windows.Forms.BindingSource collectionBindingSource1;
        private System.Windows.Forms.TextBox txt_lib_name;
        private System.Windows.Forms.TextBox txt_col_name;
        private System.Windows.Forms.DateTimePicker txt_data_time;
        private System.Windows.Forms.TextBox txt_col_path;
        private System.Windows.Forms.TextBox txt_col_num_images;
        private System.Windows.Forms.Button btn_update;
        private grindpipe_dbDataSetTableAdapters.collectionTableAdapter collectionTableAdapter1;
        private System.Windows.Forms.Button btn_close;

    }
}