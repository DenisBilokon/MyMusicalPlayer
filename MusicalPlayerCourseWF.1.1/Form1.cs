using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicalPlayerCourseWF._1._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
            lbl_volume.Text = "50%";
            lbl_speed.Text = "x1";
        }
        string[] paths, files;


        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            p_bar.Value = 0;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;

                try
                {
                    lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }

        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_normaltrack_Click(object sender, EventArgs e)
        {
            player.settings.rate = 1.0;
            track_speed.Value = 3;
            lbl_speed.Text = "x 1";
        }


        private void track_speed_Scroll(object sender, EventArgs e)
        {
            switch(track_speed.Value)
            {
                case 1:
           
                player.settings.rate = 0.5;
                lbl_speed.Text = "x 0.5";
                    break;
                case 2:
            
                player.settings.rate = 0.75;
               lbl_speed.Text = "x 0.75";
                    break;
                case 3:
            
                player.settings.rate = 1.0;
                lbl_speed.Text = "x 1";
                    break;
                case 4:
            
                player.settings.rate = 1.25;
                lbl_speed.Text = "x 1.25";
                    break;
                case 5:
            
                player.settings.rate = 1.5;
                lbl_speed.Text = "x 1.5";
                    break;
                case 6:
            
               player.settings.rate = 2.0;
                lbl_speed.Text = "x 2";
                    break;
            }
            #region if (debug)
            //if (track_speed.Value == 1)
            //{
            //    player.settings.rate = 0.5;
            //    lbl_speed.Text = "x 0.5";
            //}
            //if (track_speed.Value == 2)
            //{
            //    player.settings.rate = 0.75;
            //    lbl_speed.Text = "x 0.75";
            //}
            //if (player.settings.rate == 3)
            //{
            //    player.settings.rate = 1.0;
            //    lbl_speed.Text = "x 1";
            //}
            //if (track_speed.Value == 4)
            //{
            //    player.settings.rate = 1.25;
            //    lbl_speed.Text = "x 1.25";
            //}
            //if (track_speed.Value == 5)
            //{
            //    player.settings.rate = 1.5;
            //    lbl_speed.Text = "x 1.5";
            //}
            //if (track_speed.Value == 6)
            //{
            //    player.settings.rate = 2.0;
            //    lbl_speed.Text = "x 2";
            //}
            //   player.settings.rate = track_speed.Value;
            //   lbl_speed.Text = track_speed.Value.ToString() + "%";
            #endregion
        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }

        }
    }
}
