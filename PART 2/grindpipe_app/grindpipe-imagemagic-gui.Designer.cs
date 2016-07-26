namespace grindpipe_app
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_px1 = new System.Windows.Forms.Label();
            this.lbl_px2 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.rb_bw = new System.Windows.Forms.RadioButton();
            this.lb_format = new System.Windows.Forms.ListBox();
            this.lbl_format = new System.Windows.Forms.Label();
            this.ddl_box = new System.Windows.Forms.ComboBox();
            this.lbl_rotation = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_threshold = new System.Windows.Forms.CheckBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_smaller = new System.Windows.Forms.CheckBox();
            this.lbl_path_info = new System.Windows.Forms.Label();
            this.btn_view_image = new System.Windows.Forms.Button();
            this.lbl_path1 = new System.Windows.Forms.Label();
            this.btn_clear_format = new System.Windows.Forms.Button();
            this.btn_enable = new System.Windows.Forms.Button();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.btn_disable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_view_windows = new System.Windows.Forms.Button();
            this.cb_water_effect = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(426, 366);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // lbl_px1
            // 
            this.lbl_px1.AutoSize = true;
            this.lbl_px1.Location = new System.Drawing.Point(127, 177);
            this.lbl_px1.Name = "lbl_px1";
            this.lbl_px1.Size = new System.Drawing.Size(18, 13);
            this.lbl_px1.TabIndex = 5;
            this.lbl_px1.Text = "px";
            // 
            // lbl_px2
            // 
            this.lbl_px2.AutoSize = true;
            this.lbl_px2.Location = new System.Drawing.Point(130, 216);
            this.lbl_px2.Name = "lbl_px2";
            this.lbl_px2.Size = new System.Drawing.Size(18, 13);
            this.lbl_px2.TabIndex = 6;
            this.lbl_px2.Text = "px";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(158, 366);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(246, 23);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert Image";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(168, 288);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(51, 17);
            this.rb_none.TabIndex = 8;
            this.rb_none.TabStop = true;
            this.rb_none.Text = "None";
            this.rb_none.UseVisualStyleBackColor = true;
            // 
            // rb_bw
            // 
            this.rb_bw.AutoSize = true;
            this.rb_bw.Location = new System.Drawing.Point(168, 311);
            this.rb_bw.Name = "rb_bw";
            this.rb_bw.Size = new System.Drawing.Size(104, 17);
            this.rb_bw.TabIndex = 9;
            this.rb_bw.TabStop = true;
            this.rb_bw.Text = "Black and White";
            this.rb_bw.UseVisualStyleBackColor = true;
            this.rb_bw.CheckedChanged += new System.EventHandler(this.rb_bw_CheckedChanged);
            // 
            // lb_format
            // 
            this.lb_format.FormattingEnabled = true;
            this.lb_format.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".gif",
            ".ico"});
            this.lb_format.Location = new System.Drawing.Point(15, 40);
            this.lb_format.Name = "lb_format";
            this.lb_format.Size = new System.Drawing.Size(44, 69);
            this.lb_format.TabIndex = 10;
            // 
            // lbl_format
            // 
            this.lbl_format.AutoSize = true;
            this.lbl_format.Location = new System.Drawing.Point(12, 24);
            this.lbl_format.Name = "lbl_format";
            this.lbl_format.Size = new System.Drawing.Size(64, 13);
            this.lbl_format.TabIndex = 11;
            this.lbl_format.Text = "New Format";
            // 
            // ddl_box
            // 
            this.ddl_box.FormattingEnabled = true;
            this.ddl_box.Items.AddRange(new object[] {
            "",
            "45",
            "90",
            "180",
            "270"});
            this.ddl_box.Location = new System.Drawing.Point(15, 331);
            this.ddl_box.Name = "ddl_box";
            this.ddl_box.Size = new System.Drawing.Size(117, 21);
            this.ddl_box.TabIndex = 12;
            // 
            // lbl_rotation
            // 
            this.lbl_rotation.AutoSize = true;
            this.lbl_rotation.Location = new System.Drawing.Point(12, 315);
            this.lbl_rotation.Name = "lbl_rotation";
            this.lbl_rotation.Size = new System.Drawing.Size(47, 13);
            this.lbl_rotation.TabIndex = 13;
            this.lbl_rotation.Text = "Rotation";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(82, 41);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(464, 20);
            this.txt_path.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Path of the image";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(304, 70);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(118, 23);
            this.btn_upload.TabIndex = 16;
            this.btn_upload.Text = "Upload Image";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 212);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cb_threshold
            // 
            this.cb_threshold.AutoSize = true;
            this.cb_threshold.Location = new System.Drawing.Point(167, 165);
            this.cb_threshold.Name = "cb_threshold";
            this.cb_threshold.Size = new System.Drawing.Size(105, 17);
            this.cb_threshold.TabIndex = 18;
            this.cb_threshold.Text = "Threshold Image";
            this.cb_threshold.UseVisualStyleBackColor = true;
            this.cb_threshold.CheckedChanged += new System.EventHandler(this.cb_threshold_CheckedChanged);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(428, 70);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(118, 23);
            this.btn_info.TabIndex = 19;
            this.btn_info.Text = "Info Image";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(12, 366);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(120, 23);
            this.btn_help.TabIndex = 20;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Special imaging part. 1";
            // 
            // cb_smaller
            // 
            this.cb_smaller.AutoSize = true;
            this.cb_smaller.Location = new System.Drawing.Point(167, 188);
            this.cb_smaller.Name = "cb_smaller";
            this.cb_smaller.Size = new System.Drawing.Size(112, 17);
            this.cb_smaller.TabIndex = 23;
            this.cb_smaller.Text = "50% smaller image";
            this.cb_smaller.UseVisualStyleBackColor = true;
            this.cb_smaller.CheckedChanged += new System.EventHandler(this.cb_smaller_CheckedChanged);
            // 
            // lbl_path_info
            // 
            this.lbl_path_info.AutoSize = true;
            this.lbl_path_info.Location = new System.Drawing.Point(191, 109);
            this.lbl_path_info.Name = "lbl_path_info";
            this.lbl_path_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_path_info.TabIndex = 24;
            // 
            // btn_view_image
            // 
            this.btn_view_image.Location = new System.Drawing.Point(82, 70);
            this.btn_view_image.Name = "btn_view_image";
            this.btn_view_image.Size = new System.Drawing.Size(109, 23);
            this.btn_view_image.TabIndex = 25;
            this.btn_view_image.Text = "View with IMdisplay";
            this.btn_view_image.UseVisualStyleBackColor = true;
            this.btn_view_image.Click += new System.EventHandler(this.btn_view_image_Click);
            // 
            // lbl_path1
            // 
            this.lbl_path1.AutoSize = true;
            this.lbl_path1.Location = new System.Drawing.Point(156, 96);
            this.lbl_path1.Name = "lbl_path1";
            this.lbl_path1.Size = new System.Drawing.Size(0, 13);
            this.lbl_path1.TabIndex = 26;
            // 
            // btn_clear_format
            // 
            this.btn_clear_format.Location = new System.Drawing.Point(15, 115);
            this.btn_clear_format.Name = "btn_clear_format";
            this.btn_clear_format.Size = new System.Drawing.Size(93, 22);
            this.btn_clear_format.TabIndex = 28;
            this.btn_clear_format.Text = "Clear Format";
            this.btn_clear_format.UseVisualStyleBackColor = true;
            this.btn_clear_format.Click += new System.EventHandler(this.btn_clear_format_Click);
            // 
            // btn_enable
            // 
            this.btn_enable.Location = new System.Drawing.Point(15, 238);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(133, 23);
            this.btn_enable.TabIndex = 31;
            this.btn_enable.Text = "Enable Width / Height";
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(15, 170);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(109, 20);
            this.txt_width.TabIndex = 32;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(15, 209);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(109, 20);
            this.txt_height.TabIndex = 33;
            // 
            // btn_disable
            // 
            this.btn_disable.Location = new System.Drawing.Point(15, 267);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(133, 23);
            this.btn_disable.TabIndex = 34;
            this.btn_disable.Text = "Disable Width / Height";
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Special imaging part.2";
            // 
            // btn_view_windows
            // 
            this.btn_view_windows.Location = new System.Drawing.Point(198, 70);
            this.btn_view_windows.Name = "btn_view_windows";
            this.btn_view_windows.Size = new System.Drawing.Size(100, 23);
            this.btn_view_windows.TabIndex = 36;
            this.btn_view_windows.Text = "View with Default viewer";
            this.btn_view_windows.UseVisualStyleBackColor = true;
            this.btn_view_windows.Click += new System.EventHandler(this.btn_view_windows_Click);
            // 
            // cb_water_effect
            // 
            this.cb_water_effect.AutoSize = true;
            this.cb_water_effect.Location = new System.Drawing.Point(167, 212);
            this.cb_water_effect.Name = "cb_water_effect";
            this.cb_water_effect.Size = new System.Drawing.Size(85, 17);
            this.cb_water_effect.TabIndex = 37;
            this.cb_water_effect.Text = "Water effect";
            this.cb_water_effect.UseVisualStyleBackColor = true;
            this.cb_water_effect.CheckedChanged += new System.EventHandler(this.cb_water_effect_CheckedChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 401);
            this.Controls.Add(this.cb_water_effect);
            this.Controls.Add(this.btn_view_windows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.btn_clear_format);
            this.Controls.Add(this.lbl_path1);
            this.Controls.Add(this.btn_view_image);
            this.Controls.Add(this.lbl_path_info);
            this.Controls.Add(this.cb_smaller);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.cb_threshold);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.lbl_rotation);
            this.Controls.Add(this.ddl_box);
            this.Controls.Add(this.lbl_format);
            this.Controls.Add(this.lb_format);
            this.Controls.Add(this.rb_bw);
            this.Controls.Add(this.rb_none);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_px2);
            this.Controls.Add(this.lbl_px1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "Grindpipe ImageMagick GUI";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_px1;
        private System.Windows.Forms.Label lbl_px2;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.RadioButton rb_none;
        private System.Windows.Forms.RadioButton rb_bw;
        private System.Windows.Forms.ListBox lb_format;
        private System.Windows.Forms.Label lbl_format;
        private System.Windows.Forms.ComboBox ddl_box;
        private System.Windows.Forms.Label lbl_rotation;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_threshold;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_smaller;
        private System.Windows.Forms.Label lbl_path_info;
        private System.Windows.Forms.Button btn_view_image;
        private System.Windows.Forms.Label lbl_path1;
        private System.Windows.Forms.Button btn_clear_format;
        private System.Windows.Forms.Button btn_enable;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_view_windows;
        private System.Windows.Forms.CheckBox cb_water_effect;



    }
}

