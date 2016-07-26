namespace grindpipe_app
{
    partial class ViewAndAddImage
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
            System.Windows.Forms.Label image_nameLabel;
            System.Windows.Forms.Label collection_nameLabel;
            System.Windows.Forms.Label image_widthLabel;
            System.Windows.Forms.Label image_heightLabel;
            System.Windows.Forms.Label image_extensionLabel;
            System.Windows.Forms.Label image_pathLabel;
            System.Windows.Forms.Label image_allow_printLabel;
            System.Windows.Forms.Label image_inventoryLabel;
            System.Windows.Forms.Label image_keywordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAndAddImage));
            this.grindpipe_dbDataSet = new grindpipe_app.grindpipe_dbDataSet();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableAdapter = new grindpipe_app.grindpipe_dbDataSetTableAdapters.imageTableAdapter();
            this.tableAdapterManager = new grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager();
            this.imageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_update_image = new System.Windows.Forms.Button();
            this.imageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.image_nameTextBox = new System.Windows.Forms.TextBox();
            this.collection_nameTextBox = new System.Windows.Forms.TextBox();
            this.image_widthTextBox = new System.Windows.Forms.TextBox();
            this.image_heightTextBox = new System.Windows.Forms.TextBox();
            this.image_extensionTextBox = new System.Windows.Forms.TextBox();
            this.image_pathTextBox = new System.Windows.Forms.TextBox();
            this.image_allow_printTextBox = new System.Windows.Forms.TextBox();
            this.image_inventoryTextBox = new System.Windows.Forms.TextBox();
            this.image_keywordTextBox = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.imageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.imageListBox = new System.Windows.Forms.ListBox();
            this.grindpipedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            image_nameLabel = new System.Windows.Forms.Label();
            collection_nameLabel = new System.Windows.Forms.Label();
            image_widthLabel = new System.Windows.Forms.Label();
            image_heightLabel = new System.Windows.Forms.Label();
            image_extensionLabel = new System.Windows.Forms.Label();
            image_pathLabel = new System.Windows.Forms.Label();
            image_allow_printLabel = new System.Windows.Forms.Label();
            image_inventoryLabel = new System.Windows.Forms.Label();
            image_keywordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).BeginInit();
            this.imageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // image_nameLabel
            // 
            image_nameLabel.AutoSize = true;
            image_nameLabel.Location = new System.Drawing.Point(150, 39);
            image_nameLabel.Name = "image_nameLabel";
            image_nameLabel.Size = new System.Drawing.Size(67, 13);
            image_nameLabel.TabIndex = 23;
            image_nameLabel.Text = "image name:";
            // 
            // collection_nameLabel
            // 
            collection_nameLabel.AutoSize = true;
            collection_nameLabel.Location = new System.Drawing.Point(150, 65);
            collection_nameLabel.Name = "collection_nameLabel";
            collection_nameLabel.Size = new System.Drawing.Size(84, 13);
            collection_nameLabel.TabIndex = 25;
            collection_nameLabel.Text = "collection name:";
            // 
            // image_widthLabel
            // 
            image_widthLabel.AutoSize = true;
            image_widthLabel.Location = new System.Drawing.Point(150, 91);
            image_widthLabel.Name = "image_widthLabel";
            image_widthLabel.Size = new System.Drawing.Size(66, 13);
            image_widthLabel.TabIndex = 27;
            image_widthLabel.Text = "image width:";
            // 
            // image_heightLabel
            // 
            image_heightLabel.AutoSize = true;
            image_heightLabel.Location = new System.Drawing.Point(150, 117);
            image_heightLabel.Name = "image_heightLabel";
            image_heightLabel.Size = new System.Drawing.Size(70, 13);
            image_heightLabel.TabIndex = 29;
            image_heightLabel.Text = "image height:";
            // 
            // image_extensionLabel
            // 
            image_extensionLabel.AutoSize = true;
            image_extensionLabel.Location = new System.Drawing.Point(150, 143);
            image_extensionLabel.Name = "image_extensionLabel";
            image_extensionLabel.Size = new System.Drawing.Size(86, 13);
            image_extensionLabel.TabIndex = 31;
            image_extensionLabel.Text = "image extension:";
            // 
            // image_pathLabel
            // 
            image_pathLabel.AutoSize = true;
            image_pathLabel.Location = new System.Drawing.Point(150, 169);
            image_pathLabel.Name = "image_pathLabel";
            image_pathLabel.Size = new System.Drawing.Size(62, 13);
            image_pathLabel.TabIndex = 33;
            image_pathLabel.Text = "image path:";
            // 
            // image_allow_printLabel
            // 
            image_allow_printLabel.AutoSize = true;
            image_allow_printLabel.Location = new System.Drawing.Point(150, 195);
            image_allow_printLabel.Name = "image_allow_printLabel";
            image_allow_printLabel.Size = new System.Drawing.Size(88, 13);
            image_allow_printLabel.TabIndex = 35;
            image_allow_printLabel.Text = "image allow print:";
            // 
            // image_inventoryLabel
            // 
            image_inventoryLabel.AutoSize = true;
            image_inventoryLabel.Location = new System.Drawing.Point(150, 221);
            image_inventoryLabel.Name = "image_inventoryLabel";
            image_inventoryLabel.Size = new System.Drawing.Size(84, 13);
            image_inventoryLabel.TabIndex = 37;
            image_inventoryLabel.Text = "image inventory:";
            // 
            // image_keywordLabel
            // 
            image_keywordLabel.AutoSize = true;
            image_keywordLabel.Location = new System.Drawing.Point(150, 247);
            image_keywordLabel.Name = "image_keywordLabel";
            image_keywordLabel.Size = new System.Drawing.Size(81, 13);
            image_keywordLabel.TabIndex = 39;
            image_keywordLabel.Text = "image keyword:";
            // 
            // grindpipe_dbDataSet
            // 
            this.grindpipe_dbDataSet.DataSetName = "grindpipe_dbDataSet";
            this.grindpipe_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "image";
            this.imageBindingSource.DataSource = this.grindpipe_dbDataSet;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.collectionTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = this.imageTableAdapter;
            this.tableAdapterManager.libraryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imageBindingNavigator
            // 
            this.imageBindingNavigator.AddNewItem = null;
            this.imageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imageBindingNavigator.DeleteItem = null;
            this.imageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.imageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imageBindingNavigator.Name = "imageBindingNavigator";
            this.imageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imageBindingNavigator.Size = new System.Drawing.Size(418, 25);
            this.imageBindingNavigator.TabIndex = 0;
            this.imageBindingNavigator.Text = "bindingNavigator1";
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
            // btn_update_image
            // 
            this.btn_update_image.Location = new System.Drawing.Point(288, 276);
            this.btn_update_image.Name = "btn_update_image";
            this.btn_update_image.Size = new System.Drawing.Size(111, 23);
            this.btn_update_image.TabIndex = 21;
            this.btn_update_image.Text = "Update data";
            this.btn_update_image.UseVisualStyleBackColor = true;
            // 
            // imageBindingSource1
            // 
            this.imageBindingSource1.DataMember = "image";
            this.imageBindingSource1.DataSource = this.grindpipe_dbDataSet;
            // 
            // image_nameTextBox
            // 
            this.image_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_name", true));
            this.image_nameTextBox.Location = new System.Drawing.Point(240, 32);
            this.image_nameTextBox.Name = "image_nameTextBox";
            this.image_nameTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_nameTextBox.TabIndex = 24;
            // 
            // collection_nameTextBox
            // 
            this.collection_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "collection_name", true));
            this.collection_nameTextBox.Location = new System.Drawing.Point(240, 58);
            this.collection_nameTextBox.Name = "collection_nameTextBox";
            this.collection_nameTextBox.Size = new System.Drawing.Size(159, 20);
            this.collection_nameTextBox.TabIndex = 26;
            // 
            // image_widthTextBox
            // 
            this.image_widthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_width", true));
            this.image_widthTextBox.Location = new System.Drawing.Point(240, 84);
            this.image_widthTextBox.Name = "image_widthTextBox";
            this.image_widthTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_widthTextBox.TabIndex = 28;
            // 
            // image_heightTextBox
            // 
            this.image_heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_height", true));
            this.image_heightTextBox.Location = new System.Drawing.Point(240, 110);
            this.image_heightTextBox.Name = "image_heightTextBox";
            this.image_heightTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_heightTextBox.TabIndex = 30;
            // 
            // image_extensionTextBox
            // 
            this.image_extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_extension", true));
            this.image_extensionTextBox.Location = new System.Drawing.Point(240, 136);
            this.image_extensionTextBox.Name = "image_extensionTextBox";
            this.image_extensionTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_extensionTextBox.TabIndex = 32;
            // 
            // image_pathTextBox
            // 
            this.image_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_path", true));
            this.image_pathTextBox.Location = new System.Drawing.Point(240, 162);
            this.image_pathTextBox.Name = "image_pathTextBox";
            this.image_pathTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_pathTextBox.TabIndex = 34;
            // 
            // image_allow_printTextBox
            // 
            this.image_allow_printTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_allow_print", true));
            this.image_allow_printTextBox.Location = new System.Drawing.Point(240, 188);
            this.image_allow_printTextBox.Name = "image_allow_printTextBox";
            this.image_allow_printTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_allow_printTextBox.TabIndex = 36;
            // 
            // image_inventoryTextBox
            // 
            this.image_inventoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_inventory", true));
            this.image_inventoryTextBox.Location = new System.Drawing.Point(240, 214);
            this.image_inventoryTextBox.Name = "image_inventoryTextBox";
            this.image_inventoryTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_inventoryTextBox.TabIndex = 38;
            // 
            // image_keywordTextBox
            // 
            this.image_keywordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_keyword", true));
            this.image_keywordTextBox.Location = new System.Drawing.Point(240, 240);
            this.image_keywordTextBox.Name = "image_keywordTextBox";
            this.image_keywordTextBox.Size = new System.Drawing.Size(159, 20);
            this.image_keywordTextBox.TabIndex = 40;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(153, 276);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(111, 23);
            this.btn_close.TabIndex = 41;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // imageBindingSource2
            // 
            this.imageBindingSource2.DataMember = "image";
            this.imageBindingSource2.DataSource = this.grindpipe_dbDataSet;
            // 
            // imageBindingSource3
            // 
            this.imageBindingSource3.DataMember = "image";
            this.imageBindingSource3.DataSource = this.grindpipe_dbDataSet;
            // 
            // imageBindingSource4
            // 
            this.imageBindingSource4.DataMember = "image";
            this.imageBindingSource4.DataSource = this.grindpipe_dbDataSet;
            // 
            // imageListBox
            // 
            this.imageListBox.DataSource = this.imageBindingSource5;
            this.imageListBox.DisplayMember = "image_name";
            this.imageListBox.FormattingEnabled = true;
            this.imageListBox.Location = new System.Drawing.Point(12, 32);
            this.imageListBox.Name = "imageListBox";
            this.imageListBox.Size = new System.Drawing.Size(132, 277);
            this.imageListBox.TabIndex = 41;
            this.imageListBox.ValueMember = "collection_name";
            // 
            // grindpipedbDataSetBindingSource
            // 
            this.grindpipedbDataSetBindingSource.DataSource = this.grindpipe_dbDataSet;
            this.grindpipedbDataSetBindingSource.Position = 0;
            // 
            // imageBindingSource5
            // 
            this.imageBindingSource5.DataMember = "image";
            this.imageBindingSource5.DataSource = this.grindpipedbDataSetBindingSource;
            // 
            // ViewAndAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.imageListBox);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(image_nameLabel);
            this.Controls.Add(this.image_nameTextBox);
            this.Controls.Add(collection_nameLabel);
            this.Controls.Add(this.collection_nameTextBox);
            this.Controls.Add(image_widthLabel);
            this.Controls.Add(this.image_widthTextBox);
            this.Controls.Add(image_heightLabel);
            this.Controls.Add(this.image_heightTextBox);
            this.Controls.Add(image_extensionLabel);
            this.Controls.Add(this.image_extensionTextBox);
            this.Controls.Add(image_pathLabel);
            this.Controls.Add(this.image_pathTextBox);
            this.Controls.Add(image_allow_printLabel);
            this.Controls.Add(this.image_allow_printTextBox);
            this.Controls.Add(image_inventoryLabel);
            this.Controls.Add(this.image_inventoryTextBox);
            this.Controls.Add(image_keywordLabel);
            this.Controls.Add(this.image_keywordTextBox);
            this.Controls.Add(this.btn_update_image);
            this.Controls.Add(this.imageBindingNavigator);
            this.Name = "ViewAndAddImage";
            this.Text = "View and Add Image";
            this.Load += new System.EventHandler(this.ViewAndAddImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).EndInit();
            this.imageBindingNavigator.ResumeLayout(false);
            this.imageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private grindpipe_dbDataSetTableAdapters.imageTableAdapter imageTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imageBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btn_update_image;
        private System.Windows.Forms.BindingSource imageBindingSource1;
        private System.Windows.Forms.TextBox image_nameTextBox;
        private System.Windows.Forms.TextBox collection_nameTextBox;
        private System.Windows.Forms.TextBox image_widthTextBox;
        private System.Windows.Forms.TextBox image_heightTextBox;
        private System.Windows.Forms.TextBox image_extensionTextBox;
        private System.Windows.Forms.TextBox image_pathTextBox;
        private System.Windows.Forms.TextBox image_allow_printTextBox;
        private System.Windows.Forms.TextBox image_inventoryTextBox;
        private System.Windows.Forms.TextBox image_keywordTextBox;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.BindingSource imageBindingSource2;
        private System.Windows.Forms.BindingSource imageBindingSource3;
        private System.Windows.Forms.BindingSource imageBindingSource4;
        private System.Windows.Forms.ListBox imageListBox;
        private System.Windows.Forms.BindingSource imageBindingSource5;
        private System.Windows.Forms.BindingSource grindpipedbDataSetBindingSource;

    }
}