namespace Match_EventApp
{
    partial class TinderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinderForm));
            this.pb_like = new System.Windows.Forms.PictureBox();
            this.pb_dislike = new System.Windows.Forms.PictureBox();
            this.lbl_naam = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BThome = new System.Windows.Forms.Button();
            this.BTclose = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_favofest = new System.Windows.Forms.Label();
            this.lbl_filmgenre = new System.Windows.Forms.Label();
            this.lbl_hobbys = new System.Windows.Forms.Label();
            this.BTmatches = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dislike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_like
            // 
            this.pb_like.BackColor = System.Drawing.Color.Transparent;
            this.pb_like.Image = ((System.Drawing.Image)(resources.GetObject("pb_like.Image")));
            this.pb_like.Location = new System.Drawing.Point(160, 374);
            this.pb_like.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_like.Name = "pb_like";
            this.pb_like.Size = new System.Drawing.Size(66, 68);
            this.pb_like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_like.TabIndex = 33;
            this.pb_like.TabStop = false;
            this.pb_like.Click += new System.EventHandler(this.pb_like_Click);
            // 
            // pb_dislike
            // 
            this.pb_dislike.BackColor = System.Drawing.Color.Transparent;
            this.pb_dislike.Image = ((System.Drawing.Image)(resources.GetObject("pb_dislike.Image")));
            this.pb_dislike.Location = new System.Drawing.Point(6, 373);
            this.pb_dislike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_dislike.Name = "pb_dislike";
            this.pb_dislike.Size = new System.Drawing.Size(66, 68);
            this.pb_dislike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_dislike.TabIndex = 32;
            this.pb_dislike.TabStop = false;
            this.pb_dislike.Click += new System.EventHandler(this.pb_dislike_Click);
            // 
            // lbl_naam
            // 
            this.lbl_naam.AutoSize = true;
            this.lbl_naam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naam.Location = new System.Drawing.Point(37, 255);
            this.lbl_naam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(70, 24);
            this.lbl_naam.TabIndex = 31;
            this.lbl_naam.Text = "Naam:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // BThome
            // 
            this.BThome.BackColor = System.Drawing.Color.Transparent;
            this.BThome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BThome.BackgroundImage")));
            this.BThome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BThome.Cursor = System.Windows.Forms.Cursors.Default;
            this.BThome.FlatAppearance.BorderSize = 0;
            this.BThome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BThome.Location = new System.Drawing.Point(2, 3);
            this.BThome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BThome.Name = "BThome";
            this.BThome.Size = new System.Drawing.Size(24, 22);
            this.BThome.TabIndex = 15;
            this.BThome.UseVisualStyleBackColor = false;
            // 
            // BTclose
            // 
            this.BTclose.BackColor = System.Drawing.Color.Transparent;
            this.BTclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTclose.BackgroundImage")));
            this.BTclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTclose.FlatAppearance.BorderSize = 0;
            this.BTclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTclose.Location = new System.Drawing.Point(206, 2);
            this.BTclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTclose.Name = "BTclose";
            this.BTclose.Size = new System.Drawing.Size(24, 22);
            this.BTclose.TabIndex = 14;
            this.BTclose.UseVisualStyleBackColor = false;
            this.BTclose.Click += new System.EventHandler(this.BTclose_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.BThome);
            this.panel7.Controls.Add(this.BTclose);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(232, 28);
            this.panel7.TabIndex = 35;
            // 
            // lbl_favofest
            // 
            this.lbl_favofest.AutoSize = true;
            this.lbl_favofest.BackColor = System.Drawing.Color.Transparent;
            this.lbl_favofest.Location = new System.Drawing.Point(17, 289);
            this.lbl_favofest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_favofest.Name = "lbl_favofest";
            this.lbl_favofest.Size = new System.Drawing.Size(90, 13);
            this.lbl_favofest.TabIndex = 36;
            this.lbl_favofest.Text = "Favoriete festival:";
            // 
            // lbl_filmgenre
            // 
            this.lbl_filmgenre.AutoSize = true;
            this.lbl_filmgenre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_filmgenre.Location = new System.Drawing.Point(8, 316);
            this.lbl_filmgenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_filmgenre.Name = "lbl_filmgenre";
            this.lbl_filmgenre.Size = new System.Drawing.Size(99, 13);
            this.lbl_filmgenre.TabIndex = 37;
            this.lbl_filmgenre.Text = "Favoriete filmgenre:";
            // 
            // lbl_hobbys
            // 
            this.lbl_hobbys.AutoSize = true;
            this.lbl_hobbys.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hobbys.Location = new System.Drawing.Point(59, 347);
            this.lbl_hobbys.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hobbys.Name = "lbl_hobbys";
            this.lbl_hobbys.Size = new System.Drawing.Size(48, 13);
            this.lbl_hobbys.TabIndex = 38;
            this.lbl_hobbys.Text = "Hobby\'s:";
            // 
            // BTmatches
            // 
            this.BTmatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.BTmatches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTmatches.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTmatches.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTmatches.Location = new System.Drawing.Point(80, 390);
            this.BTmatches.Margin = new System.Windows.Forms.Padding(2);
            this.BTmatches.Name = "BTmatches";
            this.BTmatches.Size = new System.Drawing.Size(72, 37);
            this.BTmatches.TabIndex = 39;
            this.BTmatches.Text = "Matches";
            this.BTmatches.UseVisualStyleBackColor = false;
            this.BTmatches.Click += new System.EventHandler(this.BTmatches_Click);
            // 
            // TinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Match_EventApp.Properties.Resources.Achtergrond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(232, 447);
            this.Controls.Add(this.BTmatches);
            this.Controls.Add(this.lbl_hobbys);
            this.Controls.Add(this.lbl_filmgenre);
            this.Controls.Add(this.lbl_favofest);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lbl_naam);
            this.Controls.Add(this.pb_like);
            this.Controls.Add(this.pb_dislike);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TinderForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pb_like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dislike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_like;
        private System.Windows.Forms.PictureBox pb_dislike;
        private System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BThome;
        private System.Windows.Forms.Button BTclose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_favofest;
        private System.Windows.Forms.Label lbl_filmgenre;
        private System.Windows.Forms.Label lbl_hobbys;
        private System.Windows.Forms.Button BTmatches;
    }
}