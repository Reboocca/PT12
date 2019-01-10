namespace Match_EventApp
{
    partial class MessageScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageScreenForm));
            this.BTclose = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BThome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PBgroepPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTlogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBgroepPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTclose
            // 
            this.BTclose.BackColor = System.Drawing.Color.Transparent;
            this.BTclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTclose.BackgroundImage")));
            this.BTclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTclose.FlatAppearance.BorderSize = 0;
            this.BTclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTclose.Location = new System.Drawing.Point(275, 3);
            this.BTclose.Name = "BTclose";
            this.BTclose.Size = new System.Drawing.Size(32, 27);
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
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 34);
            this.panel7.TabIndex = 39;
            // 
            // BThome
            // 
            this.BThome.BackColor = System.Drawing.Color.Transparent;
            this.BThome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BThome.BackgroundImage")));
            this.BThome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BThome.Cursor = System.Windows.Forms.Cursors.Default;
            this.BThome.FlatAppearance.BorderSize = 0;
            this.BThome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BThome.Location = new System.Drawing.Point(3, 4);
            this.BThome.Name = "BThome";
            this.BThome.Size = new System.Drawing.Size(32, 27);
            this.BThome.TabIndex = 15;
            this.BThome.UseVisualStyleBackColor = false;
            this.BThome.Click += new System.EventHandler(this.BThome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Naam groep/event";
            // 
            // PBgroepPicture
            // 
            this.PBgroepPicture.BackColor = System.Drawing.Color.Transparent;
            this.PBgroepPicture.Image = ((System.Drawing.Image)(resources.GetObject("PBgroepPicture.Image")));
            this.PBgroepPicture.Location = new System.Drawing.Point(0, 0);
            this.PBgroepPicture.Name = "PBgroepPicture";
            this.PBgroepPicture.Size = new System.Drawing.Size(112, 110);
            this.PBgroepPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBgroepPicture.TabIndex = 44;
            this.PBgroepPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-22, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 43);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // BTlogin
            // 
            this.BTlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.BTlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTlogin.BackgroundImage")));
            this.BTlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTlogin.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTlogin.Location = new System.Drawing.Point(266, 10);
            this.BTlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.Size = new System.Drawing.Size(37, 30);
            this.BTlogin.TabIndex = 47;
            this.BTlogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 510);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 30);
            this.panel1.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BTlogin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 50);
            this.panel3.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.PBgroepPicture);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 117);
            this.panel4.TabIndex = 50;
            // 
            // MessageScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(310, 550);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageScreenForm";
            this.Text = "MessageScreenForm";
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBgroepPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTclose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BThome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBgroepPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTlogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}