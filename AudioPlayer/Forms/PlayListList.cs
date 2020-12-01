using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer.Forms
{
    public partial class PlayListList : Form
    {
        public PlayListList(Dictionary<string, List<string>> playLists = null)
        {
            InitializeComponent();
            if(playLists != null) FillList(playLists);
        }

        public void FillList(Dictionary<string,List<string>> playLists)
        {
            foreach(var playlist in playLists)
            {
                string[] subitems = { playlist.Key.ToString(), playlist.Value.Count.ToString() };
                ListViewItem listViewItem = new ListViewItem(subitems);
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
