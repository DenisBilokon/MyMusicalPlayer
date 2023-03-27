namespace MusicalPlayerCourseWF._1._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.track_speed = new System.Windows.Forms.TrackBar();
            this.btn_normalspeed = new System.Windows.Forms.Button();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(19, 247);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(644, 22);
            this.p_bar.TabIndex = 6;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.Silver;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.ForeColor = System.Drawing.Color.Yellow;
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(44, 282);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(448, 143);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(602, 29);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(45, 142);
            this.track_volume.TabIndex = 10;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Value = 100;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_volume.ForeColor = System.Drawing.Color.White;
            this.lbl_volume.Location = new System.Drawing.Point(599, 13);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(35, 13);
            this.lbl_volume.TabIndex = 12;
            this.lbl_volume.Text = "100%";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_track_start.Location = new System.Drawing.Point(12, 6);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(95, 38);
            this.lbl_track_start.TabIndex = 13;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_track_end.Location = new System.Drawing.Point(508, 6);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(95, 38);
            this.lbl_track_end.TabIndex = 14;
            this.lbl_track_end.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_speed);
            this.panel1.Controls.Add(this.track_speed);
            this.panel1.Controls.Add(this.btn_normalspeed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pic_art);
            this.panel1.Controls.Add(this.track_volume);
            this.panel1.Controls.Add(this.lbl_volume);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 199);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "speed";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_speed.ForeColor = System.Drawing.Color.White;
            this.lbl_speed.Location = new System.Drawing.Point(25, 13);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(19, 13);
            this.lbl_speed.TabIndex = 17;
            this.lbl_speed.Text = "x1";
            // 
            // track_speed
            // 
            this.track_speed.Location = new System.Drawing.Point(28, 29);
            this.track_speed.Maximum = 6;
            this.track_speed.Minimum = 1;
            this.track_speed.Name = "track_speed";
            this.track_speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_speed.Size = new System.Drawing.Size(45, 142);
            this.track_speed.TabIndex = 16;
            this.track_speed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_speed.Value = 3;
            this.track_speed.Scroll += new System.EventHandler(this.track_speed_Scroll);
            // 
            // btn_normalspeed
            // 
            this.btn_normalspeed.ForeColor = System.Drawing.Color.White;
            this.btn_normalspeed.Location = new System.Drawing.Point(79, 161);
            this.btn_normalspeed.Name = "btn_normalspeed";
            this.btn_normalspeed.Size = new System.Drawing.Size(77, 26);
            this.btn_normalspeed.TabIndex = 14;
            this.btn_normalspeed.Text = "return speed";
            this.btn_normalspeed.UseVisualStyleBackColor = false;
            this.btn_normalspeed.Click += new System.EventHandler(this.btn_normaltrack_Click);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::MusicalPlayerCourseWF._1._1.Properties.Resources.paintblack;
            this.pic_art.Location = new System.Drawing.Point(244, 12);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(197, 169);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Yellow;
            this.btn_stop.BackgroundImage = global::MusicalPlayerCourseWF._1._1.Properties.Resources.free_icon_earphone_3803898;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.Black;
            this.btn_stop.Location = new System.Drawing.Point(515, 386);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(54, 49);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Yellow;
            this.btn_open.BackgroundImage = global::MusicalPlayerCourseWF._1._1.Properties.Resources.free_icon_add_3803910;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(580, 386);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(54, 49);
            this.btn_open.TabIndex = 5;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Yellow;
            this.btn_preview.BackgroundImage = global::MusicalPlayerCourseWF._1._1.Properties.Resources.free_icon_backward_3803919;
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.Color.Black;
            this.btn_preview.Location = new System.Drawing.Point(515, 276);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(54, 49);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Yellow;
            this.btn_pause.BackgroundImage = global::MusicalPlayerCourseWF._1._1.Properties.Resources.free_icon_pause_3803904;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.Black;
            this.btn_pause.Location = new System.Drawing.Point(515, 331);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(54, 49);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Yellow;
            this.btn_next.BackgroundImage = global::MusicalPlayerCourseWF._1._1.Properties.Resources.free_icon_forward_3803916;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Black;
            this.btn_next.Location = new System.Drawing.Point(580, 275);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(54, 49);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Yellow;
            this.btn_play.BackgroundImage = global::MusicalPlayerCourseWF._1._1.Properties.Resources.free_icon_play_3803883;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.Black;
            this.btn_play.Location = new System.Drawing.Point(580, 331);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(54, 49);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.Red;
            this.btn_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_end.ForeColor = System.Drawing.Color.White;
            this.btn_end.Location = new System.Drawing.Point(602, -1);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(64, 45);
            this.btn_end.TabIndex = 16;
            this.btn_end.Text = "X";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Black;
            this.lbl_name.Font = new System.Drawing.Font("Palace Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_name.Location = new System.Drawing.Point(300, 6);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(75, 34);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Name";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(666, 48);
            this.player.TabIndex = 9;
            this.player.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbl_track_start);
            this.panel2.Controls.Add(this.lbl_track_end);
            this.panel2.Controls.Add(this.btn_end);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 48);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(666, 437);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.player);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_normalspeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.TrackBar track_speed;
    }
}

