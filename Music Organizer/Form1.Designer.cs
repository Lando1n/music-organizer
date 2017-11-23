namespace Music_Organizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OrganizeButton = new System.Windows.Forms.Button();
            this.rootFolderTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MusicFolderBut = new System.Windows.Forms.Button();
            this.sameLocCB = new System.Windows.Forms.CheckBox();
            this.destFolderTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.compSongs = new System.Windows.Forms.Label();
            this.totalSongs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.movedSongs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cleanUpCB = new System.Windows.Forms.CheckBox();
            this.featArtCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizeButton
            // 
            this.OrganizeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrganizeButton.FlatAppearance.BorderSize = 0;
            this.OrganizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrganizeButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.OrganizeButton.Location = new System.Drawing.Point(12, 294);
            this.OrganizeButton.Name = "OrganizeButton";
            this.OrganizeButton.Size = new System.Drawing.Size(389, 31);
            this.OrganizeButton.TabIndex = 0;
            this.OrganizeButton.Text = "Organize!";
            this.OrganizeButton.UseVisualStyleBackColor = false;
            this.OrganizeButton.Click += new System.EventHandler(this.OrganizeButton_Click);
            // 
            // rootFolderTB
            // 
            this.rootFolderTB.Location = new System.Drawing.Point(110, 28);
            this.rootFolderTB.Name = "rootFolderTB";
            this.rootFolderTB.Size = new System.Drawing.Size(273, 24);
            this.rootFolderTB.TabIndex = 1;
            this.rootFolderTB.TextChanged += new System.EventHandler(this.rootFolderTB_TextChanged);
            this.rootFolderTB.DoubleClick += new System.EventHandler(this.rootFolderTB_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting Folder:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MusicFolderBut);
            this.groupBox2.Controls.Add(this.sameLocCB);
            this.groupBox2.Controls.Add(this.destFolderTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rootFolderTB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // MusicFolderBut
            // 
            this.MusicFolderBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MusicFolderBut.Cursor = System.Windows.Forms.Cursors.Default;
            this.MusicFolderBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusicFolderBut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MusicFolderBut.Location = new System.Drawing.Point(237, 91);
            this.MusicFolderBut.Name = "MusicFolderBut";
            this.MusicFolderBut.Size = new System.Drawing.Size(146, 27);
            this.MusicFolderBut.TabIndex = 7;
            this.MusicFolderBut.Text = "Default Music Folder";
            this.MusicFolderBut.UseVisualStyleBackColor = false;
            this.MusicFolderBut.Click += new System.EventHandler(this.MusicFolderBut_Click);
            // 
            // sameLocCB
            // 
            this.sameLocCB.AutoSize = true;
            this.sameLocCB.Location = new System.Drawing.Point(30, 97);
            this.sameLocCB.Name = "sameLocCB";
            this.sameLocCB.Size = new System.Drawing.Size(109, 21);
            this.sameLocCB.TabIndex = 6;
            this.sameLocCB.Text = "Same Location";
            this.sameLocCB.UseVisualStyleBackColor = true;
            this.sameLocCB.CheckedChanged += new System.EventHandler(this.sameLocCB_CheckedChanged);
            // 
            // destFolderTB
            // 
            this.destFolderTB.Location = new System.Drawing.Point(110, 60);
            this.destFolderTB.Name = "destFolderTB";
            this.destFolderTB.Size = new System.Drawing.Size(273, 24);
            this.destFolderTB.TabIndex = 5;
            this.destFolderTB.DoubleClick += new System.EventHandler(this.destFolderTB_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(12, 331);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(388, 10);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Completed:";
            // 
            // compSongs
            // 
            this.compSongs.AutoSize = true;
            this.compSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.compSongs.Location = new System.Drawing.Point(87, 20);
            this.compSongs.Name = "compSongs";
            this.compSongs.Size = new System.Drawing.Size(15, 17);
            this.compSongs.TabIndex = 9;
            this.compSongs.Text = "0";
            // 
            // totalSongs
            // 
            this.totalSongs.AutoSize = true;
            this.totalSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalSongs.Location = new System.Drawing.Point(87, 37);
            this.totalSongs.Name = "totalSongs";
            this.totalSongs.Size = new System.Drawing.Size(15, 17);
            this.totalSongs.TabIndex = 11;
            this.totalSongs.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(48, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.movedSongs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.albumLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.artistLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.totalSongs);
            this.groupBox1.Controls.Add(this.compSongs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.statusLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.statusLabel.Location = new System.Drawing.Point(220, 54);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 19);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "Ready";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(167, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status:";
            // 
            // movedSongs
            // 
            this.movedSongs.AutoSize = true;
            this.movedSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.movedSongs.Location = new System.Drawing.Point(87, 54);
            this.movedSongs.Name = "movedSongs";
            this.movedSongs.Size = new System.Drawing.Size(15, 17);
            this.movedSongs.TabIndex = 17;
            this.movedSongs.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(37, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Moved:";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.albumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.albumLabel.Location = new System.Drawing.Point(220, 36);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(69, 19);
            this.albumLabel.TabIndex = 15;
            this.albumLabel.Text = "Unknown";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F);
            this.label8.Location = new System.Drawing.Point(166, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Album:";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.artistLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.artistLabel.Location = new System.Drawing.Point(220, 17);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(69, 19);
            this.artistLabel.TabIndex = 13;
            this.artistLabel.Text = "Unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(171, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Artist:";
            // 
            // cleanUpCB
            // 
            this.cleanUpCB.AutoSize = true;
            this.cleanUpCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cleanUpCB.Location = new System.Drawing.Point(30, 26);
            this.cleanUpCB.Name = "cleanUpCB";
            this.cleanUpCB.Size = new System.Drawing.Size(149, 21);
            this.cleanUpCB.TabIndex = 13;
            this.cleanUpCB.Text = "Delete non-audio files";
            this.cleanUpCB.UseVisualStyleBackColor = true;
            // 
            // featArtCB
            // 
            this.featArtCB.AutoSize = true;
            this.featArtCB.Checked = true;
            this.featArtCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.featArtCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.featArtCB.Location = new System.Drawing.Point(204, 26);
            this.featArtCB.Name = "featArtCB";
            this.featArtCB.Size = new System.Drawing.Size(166, 21);
            this.featArtCB.TabIndex = 14;
            this.featArtCB.Text = "Remove Featured Artists";
            this.featArtCB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cleanUpCB);
            this.groupBox3.Controls.Add(this.featArtCB);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 55);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Options";
            // 
            // Form1
            // 
            this.AcceptButton = this.OrganizeButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(411, 346);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OrganizeButton);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Music Organizer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrganizeButton;
        private System.Windows.Forms.TextBox rootFolderTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox sameLocCB;
        private System.Windows.Forms.TextBox destFolderTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label compSongs;
        private System.Windows.Forms.Label totalSongs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cleanUpCB;
        private System.Windows.Forms.Button MusicFolderBut;
        private System.Windows.Forms.CheckBox featArtCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label movedSongs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label9;
    }
}

