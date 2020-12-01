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
using System.Text.Json;

namespace AudioPlayer.Forms
{
    public partial class LoadSheet : Form
    {
        ListViewItem currentItem = null;
        Dictionary<string, List<string>> savedplayLists;
        public string requestedPlaylistName = "";
        public List<string> requestedPlayList;
        public bool isValid = false;
        public Dictionary<string, List<string>> newplayLists = null;

        public LoadSheet(Dictionary<string, List<string>> playLists = null)
        {
            InitializeComponent();
            if (playLists != null)
            {
                FillList(playLists);
                savedplayLists = playLists;
            }
            else
            {
                savedplayLists = new Dictionary<string, List<string>>();
            }
        }

        public void FillList(Dictionary<string, List<string>> playLists)
        {
            foreach (var playlist in playLists)
            {
                string[] subitems = { playlist.Key.ToString(), playlist.Value.Count.ToString() };
                ListViewItem listViewItem = new ListViewItem(subitems);
                listView1.Items.Add(listViewItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentItem == null) return;

            requestedPlaylistName = currentItem.Text;
            requestedPlayList = savedplayLists[requestedPlaylistName];
            isValid = requestedPlaylistName == "" && requestedPlayList != null;

            Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            currentItem = listView1.FocusedItem;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            currentItem = listView1.FocusedItem;

            requestedPlaylistName = currentItem.Text;
            requestedPlayList = savedplayLists[requestedPlaylistName];
            isValid = requestedPlaylistName != "" && requestedPlayList != null;

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string curPlayDir = $"{Directory.GetCurrentDirectory()}\\playlists";

            if (!Directory.Exists(curPlayDir))
                Directory.CreateDirectory(curPlayDir);

            FindPlaylists.InitialDirectory = curPlayDir;
            FindPlaylists.ShowDialog();
        }

        private void FindPlaylists_FileOk(object sender, CancelEventArgs e)
        {
            foreach(string file in FindPlaylists.FileNames)
            {
                string jsonString = System.IO.File.ReadAllText(file);

                using(JsonDocument document = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = document.RootElement;

                    string keyName = "";
                    List<string> songs = null;
                    bool isValid = false;

                    if(root.TryGetProperty("Key", out JsonElement keyElement))
                    {
                        keyName = keyElement.GetString();
                    }
                    if(root.TryGetProperty("Value", out JsonElement valueElement))
                    {
                        songs = new List<string>();
                        foreach(var element in valueElement.EnumerateArray())
                        {
                            string elementStr = element.GetString();

                            if(!File.Exists(elementStr))
                            {
                                string filename = elementStr.Split('\\')[elementStr.Split('\\').Length - 1];
                                string message = $"{filename} cannot be found under {elementStr}.";
                                

                                MessageBox.Show(message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            else
                            {
                                songs.Add(elementStr);
                            }
                        }
                    }

                    isValid = keyName != "" && songs != null && songs.Count > 0;
                    if(isValid)
                    {
                        if (savedplayLists.ContainsKey(keyName))
                        {
                            savedplayLists[keyName] = songs;
                        }
                        else
                        {
                            savedplayLists[keyName] = songs;
                            if(newplayLists == null)
                            {
                                newplayLists = new Dictionary<string, List<string>>();
                            }
                            newplayLists[keyName] = songs;
                        }

                        string[] subitems = { keyName, songs.Count.ToString() };
                        ListViewItem listViewItem = new ListViewItem(subitems);
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
