namespace AudioPlayer.Forms
{
    partial class MakeNewPlayList
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PlayListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exenstions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Save = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.FindSong = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayListName,
            this.Exenstions});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(211, 465);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // PlayListName
            // 
            this.PlayListName.Text = "Name";
            this.PlayListName.Width = 138;
            // 
            // Exenstions
            // 
            this.Exenstions.Text = "Extension";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Remove, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MoveUp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MoveDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Save, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(230, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 415);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 331);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(133, 75);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(3, 249);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(133, 74);
            this.MoveDown.TabIndex = 4;
            this.MoveDown.Text = "Move Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(3, 167);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(133, 74);
            this.MoveUp.TabIndex = 3;
            this.MoveUp.Text = "Move Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(3, 85);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(133, 74);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(3, 3);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(133, 74);
            this.AddNew.TabIndex = 0;
            this.AddNew.Text = "Add From Disk";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // FindSong
            // 
            this.FindSong.FileName = "song";
            this.FindSong.Filter = "WAV Files|*.wav|FLAC Files|*.flac|All files|*.**";
            this.FindSong.Multiselect = true;
            this.FindSong.Title = "Find Song(s)";
            this.FindSong.FileOk += new System.ComponentModel.CancelEventHandler(this.FindSong_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Playlist Name";
            // 
            // MakeNewPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Name = "MakeNewPlayList";
            this.Text = "MakeNewPlayList";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PlayListName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.OpenFileDialog FindSong;
        private System.Windows.Forms.ColumnHeader Exenstions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}