﻿namespace Аудиоплеер
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
            this.Playlist = new System.Windows.Forms.ListBox();
            this.slVol = new MB.Controls.ColorSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slTime = new MB.Controls.ColorSlider();
            this.btn_del = new System.Windows.Forms.Button();
            this.Плейлист = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnEj = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.srch = new System.Windows.Forms.TextBox();
            this.btnSrch = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.sprvk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 20;
            this.Playlist.Location = new System.Drawing.Point(37, 92);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(456, 244);
            this.Playlist.TabIndex = 0;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.Playlist.DoubleClick += new System.EventHandler(this.btnPlay_Click);
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BarInnerColor = System.Drawing.Color.Black;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(373, 374);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(122, 30);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 5;
            this.slVol.Text = "colorSlider1";
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.Value = 100;
            this.slVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVol_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BarInnerColor = System.Drawing.Color.Black;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(39, 374);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(304, 30);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 4;
            this.slTime.Text = "colorSlider1";
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.Value = 0;
            this.slTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.Location = new System.Drawing.Point(538, 92);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(105, 53);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Плейлист
            // 
            this.Плейлист.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Плейлист.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Плейлист.Location = new System.Drawing.Point(39, 58);
            this.Плейлист.Name = "Плейлист";
            this.Плейлист.ReadOnly = true;
            this.Плейлист.Size = new System.Drawing.Size(150, 28);
            this.Плейлист.TabIndex = 11;
            this.Плейлист.Text = "Ваш плейлист";
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.Location = new System.Drawing.Point(538, 195);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(105, 43);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Вверх по списку";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown.Location = new System.Drawing.Point(538, 256);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(105, 43);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Вниз по списку";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_start_7417;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(37, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_fwd_1145;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGo.Location = new System.Drawing.Point(151, 435);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 50);
            this.btnGo.TabIndex = 14;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_pause_1018;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.Location = new System.Drawing.Point(235, 435);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 8;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnEj
            // 
            this.btnEj.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_eject_8621;
            this.btnEj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEj.Location = new System.Drawing.Point(445, 435);
            this.btnEj.Name = "btnEj";
            this.btnEj.Size = new System.Drawing.Size(50, 50);
            this.btnEj.TabIndex = 3;
            this.btnEj.UseVisualStyleBackColor = true;
            this.btnEj.Click += new System.EventHandler(this.btnEj_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_stop_1977;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(293, 435);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 50);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_play_5157;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(95, 435);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // srch
            // 
            this.srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srch.Location = new System.Drawing.Point(210, 58);
            this.srch.MaxLength = 100;
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(283, 28);
            this.srch.TabIndex = 16;
            // 
            // btnSrch
            // 
            this.btnSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSrch.Location = new System.Drawing.Point(210, 26);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(75, 28);
            this.btnSrch.TabIndex = 17;
            this.btnSrch.Text = "Поиск";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClr.Location = new System.Drawing.Point(289, 26);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(93, 28);
            this.btnClr.TabIndex = 18;
            this.btnClr.Text = "Очистить";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // sprvk
            // 
            this.sprvk.Location = new System.Drawing.Point(388, 26);
            this.sprvk.Name = "sprvk";
            this.sprvk.Size = new System.Drawing.Size(105, 28);
            this.sprvk.TabIndex = 19;
            this.sprvk.Text = "Справка";
            this.sprvk.UseVisualStyleBackColor = true;
            this.sprvk.Click += new System.EventHandler(this.sprvk_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 497);
            this.Controls.Add(this.sprvk);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.Плейлист);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.slTime);
            this.Controls.Add(this.btnEj);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Playlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(691, 544);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аудиоплеер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEj;
        private MB.Controls.ColorSlider slVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private MB.Controls.ColorSlider slTime;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox Плейлист;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.TextBox srch;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Button btnClr;
        public System.Windows.Forms.Button sprvk;
    }
}

