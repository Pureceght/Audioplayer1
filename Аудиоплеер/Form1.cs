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
            BassLike.InitBass(BassLike.HZ);
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
            Vars.Files.Add(openFileDialog1.FileName);
            Playlist.Items.Add(Vars.GerFileName(openFileDialog1.FileName));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != 1))
            {
                string current = Vars.Files[Playlist.SelectedIndex];
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
        }

        private void slTime_Scroll(object sender, ScrollEventArgs e)
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
    }
}
