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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.libraryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.library_nameTextBox = new System.Windows.Forms.TextBox();
            this.library_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.library_num_collectionsTextBox = new System.Windows.Forms.TextBox();
            this.library_pathTextBox = new System.Windows.Forms.TextBox();
            this.library_inventoryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            library_nameLabel = new System.Windows.Forms.Label();
            library_dateLabel = new System.Windows.Forms.Label();
            library_num_collectionsLabel = new System.Windows.Forms.Label();
            library_pathLabel = new System.Windows.Forms.Label();
            library_inventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingNavigator)).BeginInit();
            this.libraryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // library_nameLabel
            // 
            library_nameLabel.AutoSize = true;
            library_nameLabel.Location = new System.Drawing.Point(12, 73);
            library_nameLabel.Name = "library_nameLabel";
            library_nameLabel.Size = new System.Drawing.Size(66, 13);
            library_nameLabel.TabIndex = 3;
            library_nameLabel.Text = "library name:";
            // 
            // library_dateLabel
            // 
            library_dateLabel.AutoSize = true;
            library_dateLabel.Location = new System.Drawing.Point(12, 100);
            library_dateLabel.Name = "library_dateLabel";
            library_dateLabel.Size = new System.Drawing.Size(61, 13);
            library_dateLabel.TabIndex = 5;
            library_dateLabel.Text = "library date:";
            // 
            // library_num_collectionsLabel
            // 
            library_num_collectionsLabel.AutoSize = true;
            library_num_collectionsLabel.Location = new System.Drawing.Point(12, 125);
            library_num_collectionsLabel.Name = "library_num_collectionsLabel";
            library_num_collectionsLabel.Size = new System.Drawing.Size(113, 13);
            library_num_collectionsLabel.TabIndex = 7;
            library_num_collectionsLabel.Text = "library num collections:";
            // 
            // library_pathLabel
            // 
            library_pathLabel.AutoSize = true;
            library_pathLabel.Location = new System.Drawing.Point(12, 151);
            library_pathLabel.Name = "library_pathLabel";
            library_pathLabel.Size = new System.Drawing.Size(61, 13);
            library_pathLabel.TabIndex = 9;
            library_pathLabel.Text = "library path:";
            // 
            // library_inventoryLabel
            // 
            library_inventoryLabel.AutoSize = true;
            library_inventoryLabel.Location = new System.Drawing.Point(12, 177);
            library_inventoryLabel.Name = "library_inventoryLabel";
            library_inventoryLabel.Size = new System.Drawing.Size(83, 13);
            library_inventoryLabel.TabIndex = 11;
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
            this.libraryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.libraryBindingNavigator.BindingSource = this.libraryBindingSource;
            this.libraryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.libraryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.libraryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.libraryBindingNavigatorSaveItem});
            this.libraryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.libraryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.libraryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.libraryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.libraryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.libraryBindingNavigator.Name = "libraryBindingNavigator";
            this.libraryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.libraryBindingNavigator.Size = new System.Drawing.Size(358, 25);
            this.libraryBindingNavigator.TabIndex = 0;
            this.libraryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // libraryBindingNavigatorSaveItem
            // 
            this.libraryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libraryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("libraryBindingNavigatorSaveItem.Image")));
            this.libraryBindingNavigatorSaveItem.Name = "libraryBindingNavigatorSaveItem";
            this.libraryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.libraryBindingNavigatorSaveItem.Text = "Save Data";
            this.libraryBindingNavigatorSaveItem.Click += new System.EventHandler(this.libraryBindingNavigatorSaveItem_Click);
            // 
            // library_nameTextBox
            // 
            this.library_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_name", true));
            this.library_nameTextBox.Location = new System.Drawing.Point(131, 70);
            this.library_nameTextBox.Name = "library_nameTextBox";
            this.library_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_nameTextBox.TabIndex = 4;
            // 
            // library_dateDateTimePicker
            // 
            this.library_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libraryBindingSource, "library_date", true));
            this.library_dateDateTimePicker.Location = new System.Drawing.Point(131, 96);
            this.library_dateDateTimePicker.Name = "library_dateDateTimePicker";
            this.library_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.library_dateDateTimePicker.TabIndex = 6;
            // 
            // library_num_collectionsTextBox
            // 
            this.library_num_collectionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_num_collections", true));
            this.library_num_collectionsTextBox.Location = new System.Drawing.Point(131, 122);
            this.library_num_collectionsTextBox.Name = "library_num_collectionsTextBox";
            this.library_num_collectionsTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_num_collectionsTextBox.TabIndex = 8;
            // 
            // library_pathTextBox
            // 
            this.library_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_path", true));
            this.library_pathTextBox.Location = new System.Drawing.Point(131, 148);
            this.library_pathTextBox.Name = "library_pathTextBox";
            this.library_pathTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_pathTextBox.TabIndex = 10;
            // 
            // library_inventoryTextBox
            // 
            this.library_inventoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libraryBindingSource, "library_inventory", true));
            this.library_inventoryTextBox.Location = new System.Drawing.Point(131, 174);
            this.library_inventoryTextBox.Name = "library_inventoryTextBox";
            this.library_inventoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_inventoryTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewAndAddLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 268);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.libraryBindingNavigator);
            this.Name = "ViewAndAddLibrary";
            this.Text = "View and Add Library";
            this.Load += new System.EventHandler(this.ViewAndAddLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingNavigator)).EndInit();
            this.libraryBindingNavigator.ResumeLayout(false);
            this.libraryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private grindpipe_dbDataSetTableAdapters.libraryTableAdapter libraryTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator libraryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton libraryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox library_nameTextBox;
        private System.Windows.Forms.DateTimePicker library_dateDateTimePicker;
        private System.Windows.Forms.TextBox library_num_collectionsTextBox;
        private System.Windows.Forms.TextBox library_pathTextBox;
        private System.Windows.Forms.TextBox library_inventoryTextBox;
        private System.Windows.Forms.Button button1;
    }
}