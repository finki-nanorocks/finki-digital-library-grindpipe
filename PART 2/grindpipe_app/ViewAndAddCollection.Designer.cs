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
            System.Windows.Forms.Label library_nameLabel;
            System.Windows.Forms.Label collection_nameLabel;
            System.Windows.Forms.Label collection_dateLabel;
            System.Windows.Forms.Label collection_pathLabel;
            System.Windows.Forms.Label collection_num_imagesLabel;
            this.txt_lib_name = new System.Windows.Forms.TextBox();
            this.txt_col_name = new System.Windows.Forms.TextBox();
            this.txt_data_time = new System.Windows.Forms.DateTimePicker();
            this.txt_col_path = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cb_list_coll = new System.Windows.Forms.ComboBox();
            this.txt_num_col_img = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            library_nameLabel = new System.Windows.Forms.Label();
            collection_nameLabel = new System.Windows.Forms.Label();
            collection_dateLabel = new System.Windows.Forms.Label();
            collection_pathLabel = new System.Windows.Forms.Label();
            collection_num_imagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_col_img)).BeginInit();
            this.SuspendLayout();
            // 
            // library_nameLabel
            // 
            library_nameLabel.AutoSize = true;
            library_nameLabel.Location = new System.Drawing.Point(15, 89);
            library_nameLabel.Name = "library_nameLabel";
            library_nameLabel.Size = new System.Drawing.Size(70, 13);
            library_nameLabel.TabIndex = 4;
            library_nameLabel.Text = "Library name:";
            // 
            // collection_nameLabel
            // 
            collection_nameLabel.AutoSize = true;
            collection_nameLabel.Location = new System.Drawing.Point(15, 63);
            collection_nameLabel.Name = "collection_nameLabel";
            collection_nameLabel.Size = new System.Drawing.Size(85, 13);
            collection_nameLabel.TabIndex = 6;
            collection_nameLabel.Text = "Collection name:";
            // 
            // collection_dateLabel
            // 
            collection_dateLabel.AutoSize = true;
            collection_dateLabel.Location = new System.Drawing.Point(15, 115);
            collection_dateLabel.Name = "collection_dateLabel";
            collection_dateLabel.Size = new System.Drawing.Size(80, 13);
            collection_dateLabel.TabIndex = 8;
            collection_dateLabel.Text = "Collection date:";
            // 
            // collection_pathLabel
            // 
            collection_pathLabel.AutoSize = true;
            collection_pathLabel.Location = new System.Drawing.Point(15, 141);
            collection_pathLabel.Name = "collection_pathLabel";
            collection_pathLabel.Size = new System.Drawing.Size(80, 13);
            collection_pathLabel.TabIndex = 10;
            collection_pathLabel.Text = "Collection path:";
            // 
            // collection_num_imagesLabel
            // 
            collection_num_imagesLabel.AutoSize = true;
            collection_num_imagesLabel.Location = new System.Drawing.Point(15, 167);
            collection_num_imagesLabel.Name = "collection_num_imagesLabel";
            collection_num_imagesLabel.Size = new System.Drawing.Size(98, 13);
            collection_num_imagesLabel.TabIndex = 12;
            collection_num_imagesLabel.Text = "Number of  images:";
            // 
            // txt_lib_name
            // 
            this.txt_lib_name.Location = new System.Drawing.Point(117, 60);
            this.txt_lib_name.Name = "txt_lib_name";
            this.txt_lib_name.Size = new System.Drawing.Size(271, 20);
            this.txt_lib_name.TabIndex = 5;
            // 
            // txt_col_name
            // 
            this.txt_col_name.Location = new System.Drawing.Point(117, 86);
            this.txt_col_name.Name = "txt_col_name";
            this.txt_col_name.Size = new System.Drawing.Size(271, 20);
            this.txt_col_name.TabIndex = 7;
            // 
            // txt_data_time
            // 
            this.txt_data_time.Location = new System.Drawing.Point(117, 112);
            this.txt_data_time.Name = "txt_data_time";
            this.txt_data_time.Size = new System.Drawing.Size(271, 20);
            this.txt_data_time.TabIndex = 9;
            // 
            // txt_col_path
            // 
            this.txt_col_path.Location = new System.Drawing.Point(117, 138);
            this.txt_col_path.Name = "txt_col_path";
            this.txt_col_path.Size = new System.Drawing.Size(271, 20);
            this.txt_col_path.TabIndex = 11;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(269, 192);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(119, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update Data";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(117, 192);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 23);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cb_list_coll
            // 
            this.cb_list_coll.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_list_coll.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_list_coll.FormattingEnabled = true;
            this.cb_list_coll.Location = new System.Drawing.Point(18, 33);
            this.cb_list_coll.Name = "cb_list_coll";
            this.cb_list_coll.Size = new System.Drawing.Size(370, 21);
            this.cb_list_coll.TabIndex = 16;
            this.cb_list_coll.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_num_col_img
            // 
            this.txt_num_col_img.Location = new System.Drawing.Point(117, 164);
            this.txt_num_col_img.Name = "txt_num_col_img";
            this.txt_num_col_img.Size = new System.Drawing.Size(271, 20);
            this.txt_num_col_img.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Collection:";
            // 
            // ViewAndAddCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num_col_img);
            this.Controls.Add(this.cb_list_coll);
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
            this.Name = "ViewAndAddCollection";
            this.Text = "View and Update Collection Metadata";
            this.Load += new System.EventHandler(this.ViewAndAddCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_col_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lib_name;
        private System.Windows.Forms.TextBox txt_col_name;
        private System.Windows.Forms.DateTimePicker txt_data_time;
        private System.Windows.Forms.TextBox txt_col_path;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cb_list_coll;
        private System.Windows.Forms.NumericUpDown txt_num_col_img;
        private System.Windows.Forms.Label label1;

    }
}