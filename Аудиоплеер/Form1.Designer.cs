namespace Аудиоплеер
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
            this.Playlist = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEj = new System.Windows.Forms.Button();
            this.slTime = new MB.Controls.ColorSlider();
            this.slVol = new MB.Controls.ColorSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 16;
            this.Playlist.Location = new System.Drawing.Point(39, 28);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(456, 244);
            this.Playlist.TabIndex = 0;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_play_5157;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(39, 359);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_stop_1977;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(122, 359);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 50);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnEj
            // 
            this.btnEj.BackgroundImage = global::Аудиоплеер.Properties.Resources.player_eject_8621;
            this.btnEj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEj.Location = new System.Drawing.Point(445, 359);
            this.btnEj.Name = "btnEj";
            this.btnEj.Size = new System.Drawing.Size(50, 50);
            this.btnEj.TabIndex = 3;
            this.btnEj.UseVisualStyleBackColor = true;
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(39, 305);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(304, 30);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 4;
            this.slTime.Text = "colorSlider1";
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(373, 305);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(122, 30);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 5;
            this.slVol.Text = "colorSlider1";
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.slTime);
            this.Controls.Add(this.btnEj);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Playlist);
            this.MaximizeBox = false;
            this.Name = "Form1";
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
        private MB.Controls.ColorSlider slTime;
        private MB.Controls.ColorSlider slVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

