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
            this.btn_update_library = new System.Windows.Forms.Button();
            this.libraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_close_library = new System.Windows.Forms.Button();
            this.grindpipe_dbDataSet = new grindpipe_app.grindpipe_dbDataSet();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter = new grindpipe_app.grindpipe_dbDataSetTableAdapters.libraryTableAdapter();
            this.tableAdapterManager = new grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager();
            this.txt_library_name_metadata = new System.Windows.Forms.TextBox();
            this.dt_library_date = new System.Windows.Forms.DateTimePicker();
            this.txt_library_path_metadata = new System.Windows.Forms.TextBox();
            this.libraryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lb_lib_name = new System.Windows.Forms.ComboBox();
            this.txt_inventory = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_char = new System.Windows.Forms.Label();
            library_nameLabel = new System.Windows.Forms.Label();
            library_dateLabel = new System.Windows.Forms.Label();
            library_num_collectionsLabel = new System.Windows.Forms.Label();
            library_pathLabel = new System.Windows.Forms.Label();
            library_inventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // library_nameLabel
            // 
            library_nameLabel.AutoSize = true;
            library_nameLabel.Location = new System.Drawing.Point(16, 60);
            library_nameLabel.Name = "library_nameLabel";
            library_nameLabel.Size = new System.Drawing.Size(70, 13);
            library_nameLabel.TabIndex = 27;
            library_nameLabel.Text = "Library name:";
            // 
            // library_dateLabel
            // 
            library_dateLabel.AutoSize = true;
            library_dateLabel.Location = new System.Drawing.Point(16, 87);
            library_dateLabel.Name = "library_dateLabel";
            library_dateLabel.Size = new System.Drawing.Size(65, 13);
            library_dateLabel.TabIndex = 29;
            library_dateLabel.Text = "Library date:";
            // 
            // library_num_collectionsLabel
            // 
            library_num_collectionsLabel.AutoSize = true;
            library_num_collectionsLabel.Location = new System.Drawing.Point(16, 112);
            library_num_collectionsLabel.Name = "library_num_collectionsLabel";
            library_num_collectionsLabel.Size = new System.Drawing.Size(100, 13);
            library_num_collectionsLabel.TabIndex = 31;
            library_num_collectionsLabel.Text = "Number collections:";
            // 
            // library_pathLabel
            // 
            library_pathLabel.AutoSize = true;
            library_pathLabel.Location = new System.Drawing.Point(16, 138);
            library_pathLabel.Name = "library_pathLabel";
            library_pathLabel.Size = new System.Drawing.Size(65, 13);
            library_pathLabel.TabIndex = 33;
            library_pathLabel.Text = "Library path:";
            // 
            // library_inventoryLabel
            // 
            library_inventoryLabel.AutoSize = true;
            library_inventoryLabel.Location = new System.Drawing.Point(16, 164);
            library_inventoryLabel.Name = "library_inventoryLabel";
            library_inventoryLabel.Size = new System.Drawing.Size(95, 13);
            library_inventoryLabel.TabIndex = 35;
            library_inventoryLabel.Text = "Library description:";
            // 
            // btn_update_library
            // 
            this.btn_update_library.Location = new System.Drawing.Point(205, 240);
            this.btn_update_library.Name = "btn_update_library";
            this.btn_update_library.Size = new System.Drawing.Size(130, 23);
            this.btn_update_library.TabIndex = 13;
            this.btn_update_library.Text = "Update Data";
            this.btn_update_library.UseVisualStyleBackColor = true;
            this.btn_update_library.Click += new System.EventHandler(this.btn_update_library_Click);
            // 
            // btn_close_library
            // 
            this.btn_close_library.Location = new System.Drawing.Point(12, 240);
            this.btn_close_library.Name = "btn_close_library";
            this.btn_close_library.Size = new System.Drawing.Size(130, 23);
            this.btn_close_library.TabIndex = 25;
            this.btn_close_library.Text = "Close";
            this.btn_close_library.UseVisualStyleBackColor = true;
            this.btn_close_library.Click += new System.EventHandler(this.btn_close_library_Click);
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
            // txt_library_name_metadata
            // 
            this.txt_library_name_metadata.Location = new System.Drawing.Point(116, 57);
            this.txt_library_name_metadata.Name = "txt_library_name_metadata";
            this.txt_library_name_metadata.Size = new System.Drawing.Size(219, 20);
            this.txt_library_name_metadata.TabIndex = 28;
            // 
            // dt_library_date
            // 
            this.dt_library_date.Location = new System.Drawing.Point(116, 83);
            this.dt_library_date.Name = "dt_library_date";
            this.dt_library_date.Size = new System.Drawing.Size(219, 20);
            this.dt_library_date.TabIndex = 30;
            // 
            // txt_library_path_metadata
            // 
            this.txt_library_path_metadata.Location = new System.Drawing.Point(116, 135);
            this.txt_library_path_metadata.Name = "txt_library_path_metadata";
            this.txt_library_path_metadata.Size = new System.Drawing.Size(219, 20);
            this.txt_library_path_metadata.TabIndex = 34;
            // 
            // libraryBindingSource2
            // 
            this.libraryBindingSource2.DataMember = "library";
            this.libraryBindingSource2.DataSource = this.grindpipe_dbDataSet;
            // 
            // lb_lib_name
            // 
            this.lb_lib_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lb_lib_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lb_lib_name.CausesValidation = false;
            this.lb_lib_name.FormattingEnabled = true;
            this.lb_lib_name.Location = new System.Drawing.Point(12, 30);
            this.lb_lib_name.Name = "lb_lib_name";
            this.lb_lib_name.Size = new System.Drawing.Size(323, 21);
            this.lb_lib_name.TabIndex = 36;
            this.lb_lib_name.SelectedIndexChanged += new System.EventHandler(this.lb_lib_name_SelectedIndexChanged);
            // 
            // txt_inventory
            // 
            this.txt_inventory.Location = new System.Drawing.Point(116, 164);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(219, 51);
            this.txt_inventory.TabIndex = 39;
            this.txt_inventory.Text = "";
            this.txt_inventory.TextChanged += new System.EventHandler(this.txt_inventory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Digital Library:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 109);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(219, 20);
            this.numericUpDown1.TabIndex = 41;
            // 
            // lbl_char
            // 
            this.lbl_char.AutoSize = true;
            this.lbl_char.Location = new System.Drawing.Point(113, 218);
            this.lbl_char.Name = "lbl_char";
            this.lbl_char.Size = new System.Drawing.Size(0, 13);
            this.lbl_char.TabIndex = 42;
            // 
            // ViewAndAddLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 275);
            this.Controls.Add(this.lbl_char);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.lb_lib_name);
            this.Controls.Add(library_nameLabel);
            this.Controls.Add(this.txt_library_name_metadata);
            this.Controls.Add(library_dateLabel);
            this.Controls.Add(this.dt_library_date);
            this.Controls.Add(library_num_collectionsLabel);
            this.Controls.Add(library_pathLabel);
            this.Controls.Add(this.txt_library_path_metadata);
            this.Controls.Add(library_inventoryLabel);
            this.Controls.Add(this.btn_close_library);
            this.Controls.Add(this.btn_update_library);
            this.Name = "ViewAndAddLibrary";
            this.Text = "View and Update Library Metadata";
            this.Load += new System.EventHandler(this.ViewAndAddLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update_library;
        private System.Windows.Forms.BindingSource libraryBindingSource1;
        private System.Windows.Forms.Button btn_close_library;
        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private grindpipe_dbDataSetTableAdapters.libraryTableAdapter libraryTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_library_name_metadata;
        private System.Windows.Forms.DateTimePicker dt_library_date;
        private System.Windows.Forms.TextBox txt_library_path_metadata;
        private System.Windows.Forms.BindingSource libraryBindingSource2;
        private System.Windows.Forms.ComboBox lb_lib_name;
        private System.Windows.Forms.RichTextBox txt_inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_char;
    }
}