using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using AudioPlayer.Scripts;

namespace AudioPlayer.Forms
{
    public partial class MakeNewPlayList : Form
    {
        ListViewItem currentItem = null;

        private Dictionary<string, string> fullfileNames = new Dictionary<string, string>();
        public string playlistName = "";
        public List<string> songs = new List<string>();
        public bool isValid = false;

        public MakeNewPlayList()
        {
            InitializeComponent();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            FindSong.ShowDialog();
        }

        private void FindSong_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string filename in FindSong.FileNames)
            {
                FileInfo fileInfo = new FileInfo(filename);

                string name = fileInfo.Name;

                fullfileNames[name] = fileInfo.FullName;

                string[] subitems = { name/*.Split('.')[0]*/, name.Split('.')[1] };
                ListViewItem listViewItem = new ListViewItem(subitems);
                //ListViewItem.ListViewSubItem listViewSubItemName = new ListViewItem.ListViewSubItem(listViewItem, name.Split('.')[0])
                //    {
                //    Tag = "Name"
                //    };
                //ListViewItem.ListViewSubItem listViewSubItemExtension = new ListViewItem.ListViewSubItem(listViewItem, name.Split('.')[1])
                //    {
                //    Tag = "Extension"
                //    };
                //listViewItem.SubItems.Add(listViewSubItemName);
                //listViewItem.SubItems.Add(listViewSubItemExtension);


                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            currentItem = listView1.FocusedItem;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string filename = "";
            string extension = "";

            foreach(var item in currentItem.SubItems)
            {
                string text = item.ToString();
                text = text.Split('{')[1];
                text = text.Split('}')[0];

                if(text == "wav" || text == "flac" || text == "mp3")
                {
                    continue;
                    //extension = text;
                }
                else
                {
                    filename = text;
                }
            }

            fullfileNames.Remove($"{filename}.{extension}");
            listView1.Items.Remove(currentItem);
            currentItem = null;
        }

        private void Duplicate_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(currentItem.Clone() as ListViewItem);
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            int index = currentItem.Index;
            if (index == 0) return;
            listView1.Items.RemoveAt(index);
            listView1.Items.Insert(index-1, currentItem);

            Dictionary<string, string> newfullfileNames = new Dictionary<string, string>();

            foreach (ListViewItem item in listView1.Items)
            {
                newfullfileNames[item.Text] = fullfileNames[item.Text];
            }

            fullfileNames = newfullfileNames;
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            int index = currentItem.Index;
            if (index == listView1.Items.Count - 1) return;
            listView1.Items.RemoveAt(index);
            listView1.Items.Insert(index + 1, currentItem);

            Dictionary<string, string> newfullfileNames = new Dictionary<string, string>();

            foreach(ListViewItem item in listView1.Items)
            {
                newfullfileNames[item.Text] = fullfileNames[item.Text];
            }

            fullfileNames = newfullfileNames;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //string curDir = Directory.GetCurrentDirectory();
            //if (!Directory.Exists($"{curDir}\\playlists"))
            //    Directory.CreateDirectory($"{curDir}\\playlists");

            foreach(var item in fullfileNames)
            {
                songs.Add(item.Value);
            }

            playlistName = textBox1.Text;

            isValid = playlistName != "" && songs.Count > 0;

            Close();
        }
    }
}
