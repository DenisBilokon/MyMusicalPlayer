using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MusicalPlayerCourseWF._1._1
{
    internal class SpeedSlider
    {
        private AxWMPLib.AxWindowsMediaPlayer _player;
        private System.Windows.Forms.Label _lbl_speed;
        public SpeedSlider(AxWMPLib.AxWindowsMediaPlayer player, System.Windows.Forms.Label label)
        {
            _player = player;
            _lbl_speed = label;
        }
        public void SetSpeed(int value)
        {
            var speedDictionary = new Dictionary<int, double>() { { 1, 0.5 }, { 2, 0.75 }, { 3, 1 }, { 4, 1.25 }, { 5, 1.5 }, { 6, 2.0 } };

            _player.settings.rate = speedDictionary[value];
            _lbl_speed.Text = $"x {speedDictionary[value]}";

        }
    }
}
