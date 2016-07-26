namespace grindpipe_app
{
    partial class ViewAndAddLibrary
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
            System.Windows.Forms.Label library_idLabel;
            System.Windows.Forms.Label library_nameLabel;
            System.Windows.Forms.Label library_dateLabel;
            System.Windows.Forms.Label library_num_collectionsLabel;
            System.Windows.Forms.Label library_pathLabel;
            System.Windows.Forms.Label library_inventoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndAddLibrary));
            this.grindpipe_dbDataSet = new grindpipe_app.grindpipe_dbDataSet();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter = new grindpipe_app.grindpipe_dbDataSetTableAdapters.libraryTableAdapter();
            this.tableAdapterManager = new grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager();
            this.libraryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_update_library = new System.Windows.Forms.Button();
            this.libraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryListBox = new System.Windows.Forms.ListBox();
            this.library_idTextBox = new System.Windows.Forms.TextBox();
            this.library_nameTextBox = new System.Windows.Forms.TextBox();
            this.library_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.library_num_collectionsTextBox = new System.Windows.Forms.TextBox();
            this.library_pathTextBox = new System.Windows.Forms.TextBox();
            this.library_inventoryTextBox = new System.Windows.Forms.TextBox();
            this.btn_close_library = new System.Windows.Forms.Button();
            library_idLabel = new System.Windows.Forms.Label();
            library_nameLabel = new System.Windows.Forms.Label();
            library_dateLabel = new System.Windows.Forms.Label();
            library_num_collectionsLabel = new System.Windows.Forms.Label();
            library_pathLabel = new System.Windows.Forms.Label();
            library_inventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingNavigator)).BeginInit();
            this.libraryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // library_idLabel
            // 
            library_idLabel.AutoSize = true;
            library_idLabel.Location = new System.Drawing.Point(146, 35);
            library_idLabel.Name = "library_idLabel";
            library_idLabel.Size = new System.Drawing.Size(48, 13);
            library_idLabel.TabIndex = 13;
            library_idLabel.Text = "library id:";
            // 
            // library_nameLabel
            // 
            library_nameLabel.AutoSize = true;
            library_nameLabel.Location = new System.Drawing.Point(146, 61);
            library_nameLabel.Name = "library_nameLabel";
            library_nameLabel.Size = new System.Drawing.Size(66, 13);
            library_nameLabel.TabIndex = 15;
            library_nameLabel.Text = "library name:";
            // 
            // library_dateLabel
            // 
            library_dateLabel.AutoSize = true;
            library_dateLabel.Location = new System.Drawing.Point(146, 88);
            library_dateLabel.Name = "library_dateLabel";
            library_dateLabel.Size = new System.Drawing.Size(61, 13);
            library_dateLabel.TabIndex = 17;
            library_dateLabel.Text = "library date:";
            // 
            // library_num_collectionsLabel
            // 
            library_num_collectionsLabel.AutoSize = true;
            library_num_collectionsLabel.Location = new System.Drawing.Point(146, 113);
            library_num_collectionsLabel.Name = "library_num_collectionsLabel";
            library_num_collectionsLabel.Size = new System.Drawing.Size(113, 13);
            library_num_collectionsLabel.TabIndex = 19;
            library_num_collectionsLabel.Text = "library num collections:";
            // 
            // library_pathLabel
            // 
            library_pathLabel.AutoSize = true;
            library_pathLabel.Location = new System.Drawing.Point(146, 139);
            library_pathLabel.Name = "library_pathLabel";
            library_pathLabel.Size = new System.Drawing.Size(61, 13);
            library_pathLabel.TabIndex = 21;
            library_pathLabel.Text = "library path:";
            // 
            // library_inventoryLabel
            // 
            library_inventoryLabel.AutoSize = true;
            library_inventoryLabel.Location = new System.Drawing.Point(146, 165);
            library_inventoryLabel.Name = "library_inventoryLabel";
            library_inventoryLabel.Size = new System.Drawing.Size(83, 13);
            library_inventoryLabel.TabIndex = 23;
            library_inventoryLabel.Text = "library inventory:";
            // 
            // grindpipe_dbDataSet
            // 
            this.grindpipe_dbDataSet.DataSetName = "grindpipe_dbDataSet";
            this.grindpipe_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "library";
            this.libraryBindingSource.DataSource = this.grindpipe_dbDataSet;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.collectionTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.libraryTableAdapter = this.libraryTableAdapter;
            this.tableAdapterManager.UpdateOrder = grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // libraryBindingNavigator
            // 
            this.libraryBindingNavigator.AddNewItem = null;
            this.libraryBindingNavigator.BindingSource = this.libraryBindingSource;
            this.libraryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.libraryBindingNavigator.DeleteItem = null;
            this.libraryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.libraryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.libraryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.libraryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.libraryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.libraryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.libraryBindingNavigator.Name = "libraryBindingNavigator";
            this.libraryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.libraryBindingNavigator.Size = new System.Drawing.Size(480, 25);
            this.libraryBindingNavigator.TabIndex = 0;
            this.libraryBindingNavigator.Text = "bindingNavigator1";
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
            // btn_update_library
            // 
            this.btn_update_library.Location = new System.Drawing.Point(338, 196);
            this.btn_update_library.Name = "btn_update_library";
            this.btn_update_library.Size = new System.Drawing.Size(130, 23);
            this.btn_update_library.TabIndex = 13;
            this.btn_update_library.Text = "Update Data";
            this.btn_update_library.UseVisualStyleBackColor = true;
            // 
            // libraryBindingSource1
            // 
            this.libraryBindingSource1.DataMember = "library";
            this.libraryBindingSource1.DataSource = this.grindpipe_dbDataSet;
            // 
            // libraryListBox
            // 
            this.libraryListBox.DataSource = this.libraryBindingSource1;
            this.libraryListBox.DisplayMember = "library_name";
            this.libraryListBox.FormattingEnabled = true;
            this.libraryListBox.Location = new System.Drawing.Point(12, 33);
            this.libraryListBox.Name = "libraryListBox";
            this.libraryListBox.Size = new System.Drawing.Size(128, 186);
            this.libraryListBox.TabIndex = 13;
            this.libraryListBox.ValueMember = "library_id";
            // 
            // library_idTextBox
            // 
            this.library_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_id", true));
            this.library_idTextBox.Location = new System.Drawing.Point(269, 35);
            this.library_idTextBox.Name = "library_idTextBox";
            this.library_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_idTextBox.TabIndex = 14;
            // 
            // library_nameTextBox
            // 
            this.library_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_name", true));
            this.library_nameTextBox.Location = new System.Drawing.Point(269, 61);
            this.library_nameTextBox.Name = "library_nameTextBox";
            this.library_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_nameTextBox.TabIndex = 16;
            // 
            // library_dateDateTimePicker
            // 
            this.library_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryBindingSource, "library_date", true));
            this.library_dateDateTimePicker.Location = new System.Drawing.Point(269, 87);
            this.library_dateDateTimePicker.Name = "library_dateDateTimePicker";
            this.library_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.library_dateDateTimePicker.TabIndex = 18;
            // 
            // library_num_collectionsTextBox
            // 
            this.library_num_collectionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_num_collections", true));
            this.library_num_collectionsTextBox.Location = new System.Drawing.Point(269, 113);
            this.library_num_collectionsTextBox.Name = "library_num_collectionsTextBox";
            this.library_num_collectionsTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_num_collectionsTextBox.TabIndex = 20;
            // 
            // library_pathTextBox
            // 
            this.library_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_path", true));
            this.library_pathTextBox.Location = new System.Drawing.Point(269, 139);
            this.library_pathTextBox.Name = "library_pathTextBox";
            this.library_pathTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_pathTextBox.TabIndex = 22;
            // 
            // library_inventoryTextBox
            // 
            this.library_inventoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_inventory", true));
            this.library_inventoryTextBox.Location = new System.Drawing.Point(269, 165);
            this.library_inventoryTextBox.Name = "library_inventoryTextBox";
            this.library_inventoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_inventoryTextBox.TabIndex = 24;
            // 
            // btn_close_library
            // 
            this.btn_close_library.Location = new System.Drawing.Point(149, 196);
            this.btn_close_library.Name = "btn_close_library";
            this.btn_close_library.Size = new System.Drawing.Size(130, 23);
            this.btn_close_library.TabIndex = 25;
            this.btn_close_library.Text = "Close";
            this.btn_close_library.UseVisualStyleBackColor = true;
            this.btn_close_library.Click += new System.EventHandler(this.btn_close_library_Click);
            // 
            // ViewAndAddLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 233);
            this.Controls.Add(this.btn_close_library);
            this.Controls.Add(library_idLabel);
            this.Controls.Add(this.library_idTextBox);
            this.Controls.Add(library_nameLabel);
            this.Controls.Add(this.library_nameTextBox);
            this.Controls.Add(library_dateLabel);
            this.Controls.Add(this.library_dateDateTimePicker);
            this.Controls.Add(library_num_collectionsLabel);
            this.Controls.Add(this.library_num_collectionsTextBox);
            this.Controls.Add(library_pathLabel);
            this.Controls.Add(this.library_pathTextBox);
            this.Controls.Add(library_inventoryLabel);
            this.Controls.Add(this.library_inventoryTextBox);
            this.Controls.Add(this.libraryListBox);
            this.Controls.Add(this.btn_update_library);
            this.Controls.Add(this.libraryBindingNavigator);
            this.Name = "ViewAndAddLibrary";
            this.Text = "View and Add Library";
            this.Load += new System.EventHandler(this.ViewAndAddLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingNavigator)).EndInit();
            this.libraryBindingNavigator.ResumeLayout(false);
            this.libraryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private grindpipe_dbDataSetTableAdapters.libraryTableAdapter libraryTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator libraryBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btn_update_library;
        private System.Windows.Forms.BindingSource libraryBindingSource1;
        private System.Windows.Forms.ListBox libraryListBox;
        private System.Windows.Forms.TextBox library_idTextBox;
        private System.Windows.Forms.TextBox library_nameTextBox;
        private System.Windows.Forms.DateTimePicker library_dateDateTimePicker;
        private System.Windows.Forms.TextBox library_num_collectionsTextBox;
        private System.Windows.Forms.TextBox library_pathTextBox;
        private System.Windows.Forms.TextBox library_inventoryTextBox;
        private System.Windows.Forms.Button btn_close_library;
    }
}