namespace AudioPlayer
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.mainMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SavePlaylists = new System.Windows.Forms.Button();
            this.ListPlayLists = new System.Windows.Forms.Button();
            this.GetPlayList = new System.Windows.Forms.Button();
            this.AddNewPlaylist = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PlayListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playListLabel = new System.Windows.Forms.Label();
            this.CurrentSongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainMediaPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMediaPlayer
            // 
            this.mainMediaPlayer.Enabled = true;
            this.mainMediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.mainMediaPlayer.Name = "mainMediaPlayer";
            this.mainMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainMediaPlayer.OcxState")));
            this.mainMediaPlayer.Size = new System.Drawing.Size(655, 457);
            this.mainMediaPlayer.TabIndex = 0;
            this.mainMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mainMediaPlayer_PlayStateChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.SavePlaylists, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListPlayLists, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GetPlayList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddNewPlaylist, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SavePlaylists
            // 
            this.SavePlaylists.Location = new System.Drawing.Point(489, 3);
            this.SavePlaylists.Name = "SavePlaylists";
            this.SavePlaylists.Size = new System.Drawing.Size(156, 56);
            this.SavePlaylists.TabIndex = 3;
            this.SavePlaylists.Text = "Save Playlists";
            this.SavePlaylists.UseVisualStyleBackColor = true;
            this.SavePlaylists.Click += new System.EventHandler(this.SavePlaylists_Click);
            // 
            // ListPlayLists
            // 
            this.ListPlayLists.Location = new System.Drawing.Point(165, 3);
            this.ListPlayLists.Name = "ListPlayLists";
            this.ListPlayLists.Size = new System.Drawing.Size(156, 56);
            this.ListPlayLists.TabIndex = 2;
            this.ListPlayLists.Text = "List Playlists";
            this.ListPlayLists.UseVisualStyleBackColor = true;
            this.ListPlayLists.Click += new System.EventHandler(this.ListPlayLists_Click);
            // 
            // GetPlayList
            // 
            this.GetPlayList.Location = new System.Drawing.Point(3, 3);
            this.GetPlayList.Name = "GetPlayList";
            this.GetPlayList.Size = new System.Drawing.Size(156, 56);
            this.GetPlayList.TabIndex = 0;
            this.GetPlayList.Text = "Load Playlist";
            this.GetPlayList.UseVisualStyleBackColor = true;
            this.GetPlayList.Click += new System.EventHandler(this.GetPlayList_Click);
            // 
            // AddNewPlaylist
            // 
            this.AddNewPlaylist.Location = new System.Drawing.Point(327, 3);
            this.AddNewPlaylist.Name = "AddNewPlaylist";
            this.AddNewPlaylist.Size = new System.Drawing.Size(156, 56);
            this.AddNewPlaylist.TabIndex = 1;
            this.AddNewPlaylist.Text = "Make New Playlist";
            this.AddNewPlaylist.UseVisualStyleBackColor = true;
            this.AddNewPlaylist.Click += new System.EventHandler(this.AddNewPlaylist_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayListName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(673, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(231, 491);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // PlayListName
            // 
            this.PlayListName.Text = "Name";
            this.PlayListName.Width = 221;
            // 
            // playListLabel
            // 
            this.playListLabel.AutoSize = true;
            this.playListLabel.Location = new System.Drawing.Point(674, 12);
            this.playListLabel.Name = "playListLabel";
            this.playListLabel.Size = new System.Drawing.Size(84, 13);
            this.playListLabel.TabIndex = 4;
            this.playListLabel.Text = "Loaded Playlist :";
            // 
            // CurrentSongLabel
            // 
            this.CurrentSongLabel.AutoSize = true;
            this.CurrentSongLabel.Location = new System.Drawing.Point(677, 29);
            this.CurrentSongLabel.Name = "CurrentSongLabel";
            this.CurrentSongLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentSongLabel.TabIndex = 5;
            this.CurrentSongLabel.Text = "Current Song :";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 570);
            this.Controls.Add(this.CurrentSongLabel);
            this.Controls.Add(this.playListLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMediaPlayer);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.mainMediaPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mainMediaPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddNewPlaylist;
        private System.Windows.Forms.Button GetPlayList;
        private System.Windows.Forms.Button ListPlayLists;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PlayListName;
        private System.Windows.Forms.Button SavePlaylists;
        private System.Windows.Forms.Label playListLabel;
        private System.Windows.Forms.Label CurrentSongLabel;
    }
}

