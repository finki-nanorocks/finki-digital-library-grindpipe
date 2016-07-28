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
            this.grindpipe_dbDataSet = new grindpipe_app.grindpipe_dbDataSet();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableAdapter = new grindpipe_app.grindpipe_dbDataSetTableAdapters.imageTableAdapter();
            this.tableAdapterManager = new grindpipe_app.grindpipe_dbDataSetTableAdapters.TableAdapterManager();
            this.btn_update_image = new System.Windows.Forms.Button();
            this.imageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_image_name = new System.Windows.Forms.TextBox();
            this.txt_col_name = new System.Windows.Forms.TextBox();
            this.txt_extenzion = new System.Windows.Forms.TextBox();
            this.txt_img_path = new System.Windows.Forms.TextBox();
            this.txt_print = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.imageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.grindpipedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // image_nameLabel
            // 
            image_nameLabel.AutoSize = true;
            image_nameLabel.Location = new System.Drawing.Point(6, 22);
            image_nameLabel.Name = "image_nameLabel";
            image_nameLabel.Size = new System.Drawing.Size(68, 13);
            image_nameLabel.TabIndex = 23;
            image_nameLabel.Text = "Image name:";
            // 
            // collection_nameLabel
            // 
            collection_nameLabel.AutoSize = true;
            collection_nameLabel.Location = new System.Drawing.Point(6, 49);
            collection_nameLabel.Name = "collection_nameLabel";
            collection_nameLabel.Size = new System.Drawing.Size(85, 13);
            collection_nameLabel.TabIndex = 25;
            collection_nameLabel.Text = "Collection name:";
            // 
            // image_widthLabel
            // 
            image_widthLabel.AutoSize = true;
            image_widthLabel.Location = new System.Drawing.Point(259, 44);
            image_widthLabel.Name = "image_widthLabel";
            image_widthLabel.Size = new System.Drawing.Size(38, 13);
            image_widthLabel.TabIndex = 27;
            image_widthLabel.Text = "Width:";
            // 
            // image_heightLabel
            // 
            image_heightLabel.AutoSize = true;
            image_heightLabel.Location = new System.Drawing.Point(259, 15);
            image_heightLabel.Name = "image_heightLabel";
            image_heightLabel.Size = new System.Drawing.Size(41, 13);
            image_heightLabel.TabIndex = 29;
            image_heightLabel.Text = "Height:";
            // 
            // image_extensionLabel
            // 
            image_extensionLabel.AutoSize = true;
            image_extensionLabel.Location = new System.Drawing.Point(389, 44);
            image_extensionLabel.Name = "image_extensionLabel";
            image_extensionLabel.Size = new System.Drawing.Size(56, 13);
            image_extensionLabel.TabIndex = 31;
            image_extensionLabel.Text = "Extension:";
            // 
            // image_pathLabel
            // 
            image_pathLabel.AutoSize = true;
            image_pathLabel.Location = new System.Drawing.Point(6, 81);
            image_pathLabel.Name = "image_pathLabel";
            image_pathLabel.Size = new System.Drawing.Size(63, 13);
            image_pathLabel.TabIndex = 33;
            image_pathLabel.Text = "Image path:";
            // 
            // image_allow_printLabel
            // 
            image_allow_printLabel.AutoSize = true;
            image_allow_printLabel.Location = new System.Drawing.Point(389, 18);
            image_allow_printLabel.Name = "image_allow_printLabel";
            image_allow_printLabel.Size = new System.Drawing.Size(58, 13);
            image_allow_printLabel.TabIndex = 35;
            image_allow_printLabel.Text = "Allow print:";
            // 
            // image_inventoryLabel
            // 
            image_inventoryLabel.AutoSize = true;
            image_inventoryLabel.Location = new System.Drawing.Point(6, 114);
            image_inventoryLabel.Name = "image_inventoryLabel";
            image_inventoryLabel.Size = new System.Drawing.Size(85, 13);
            image_inventoryLabel.TabIndex = 37;
            image_inventoryLabel.Text = "Image inventory:";
            // 
            // image_keywordLabel
            // 
            image_keywordLabel.AutoSize = true;
            image_keywordLabel.Location = new System.Drawing.Point(6, 179);
            image_keywordLabel.Name = "image_keywordLabel";
            image_keywordLabel.Size = new System.Drawing.Size(82, 13);
            image_keywordLabel.TabIndex = 39;
            image_keywordLabel.Text = "Image keyword:";
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
            // btn_update_image
            // 
            this.btn_update_image.Location = new System.Drawing.Point(142, 211);
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
            // txt_image_name
            // 
            this.txt_image_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_name", true));
            this.txt_image_name.Location = new System.Drawing.Point(94, 15);
            this.txt_image_name.Name = "txt_image_name";
            this.txt_image_name.Size = new System.Drawing.Size(159, 20);
            this.txt_image_name.TabIndex = 24;
            // 
            // txt_col_name
            // 
            this.txt_col_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "collection_name", true));
            this.txt_col_name.Location = new System.Drawing.Point(94, 46);
            this.txt_col_name.Name = "txt_col_name";
            this.txt_col_name.Size = new System.Drawing.Size(159, 20);
            this.txt_col_name.TabIndex = 26;
            // 
            // txt_extenzion
            // 
            this.txt_extenzion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_extension", true));
            this.txt_extenzion.Location = new System.Drawing.Point(453, 41);
            this.txt_extenzion.Name = "txt_extenzion";
            this.txt_extenzion.Size = new System.Drawing.Size(70, 20);
            this.txt_extenzion.TabIndex = 32;
            // 
            // txt_img_path
            // 
            this.txt_img_path.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_path", true));
            this.txt_img_path.Location = new System.Drawing.Point(94, 74);
            this.txt_img_path.Name = "txt_img_path";
            this.txt_img_path.Size = new System.Drawing.Size(159, 20);
            this.txt_img_path.TabIndex = 34;
            // 
            // txt_print
            // 
            this.txt_print.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageBindingSource, "image_allow_print", true));
            this.txt_print.Location = new System.Drawing.Point(453, 15);
            this.txt_print.Name = "txt_print";
            this.txt_print.Size = new System.Drawing.Size(70, 20);
            this.txt_print.TabIndex = 36;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(9, 213);
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
            // imageBindingSource5
            // 
            this.imageBindingSource5.DataMember = "image";
            this.imageBindingSource5.DataSource = this.grindpipedbDataSetBindingSource;
            // 
            // grindpipedbDataSetBindingSource
            // 
            this.grindpipedbDataSetBindingSource.DataSource = this.grindpipe_dbDataSet;
            this.grindpipedbDataSetBindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(262, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 162);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sport",
            "love",
            "fanny",
            "programming",
            "newyear",
            "sex",
            "girls",
            "boys",
            "vacation",
            "faculty",
            "cars",
            "nature",
            "drinks",
            "party",
            "space",
            "technology",
            "tv",
            "shopping",
            "beauty",
            "style",
            "other "});
            this.comboBox1.Location = new System.Drawing.Point(94, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 44;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(303, 42);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 45;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(97, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(156, 40);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // ViewAndAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 246);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(image_nameLabel);
            this.Controls.Add(this.txt_image_name);
            this.Controls.Add(collection_nameLabel);
            this.Controls.Add(this.txt_col_name);
            this.Controls.Add(image_widthLabel);
            this.Controls.Add(image_heightLabel);
            this.Controls.Add(image_extensionLabel);
            this.Controls.Add(this.txt_extenzion);
            this.Controls.Add(image_pathLabel);
            this.Controls.Add(this.txt_img_path);
            this.Controls.Add(image_allow_printLabel);
            this.Controls.Add(this.txt_print);
            this.Controls.Add(image_inventoryLabel);
            this.Controls.Add(image_keywordLabel);
            this.Controls.Add(this.btn_update_image);
            this.Name = "ViewAndAddImage";
            this.Text = "View and Update Image Metadata";
            this.Load += new System.EventHandler(this.ViewAndAddImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindpipe_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private grindpipe_dbDataSet grindpipe_dbDataSet;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private grindpipe_dbDataSetTableAdapters.imageTableAdapter imageTableAdapter;
        private grindpipe_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_update_image;
        private System.Windows.Forms.BindingSource imageBindingSource1;
        private System.Windows.Forms.TextBox txt_image_name;
        private System.Windows.Forms.TextBox txt_col_name;
        private System.Windows.Forms.TextBox txt_extenzion;
        private System.Windows.Forms.TextBox txt_img_path;
        private System.Windows.Forms.TextBox txt_print;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.BindingSource imageBindingSource2;
        private System.Windows.Forms.BindingSource imageBindingSource3;
        private System.Windows.Forms.BindingSource imageBindingSource4;
        private System.Windows.Forms.BindingSource imageBindingSource5;
        private System.Windows.Forms.BindingSource grindpipedbDataSetBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}