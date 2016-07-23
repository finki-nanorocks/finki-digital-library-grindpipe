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
            this.collectionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.library_nameTextBox = new System.Windows.Forms.TextBox();
            this.collection_nameTextBox = new System.Windows.Forms.TextBox();
            this.collection_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.collection_pathTextBox = new System.Windows.Forms.TextBox();
            this.collection_num_imagesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            library_nameLabel = new System.Windows.Forms.Label();
            collection_nameLabel = new System.Windows.Forms.Label();
            collection_dateLabel = new System.Windows.Forms.Label();
            collection_pathLabel = new System.Windows.Forms.Label();
            collection_num_imagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingNavigator)).BeginInit();
            this.collectionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // library_nameLabel
            // 
            library_nameLabel.AutoSize = true;
            library_nameLabel.Location = new System.Drawing.Point(27, 79);
            library_nameLabel.Name = "library_nameLabel";
            library_nameLabel.Size = new System.Drawing.Size(66, 13);
            library_nameLabel.TabIndex = 3;
            library_nameLabel.Text = "library name:";
            // 
            // collection_nameLabel
            // 
            collection_nameLabel.AutoSize = true;
            collection_nameLabel.Location = new System.Drawing.Point(27, 105);
            collection_nameLabel.Name = "collection_nameLabel";
            collection_nameLabel.Size = new System.Drawing.Size(84, 13);
            collection_nameLabel.TabIndex = 5;
            collection_nameLabel.Text = "collection name:";
            // 
            // collection_dateLabel
            // 
            collection_dateLabel.AutoSize = true;
            collection_dateLabel.Location = new System.Drawing.Point(27, 132);
            collection_dateLabel.Name = "collection_dateLabel";
            collection_dateLabel.Size = new System.Drawing.Size(79, 13);
            collection_dateLabel.TabIndex = 7;
            collection_dateLabel.Text = "collection date:";
            // 
            // collection_pathLabel
            // 
            collection_pathLabel.AutoSize = true;
            collection_pathLabel.Location = new System.Drawing.Point(27, 157);
            collection_pathLabel.Name = "collection_pathLabel";
            collection_pathLabel.Size = new System.Drawing.Size(79, 13);
            collection_pathLabel.TabIndex = 9;
            collection_pathLabel.Text = "collection path:";
            // 
            // collection_num_imagesLabel
            // 
            collection_num_imagesLabel.AutoSize = true;
            collection_num_imagesLabel.Location = new System.Drawing.Point(27, 183);
            collection_num_imagesLabel.Name = "collection_num_imagesLabel";
            collection_num_imagesLabel.Size = new System.Drawing.Size(114, 13);
            collection_num_imagesLabel.TabIndex = 11;
            collection_num_imagesLabel.Text = "collection num images:";
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
            this.collectionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.collectionBindingNavigator.BindingSource = this.collectionBindingSource;
            this.collectionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.collectionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.collectionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.collectionBindingNavigatorSaveItem});
            this.collectionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.collectionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.collectionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.collectionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.collectionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.collectionBindingNavigator.Name = "collectionBindingNavigator";
            this.collectionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.collectionBindingNavigator.Size = new System.Drawing.Size(390, 25);
            this.collectionBindingNavigator.TabIndex = 0;
            this.collectionBindingNavigator.Text = "bindingNavigator1";
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
            // collectionBindingNavigatorSaveItem
            // 
            this.collectionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.collectionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("collectionBindingNavigatorSaveItem.Image")));
            this.collectionBindingNavigatorSaveItem.Name = "collectionBindingNavigatorSaveItem";
            this.collectionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.collectionBindingNavigatorSaveItem.Text = "Save Data";
            this.collectionBindingNavigatorSaveItem.Click += new System.EventHandler(this.collectionBindingNavigatorSaveItem_Click);
            // 
            // library_nameTextBox
            // 
            this.library_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "library_name", true));
            this.library_nameTextBox.Location = new System.Drawing.Point(147, 76);
            this.library_nameTextBox.Name = "library_nameTextBox";
            this.library_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.library_nameTextBox.TabIndex = 4;
            // 
            // collection_nameTextBox
            // 
            this.collection_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "collection_name", true));
            this.collection_nameTextBox.Location = new System.Drawing.Point(147, 102);
            this.collection_nameTextBox.Name = "collection_nameTextBox";
            this.collection_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.collection_nameTextBox.TabIndex = 6;
            // 
            // collection_dateDateTimePicker
            // 
            this.collection_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.collectionBindingSource, "collection_date", true));
            this.collection_dateDateTimePicker.Location = new System.Drawing.Point(147, 128);
            this.collection_dateDateTimePicker.Name = "collection_dateDateTimePicker";
            this.collection_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.collection_dateDateTimePicker.TabIndex = 8;
            // 
            // collection_pathTextBox
            // 
            this.collection_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "collection_path", true));
            this.collection_pathTextBox.Location = new System.Drawing.Point(147, 154);
            this.collection_pathTextBox.Name = "collection_pathTextBox";
            this.collection_pathTextBox.Size = new System.Drawing.Size(200, 20);
            this.collection_pathTextBox.TabIndex = 10;
            // 
            // collection_num_imagesTextBox
            // 
            this.collection_num_imagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectionBindingSource, "collection_num_images", true));
            this.collection_num_imagesTextBox.Location = new System.Drawing.Point(147, 180);
            this.collection_num_imagesTextBox.Name = "collection_num_imagesTextBox";
            this.collection_num_imagesTextBox.Size = new System.Drawing.Size(200, 20);
            this.collection_num_imagesTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewAndAddCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(library_nameLabel);
            this.Controls.Add(this.library_nameTextBox);
            this.Controls.Add(collection_nameLabel);
            this.Controls.Add(this.collection_nameTextBox);
            this.Controls.Add(collection_dateLabel);
            this.Controls.Add(this.collection_dateDateTimePicker);
            this.Controls.Add(collection_pathLabel);
            this.Controls.Add(this.collection_pathTextBox);
            this.Controls.Add(collection_num_imagesLabel);
            this.Controls.Add(this.collection_num_imagesTextBox);
            this.Controls.Add(this.collectionBindingNavigator);
            this.Name = "ViewAndAddCollection";
            this.Text = "View and Add Collection";
            this.Load += new System.EventHandler(this.ViewAndAddCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingNavigator)).EndInit();
            this.collectionBindingNavigator.ResumeLayout(false);
            this.collectionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource collectionBindingSource;
        private grindpipe_dbDataSetTableAdapters.collectionTableAdapter collectionTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator collectionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton collectionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox library_nameTextBox;
        private System.Windows.Forms.TextBox collection_nameTextBox;
        private System.Windows.Forms.DateTimePicker collection_dateDateTimePicker;
        private System.Windows.Forms.TextBox collection_pathTextBox;
        private System.Windows.Forms.TextBox collection_num_imagesTextBox;
        private System.Windows.Forms.Button button1;
    }
}