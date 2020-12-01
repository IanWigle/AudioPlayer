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
using WMPLib;
using AudioPlayer.Forms;

namespace AudioPlayer
{
    public partial class Menu : Form
    {
        private Dictionary<string, List<string>> playlists = new Dictionary<string, List<string>>();
        private List<string> currentList;
        private string currentListName = "";
        private string currentPlayListName = "";

        public Dictionary<string, List<string>> GetPlayListsCopy()
        {
            return new Dictionary<string, List<string>>(playlists);
        }

        public List<string> GetCurrentSongList()
        {
            return new List<string>(playlists[currentPlayListName]);
        }

        public string GetCurrentPlaylistName()
        {
            return new string(currentPlayListName.ToCharArray());
        }

        public Menu()
        {
            InitializeComponent();
        }

        public void MakeNewPlaylist(string playListName, List<string> songList)
        {
            if (playlists.ContainsKey(playListName)) return;

            playlists[playListName] = songList;
        }

        private void ListPlayLists_Click(object sender, EventArgs e)
        {
            PlayListList playListList = new PlayListList(GetPlayListsCopy());
            playListList.ShowDialog();
        }

        private void SavePlaylists_Click(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            if (!Directory.Exists($"{curDir}\\playlists"))
                Directory.CreateDirectory($"{curDir}\\playlists");

            foreach(var playlist in playlists)
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                string jsonString = JsonSerializer.Serialize(playlist,options);
                System.IO.File.WriteAllText($"{curDir}\\playlists\\{playlist.Key.Split('.')[0]}.txt", jsonString);
            }
        }

        private void AddNewPlaylist_Click(object sender, EventArgs e)
        {
            MakeNewPlayList makeNewPlayList = new MakeNewPlayList();
            makeNewPlayList.ShowDialog();

            if(makeNewPlayList.isValid)
            {
                playlists[makeNewPlayList.playlistName] = makeNewPlayList.songs;
            }
        }

        private void GetPlayList_Click(object sender, EventArgs e)
        {
            LoadSheet loadSheet = new LoadSheet(GetPlayListsCopy());
            loadSheet.ShowDialog();
            if(loadSheet.newplayLists != null)
            {
                foreach(var list in loadSheet.newplayLists)
                {
                    playlists[list.Key] = list.Value;
                }
            }

            if(loadSheet.isValid)
            {
                List<string> requestedSongs = loadSheet.requestedPlayList;
                string requestedPlaylistName = loadSheet.requestedPlaylistName;
                playListLabel.Text = $"Loaded Playlist : {requestedPlaylistName}";
                listView1.Items.Clear();             

                foreach(string name in requestedSongs)
                {
                    listView1.Items.Add(name.Split('\\')[name.Split('\\').Length - 1]);
                }

                
                currentListName = requestedPlaylistName;
                currentList = requestedSongs;
                
                WMPLib.IWMPPlaylist playlist = mainMediaPlayer.playlistCollection.newPlaylist(currentListName);
                WMPLib.IWMPMedia media;
                foreach(string file in currentList)
                {
                    media = mainMediaPlayer.newMedia(file);
                    playlist.appendItem(media);
                }
                mainMediaPlayer.currentPlaylist = playlist;
                mainMediaPlayer.Ctlcontrols.play();
                CurrentSongLabel.Text = $"Current Song : {mainMediaPlayer.currentMedia.name}";
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var playlist = mainMediaPlayer.currentPlaylist;
            for (int i = 0; i < playlist.count;i++)
            {
                var item = playlist.Item[i];
                string sourceURL = item.sourceURL;
                string filename = sourceURL.Split('\\')[sourceURL.Split('\\').Length - 1];

                if(filename == listView1.FocusedItem.Text)
                {
                    if(mainMediaPlayer.currentMedia == item)
                    {
                        mainMediaPlayer.Ctlcontrols.currentPosition = 0;
                    }
                    else
                    {
                        mainMediaPlayer.Ctlcontrols.playItem(item);
                        CurrentSongLabel.Text = $"Current Song : {mainMediaPlayer.currentMedia.name}";
                    }
                }

            }
        }

        private void mainMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (mainMediaPlayer.playState == WMPPlayState.wmppsMediaEnded)
            {
                mainMediaPlayer.Ctlcontrols.play();
                CurrentSongLabel.Text = $"Current Song : {mainMediaPlayer.currentMedia.name}";
            }
        }
    }
}
