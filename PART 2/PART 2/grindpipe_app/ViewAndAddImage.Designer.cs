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
            this.btn_update_image = new System.Windows.Forms.Button();
            this.imageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_lb_name = new System.Windows.Forms.TextBox();
            this.txt_col_name = new System.Windows.Forms.TextBox();
            this.txt_extenzion = new System.Windows.Forms.TextBox();
            this.txt_img_path = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.imageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.grindpipedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_img_keyword = new System.Windows.Forms.ComboBox();
            this.numeric_height = new System.Windows.Forms.NumericUpDown();
            this.numeric_width = new System.Windows.Forms.NumericUpDown();
            this.txt_inventory_img = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_img_name = new System.Windows.Forms.TextBox();
            this.cb_print = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            image_nameLabel = new System.Windows.Forms.Label();
            collection_nameLabel = new System.Windows.Forms.Label();
            image_widthLabel = new System.Windows.Forms.Label();
            image_heightLabel = new System.Windows.Forms.Label();
            image_extensionLabel = new System.Windows.Forms.Label();
            image_pathLabel = new System.Windows.Forms.Label();
            image_allow_printLabel = new System.Windows.Forms.Label();
            image_inventoryLabel = new System.Windows.Forms.Label();
            image_keywordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // image_nameLabel
            // 
            image_nameLabel.AutoSize = true;
            image_nameLabel.Location = new System.Drawing.Point(6, 74);
            image_nameLabel.Name = "image_nameLabel";
            image_nameLabel.Size = new System.Drawing.Size(68, 13);
            image_nameLabel.TabIndex = 23;
            image_nameLabel.Text = "Image name:";
            // 
            // collection_nameLabel
            // 
            collection_nameLabel.AutoSize = true;
            collection_nameLabel.Location = new System.Drawing.Point(6, 48);
            collection_nameLabel.Name = "collection_nameLabel";
            collection_nameLabel.Size = new System.Drawing.Size(85, 13);
            collection_nameLabel.TabIndex = 25;
            collection_nameLabel.Text = "Collection name:";
            // 
            // image_widthLabel
            // 
            image_widthLabel.AutoSize = true;
            image_widthLabel.Location = new System.Drawing.Point(271, 44);
            image_widthLabel.Name = "image_widthLabel";
            image_widthLabel.Size = new System.Drawing.Size(38, 13);
            image_widthLabel.TabIndex = 27;
            image_widthLabel.Text = "Width:";
            // 
            // image_heightLabel
            // 
            image_heightLabel.AutoSize = true;
            image_heightLabel.Location = new System.Drawing.Point(271, 15);
            image_heightLabel.Name = "image_heightLabel";
            image_heightLabel.Size = new System.Drawing.Size(41, 13);
            image_heightLabel.TabIndex = 29;
            image_heightLabel.Text = "Height:";
            // 
            // image_extensionLabel
            // 
            image_extensionLabel.AutoSize = true;
            image_extensionLabel.Location = new System.Drawing.Point(401, 44);
            image_extensionLabel.Name = "image_extensionLabel";
            image_extensionLabel.Size = new System.Drawing.Size(56, 13);
            image_extensionLabel.TabIndex = 31;
            image_extensionLabel.Text = "Extension:";
            // 
            // image_pathLabel
            // 
            image_pathLabel.AutoSize = true;
            image_pathLabel.Location = new System.Drawing.Point(6, 100);
            image_pathLabel.Name = "image_pathLabel";
            image_pathLabel.Size = new System.Drawing.Size(63, 13);
            image_pathLabel.TabIndex = 33;
            image_pathLabel.Text = "Image path:";
            // 
            // image_allow_printLabel
            // 
            image_allow_printLabel.AutoSize = true;
            image_allow_printLabel.Location = new System.Drawing.Point(401, 18);
            image_allow_printLabel.Name = "image_allow_printLabel";
            image_allow_printLabel.Size = new System.Drawing.Size(58, 13);
            image_allow_printLabel.TabIndex = 35;
            image_allow_printLabel.Text = "Allow print:";
            // 
            // image_inventoryLabel
            // 
            image_inventoryLabel.AutoSize = true;
            image_inventoryLabel.Location = new System.Drawing.Point(6, 131);
            image_inventoryLabel.Name = "image_inventoryLabel";
            image_inventoryLabel.Size = new System.Drawing.Size(93, 13);
            image_inventoryLabel.TabIndex = 37;
            image_inventoryLabel.Text = "Image description:";
            // 
            // image_keywordLabel
            // 
            image_keywordLabel.AutoSize = true;
            image_keywordLabel.Location = new System.Drawing.Point(6, 184);
            image_keywordLabel.Name = "image_keywordLabel";
            image_keywordLabel.Size = new System.Drawing.Size(82, 13);
            image_keywordLabel.TabIndex = 39;
            image_keywordLabel.Text = "Image keyword:";
            // 
            // btn_update_image
            // 
            this.btn_update_image.Location = new System.Drawing.Point(148, 213);
            this.btn_update_image.Name = "btn_update_image";
            this.btn_update_image.Size = new System.Drawing.Size(111, 23);
            this.btn_update_image.TabIndex = 21;
            this.btn_update_image.Text = "Update data";
            this.btn_update_image.UseVisualStyleBackColor = true;
            this.btn_update_image.Click += new System.EventHandler(this.btn_update_image_Click);
            // 
            // txt_lb_name
            // 
            this.txt_lb_name.Location = new System.Drawing.Point(103, 15);
            this.txt_lb_name.Name = "txt_lb_name";
            this.txt_lb_name.Size = new System.Drawing.Size(159, 20);
            this.txt_lb_name.TabIndex = 24;
            // 
            // txt_col_name
            // 
            this.txt_col_name.Location = new System.Drawing.Point(103, 41);
            this.txt_col_name.Name = "txt_col_name";
            this.txt_col_name.Size = new System.Drawing.Size(159, 20);
            this.txt_col_name.TabIndex = 26;
            // 
            // txt_extenzion
            // 
            this.txt_extenzion.Location = new System.Drawing.Point(465, 41);
            this.txt_extenzion.Name = "txt_extenzion";
            this.txt_extenzion.Size = new System.Drawing.Size(70, 20);
            this.txt_extenzion.TabIndex = 32;
            // 
            // txt_img_path
            // 
            this.txt_img_path.Location = new System.Drawing.Point(103, 93);
            this.txt_img_path.Name = "txt_img_path";
            this.txt_img_path.Size = new System.Drawing.Size(159, 20);
            this.txt_img_path.TabIndex = 34;
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
            // imageBindingSource5
            // 
            this.imageBindingSource5.DataSource = this.grindpipedbDataSetBindingSource;
            // 
            // cb_img_keyword
            // 
            this.cb_img_keyword.FormattingEnabled = true;
            this.cb_img_keyword.Items.AddRange(new object[] {
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
            this.cb_img_keyword.Location = new System.Drawing.Point(100, 176);
            this.cb_img_keyword.Name = "cb_img_keyword";
            this.cb_img_keyword.Size = new System.Drawing.Size(159, 21);
            this.cb_img_keyword.TabIndex = 43;
            // 
            // numeric_height
            // 
            this.numeric_height.Location = new System.Drawing.Point(315, 13);
            this.numeric_height.Name = "numeric_height";
            this.numeric_height.Size = new System.Drawing.Size(80, 20);
            this.numeric_height.TabIndex = 44;
            // 
            // numeric_width
            // 
            this.numeric_width.Location = new System.Drawing.Point(315, 42);
            this.numeric_width.Name = "numeric_width";
            this.numeric_width.Size = new System.Drawing.Size(80, 20);
            this.numeric_width.TabIndex = 45;
            // 
            // txt_inventory_img
            // 
            this.txt_inventory_img.Location = new System.Drawing.Point(103, 128);
            this.txt_inventory_img.Name = "txt_inventory_img";
            this.txt_inventory_img.Size = new System.Drawing.Size(156, 40);
            this.txt_inventory_img.TabIndex = 46;
            this.txt_inventory_img.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Library name:";
            // 
            // txt_img_name
            // 
            this.txt_img_name.Location = new System.Drawing.Point(103, 67);
            this.txt_img_name.Name = "txt_img_name";
            this.txt_img_name.Size = new System.Drawing.Size(159, 20);
            this.txt_img_name.TabIndex = 48;
            // 
            // cb_print
            // 
            this.cb_print.FormattingEnabled = true;
            this.cb_print.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cb_print.Location = new System.Drawing.Point(465, 15);
            this.cb_print.Name = "cb_print";
            this.cb_print.Size = new System.Drawing.Size(70, 21);
            this.cb_print.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(274, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // ViewAndAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_print);
            this.Controls.Add(this.txt_img_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inventory_img);
            this.Controls.Add(this.numeric_width);
            this.Controls.Add(this.numeric_height);
            this.Controls.Add(this.cb_img_keyword);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(image_nameLabel);
            this.Controls.Add(this.txt_lb_name);
            this.Controls.Add(collection_nameLabel);
            this.Controls.Add(this.txt_col_name);
            this.Controls.Add(image_widthLabel);
            this.Controls.Add(image_heightLabel);
            this.Controls.Add(image_extensionLabel);
            this.Controls.Add(this.txt_extenzion);
            this.Controls.Add(image_pathLabel);
            this.Controls.Add(this.txt_img_path);
            this.Controls.Add(image_allow_printLabel);
            this.Controls.Add(image_inventoryLabel);
            this.Controls.Add(image_keywordLabel);
            this.Controls.Add(this.btn_update_image);
            this.Name = "ViewAndAddImage";
            this.Text = "View and Update Image Metadata";
            this.Load += new System.EventHandler(this.ViewAndAddImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindpipedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update_image;
        private System.Windows.Forms.BindingSource imageBindingSource1;
        private System.Windows.Forms.TextBox txt_lb_name;
        private System.Windows.Forms.TextBox txt_col_name;
        private System.Windows.Forms.TextBox txt_extenzion;
        private System.Windows.Forms.TextBox txt_img_path;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.BindingSource imageBindingSource2;
        private System.Windows.Forms.BindingSource imageBindingSource3;
        private System.Windows.Forms.BindingSource imageBindingSource4;
        private System.Windows.Forms.BindingSource imageBindingSource5;
        private System.Windows.Forms.BindingSource grindpipedbDataSetBindingSource;
        private System.Windows.Forms.ComboBox cb_img_keyword;
        private System.Windows.Forms.NumericUpDown numeric_height;
        private System.Windows.Forms.NumericUpDown numeric_width;
        private System.Windows.Forms.RichTextBox txt_inventory_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_img_name;
        private System.Windows.Forms.ComboBox cb_print;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}