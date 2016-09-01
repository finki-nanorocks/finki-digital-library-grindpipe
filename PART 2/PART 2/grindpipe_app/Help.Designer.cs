namespace grindpipe_app
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_link1 = new System.Windows.Forms.LinkLabel();
            this.lbl_link2 = new System.Windows.Forms.LinkLabel();
            this.lbl_text1 = new System.Windows.Forms.Label();
            this.lbl_text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(86, 167);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRINDPIPE";
            // 
            // lbl_link1
            // 
            this.lbl_link1.AutoSize = true;
            this.lbl_link1.Location = new System.Drawing.Point(12, 64);
            this.lbl_link1.Name = "lbl_link1";
            this.lbl_link1.Size = new System.Drawing.Size(29, 13);
            this.lbl_link1.TabIndex = 3;
            this.lbl_link1.TabStop = true;
            this.lbl_link1.Text = "link1";
            this.lbl_link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link1_LinkClicked);
            // 
            // lbl_link2
            // 
            this.lbl_link2.AutoSize = true;
            this.lbl_link2.Location = new System.Drawing.Point(11, 113);
            this.lbl_link2.Name = "lbl_link2";
            this.lbl_link2.Size = new System.Drawing.Size(29, 13);
            this.lbl_link2.TabIndex = 4;
            this.lbl_link2.TabStop = true;
            this.lbl_link2.Text = "link2";
            this.lbl_link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link2_LinkClicked);
            // 
            // lbl_text1
            // 
            this.lbl_text1.AutoSize = true;
            this.lbl_text1.Location = new System.Drawing.Point(12, 31);
            this.lbl_text1.Name = "lbl_text1";
            this.lbl_text1.Size = new System.Drawing.Size(30, 13);
            this.lbl_text1.TabIndex = 5;
            this.lbl_text1.Text = "text1";
            // 
            // lbl_text2
            // 
            this.lbl_text2.AutoSize = true;
            this.lbl_text2.Location = new System.Drawing.Point(11, 89);
            this.lbl_text2.Name = "lbl_text2";
            this.lbl_text2.Size = new System.Drawing.Size(30, 13);
            this.lbl_text2.TabIndex = 6;
            this.lbl_text2.Text = "text2";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 200);
            this.Controls.Add(this.lbl_text2);
            this.Controls.Add(this.lbl_text1);
            this.Controls.Add(this.lbl_link2);
            this.Controls.Add(this.lbl_link1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbl_link1;
        private System.Windows.Forms.LinkLabel lbl_link2;
        private System.Windows.Forms.Label lbl_text1;
        private System.Windows.Forms.Label lbl_text2;
    }
}