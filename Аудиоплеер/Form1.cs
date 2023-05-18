using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аудиоплеер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Vars.Link = this;
            BassLike.InitBass(BassLike.HZ);
            Vars.SetInputFormats();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEj_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                Vars.Files.Add(tmp[i]);
                TagModel TM = new TagModel(tmp[i]);
                Playlist.Items.Add(TM.Artist + " - " + TM.Title);
            }
            Playlist.SelectedIndex = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
            {
                string current = Vars.Files[Playlist.SelectedIndex];
                Vars.CurrentTrackNumber = Playlist.SelectedIndex;
                BassLike.Play(current, BassLike.Volume);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                timer1.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
            label2.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);

            if (BassLike.ToNextTrack())
            {
                Playlist.SelectedIndex = Vars.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                slTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                slTime.Value = 0;
            }
            if (BassLike.EndPlaylist)
            {
                btnStop_Click(this, new EventArgs());
                Playlist.SelectedIndex = Vars.CurrentTrackNumber = 0;
                BassLike.EndPlaylist = false;
            }
        }

        private void slTime_Scroll(object sender, EventArgs e)
        {
            BassLike.SetPosOfScroll(BassLike.Stream, slTime.Value);
        }

        private void slVol_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            BassLike.Pause();
        }
        /*static void RemoveEl(ref string[] array, int index)
        {
            string[] newArray = new string[array.Length - 1];
            for(int i = 0; i < index; i++)
                newArray[i] = array[i];
            for(int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];
            array = newArray;
        }*/
        private void btn_del_Click(object sender, EventArgs e)
        {
            int j = Playlist.SelectedIndex;
            if (Playlist.SelectedIndex > 0)
            {
                Vars.Files.RemoveAt(Playlist.SelectedIndex);
                Playlist.Items.RemoveAt(Playlist.SelectedIndex);
                BassLike.Stop();
                timer1.Enabled = false;
                slTime.Value = 0;
                label1.Text = "00:00:00";
                label2.Text = "00:00:00";
                Playlist.SelectedIndex = j - 1;
                //RemoveEl(ref tmp, Playlist.SelectedIndex);
            }
            else if (Playlist.SelectedIndex == 0)
            {
                Vars.Files.RemoveAt(Playlist.SelectedIndex);
                Playlist.Items.RemoveAt(Playlist.SelectedIndex);
                BassLike.Stop();
                timer1.Enabled = false;
                slTime.Value = 0;
                label1.Text = "00:00:00";
                label2.Text = "00:00:00";
                //Playlist.SelectedIndex = 0;
            }
            else if (Playlist.Items.Count == 0)
            {
                BassLike.Stop();
                timer1.Enabled = false;
                slTime.Value = 0;
                label1.Text = "00:00:00";
                label2.Text = "00:00:00";
            }                

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            if(Playlist.SelectedIndex > 0)
            {
                BassLike.Stop();
                timer1.Enabled = false;
                slTime.Value = 0;
                label1.Text = "00:00:00";
                label2.Text = "00:00:00";
                int index = Playlist.SelectedIndex;
                String text = Playlist.SelectedItem.ToString();
                var R = Vars.Files[Playlist.SelectedIndex];
                Vars.Files.RemoveAt(Playlist.SelectedIndex);
                Vars.Files.Insert(index-1, R);

                Playlist.Items.RemoveAt(Playlist.SelectedIndex);
                Playlist.Items.Insert(index-1, text);
                Playlist.SelectedIndex = index - 1;

            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if ((Playlist.SelectedIndex < Playlist.Items.Count - 1) && (Playlist.SelectedIndex != -1))
            {
                BassLike.Stop();
                timer1.Enabled = false;
                slTime.Value = 0;
                label1.Text = "00:00:00";
                label2.Text = "00:00:00";
                int index = Playlist.SelectedIndex;
                String text = Playlist.SelectedItem.ToString();
                var R = Vars.Files[Playlist.SelectedIndex];
                Vars.Files.RemoveAt(Playlist.SelectedIndex);
                Vars.Files.Insert(index + 1, R);

                Playlist.Items.RemoveAt(Playlist.SelectedIndex);
                Playlist.Items.Insert(index + 1, text);
                Playlist.SelectedIndex = index + 1;

            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if((Playlist.SelectedIndex != -1) && (Playlist.SelectedIndex != Playlist.Items.Count - 1))
            {
                Playlist.SelectedIndex++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if ((Playlist.SelectedIndex != -1) && (Playlist.SelectedIndex != 0))
            {
                Playlist.SelectedIndex--;
            }
        }
    }
}
