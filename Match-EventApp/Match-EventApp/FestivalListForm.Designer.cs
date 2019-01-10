﻿namespace Match_EventApp
{
    partial class FestivalListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FestivalListForm));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbFestivals = new BrightIdeasSoftware.ObjectListView();
            this.Foto = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Naam = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnGroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnJoin = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnMatch = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BThome = new System.Windows.Forms.Button();
            this.BTclose = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lbFestivals)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.button5.BackgroundImage = global::Match_EventApp.Properties.Resources.ButtonFestival;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(5, 32);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 69);
            this.button5.TabIndex = 37;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.button4.BackgroundImage = global::Match_EventApp.Properties.Resources.ButtonLokaal;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(80, 32);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 69);
            this.button4.TabIndex = 36;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.button3.BackgroundImage = global::Match_EventApp.Properties.Resources.ButtonMessage;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(157, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 69);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = global::Match_EventApp.Properties.Resources.Friend;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(235, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 69);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbFestivals
            // 
            this.lbFestivals.AllColumns.Add(this.Foto);
            this.lbFestivals.AllColumns.Add(this.Naam);
            this.lbFestivals.AllColumns.Add(this.btnGroup);
            this.lbFestivals.AllColumns.Add(this.btnJoin);
            this.lbFestivals.AllColumns.Add(this.btnMatch);
            this.lbFestivals.BackColor = System.Drawing.Color.SkyBlue;
            this.lbFestivals.CellEditUseWholeCell = false;
            this.lbFestivals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Foto,
            this.Naam,
            this.btnGroup,
            this.btnJoin,
            this.btnMatch});
            this.lbFestivals.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbFestivals.Location = new System.Drawing.Point(0, 107);
            this.lbFestivals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFestivals.Name = "lbFestivals";
            this.lbFestivals.ShowGroups = false;
            this.lbFestivals.ShowHeaderInAllViews = false;
            this.lbFestivals.Size = new System.Drawing.Size(309, 443);
            this.lbFestivals.TabIndex = 1;
            this.lbFestivals.UseCompatibleStateImageBehavior = false;
            this.lbFestivals.View = System.Windows.Forms.View.Details;
            // 
            // Foto
            // 
            this.Foto.ImageAspectName = "Foto";
            this.Foto.IsEditable = false;
            this.Foto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Foto.UseFiltering = false;
            this.Foto.Width = 40;
            this.Foto.WordWrap = true;
            // 
            // Naam
            // 
            this.Naam.AspectName = "Name";
            this.Naam.Width = 80;
            this.Naam.WordWrap = true;
            // 
            // btnGroup
            // 
            this.btnGroup.AspectName = "Group";
            this.btnGroup.AspectToStringFormat = "G";
            this.btnGroup.Width = 30;
            // 
            // btnJoin
            // 
            this.btnJoin.AspectName = "Join";
            this.btnJoin.AspectToStringFormat = "J";
            this.btnJoin.Width = 30;
            // 
            // btnMatch
            // 
            this.btnMatch.AspectName = "Match";
            this.btnMatch.AspectToStringFormat = "M";
            this.btnMatch.Width = 30;
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
            this.panel7.Size = new System.Drawing.Size(309, 34);
            this.panel7.TabIndex = 39;
            // 
            // FestivalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Match_EventApp.Properties.Resources.Achtergrond6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 550);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lbFestivals);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FestivalListForm";
            this.Text = "FestivalForm";
            ((System.ComponentModel.ISupportInitialize)(this.lbFestivals)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private BrightIdeasSoftware.ObjectListView lbFestivals;
        private BrightIdeasSoftware.OLVColumn Foto;
        private BrightIdeasSoftware.OLVColumn Naam;
        private BrightIdeasSoftware.OLVColumn btnGroup;
        private BrightIdeasSoftware.OLVColumn btnJoin;
        private BrightIdeasSoftware.OLVColumn btnMatch;
        private System.Windows.Forms.Button BThome;
        private System.Windows.Forms.Button BTclose;
        private System.Windows.Forms.Panel panel7;
    }
}