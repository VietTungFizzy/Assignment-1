using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Language;
namespace Assignment_1_1
{
    class Game_over_form :Form
    {
        private PictureBox picBox_title_theme;
        private PictureBox picBox_description_theme;
        private Label lbl_play_again_title;
        private Label lbl_highScore_title;
        private Label lbl_highScore_Description;
        private Label lbl_score;
        private PictureBox picBox_replay_button;
        private Label lbl_error;
        private PictureBox picBox_progessbar_score_max;
        private PictureBox picBox_progressbar_highscore;
        private PictureBox picBox_progressbar_score;
        private Label lbl_progressbar_title;
        private Package status;
        public Game_over_form()
        {
            InitializeComponent();
            setup_parent_of_controls();
        }
        public Game_over_form(Package package)
        {
            InitializeComponent();
            setup_parent_of_controls();
            status = package;
            setup_interface();
        }
        private void InitializeComponent()
        {
            this.lbl_play_again_title = new System.Windows.Forms.Label();
            this.picBox_title_theme = new System.Windows.Forms.PictureBox();
            this.lbl_highScore_title = new System.Windows.Forms.Label();
            this.picBox_description_theme = new System.Windows.Forms.PictureBox();
            this.lbl_highScore_Description = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.picBox_replay_button = new System.Windows.Forms.PictureBox();
            this.picBox_progessbar_score_max = new System.Windows.Forms.PictureBox();
            this.picBox_progressbar_highscore = new System.Windows.Forms.PictureBox();
            this.picBox_progressbar_score = new System.Windows.Forms.PictureBox();
            this.lbl_progressbar_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_title_theme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_description_theme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_replay_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progessbar_score_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progressbar_highscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progressbar_score)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_play_again_title
            // 
            this.lbl_play_again_title.AutoSize = true;
            this.lbl_play_again_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(159)))), ((int)(((byte)(231)))));
            this.lbl_play_again_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_play_again_title.ForeColor = System.Drawing.Color.White;
            this.lbl_play_again_title.Location = new System.Drawing.Point(236, 32);
            this.lbl_play_again_title.Name = "lbl_play_again_title";
            this.lbl_play_again_title.Size = new System.Drawing.Size(76, 25);
            this.lbl_play_again_title.TabIndex = 3;
            this.lbl_play_again_title.Text = "label1";
            // 
            // picBox_title_theme
            // 
            this.picBox_title_theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(159)))), ((int)(((byte)(231)))));
            this.picBox_title_theme.Location = new System.Drawing.Point(12, 23);
            this.picBox_title_theme.Name = "picBox_title_theme";
            this.picBox_title_theme.Size = new System.Drawing.Size(554, 45);
            this.picBox_title_theme.TabIndex = 0;
            this.picBox_title_theme.TabStop = false;
            // 
            // lbl_highScore_title
            // 
            this.lbl_highScore_title.AutoSize = true;
            this.lbl_highScore_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.lbl_highScore_title.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highScore_title.ForeColor = System.Drawing.Color.Gray;
            this.lbl_highScore_title.Location = new System.Drawing.Point(219, 87);
            this.lbl_highScore_title.Name = "lbl_highScore_title";
            this.lbl_highScore_title.Size = new System.Drawing.Size(93, 32);
            this.lbl_highScore_title.TabIndex = 4;
            this.lbl_highScore_title.Text = "label2";
            // 
            // picBox_description_theme
            // 
            this.picBox_description_theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.picBox_description_theme.Location = new System.Drawing.Point(79, 74);
            this.picBox_description_theme.Name = "picBox_description_theme";
            this.picBox_description_theme.Size = new System.Drawing.Size(407, 290);
            this.picBox_description_theme.TabIndex = 1;
            this.picBox_description_theme.TabStop = false;
            // 
            // lbl_highScore_Description
            // 
            this.lbl_highScore_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.lbl_highScore_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highScore_Description.Location = new System.Drawing.Point(118, 140);
            this.lbl_highScore_Description.Name = "lbl_highScore_Description";
            this.lbl_highScore_Description.Size = new System.Drawing.Size(327, 137);
            this.lbl_highScore_Description.TabIndex = 5;
            this.lbl_highScore_Description.Text = "label3";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(13, 393);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(50, 18);
            this.lbl_score.TabIndex = 6;
            this.lbl_score.Text = "label4";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_error.Location = new System.Drawing.Point(510, 393);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(50, 18);
            this.lbl_error.TabIndex = 7;
            this.lbl_error.Text = "label5";
            // 
            // picBox_replay_button
            // 
            this.picBox_replay_button.BackColor = System.Drawing.Color.Transparent;
            this.picBox_replay_button.Image = global::Assignment_1_1.Properties.Resources.play_again_5;
            this.picBox_replay_button.Location = new System.Drawing.Point(496, 4);
            this.picBox_replay_button.Name = "picBox_replay_button";
            this.picBox_replay_button.Size = new System.Drawing.Size(42, 39);
            this.picBox_replay_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_replay_button.TabIndex = 8;
            this.picBox_replay_button.TabStop = false;
            this.picBox_replay_button.Click += new System.EventHandler(this.picBox_replay_button_Click);
            // 
            // picBox_progessbar_score_max
            // 
            this.picBox_progessbar_score_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.picBox_progessbar_score_max.Location = new System.Drawing.Point(12, 420);
            this.picBox_progessbar_score_max.Name = "picBox_progessbar_score_max";
            this.picBox_progessbar_score_max.Size = new System.Drawing.Size(553, 29);
            this.picBox_progessbar_score_max.TabIndex = 10;
            this.picBox_progessbar_score_max.TabStop = false;
            // 
            // picBox_progressbar_highscore
            // 
            this.picBox_progressbar_highscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(23)))));
            this.picBox_progressbar_highscore.Location = new System.Drawing.Point(12, 420);
            this.picBox_progressbar_highscore.Name = "picBox_progressbar_highscore";
            this.picBox_progressbar_highscore.Size = new System.Drawing.Size(0, 29);
            this.picBox_progressbar_highscore.TabIndex = 11;
            this.picBox_progressbar_highscore.TabStop = false;
            // 
            // picBox_progressbar_score
            // 
            this.picBox_progressbar_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(159)))), ((int)(((byte)(231)))));
            this.picBox_progressbar_score.Location = new System.Drawing.Point(12, 420);
            this.picBox_progressbar_score.Name = "picBox_progressbar_score";
            this.picBox_progressbar_score.Size = new System.Drawing.Size(0, 29);
            this.picBox_progressbar_score.TabIndex = 12;
            this.picBox_progressbar_score.TabStop = false;
            // 
            // lbl_progressbar_title
            // 
            this.lbl_progressbar_title.AutoSize = true;
            this.lbl_progressbar_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lbl_progressbar_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progressbar_title.ForeColor = System.Drawing.Color.White;
            this.lbl_progressbar_title.Location = new System.Drawing.Point(215, 425);
            this.lbl_progressbar_title.Name = "lbl_progressbar_title";
            this.lbl_progressbar_title.Size = new System.Drawing.Size(51, 16);
            this.lbl_progressbar_title.TabIndex = 13;
            this.lbl_progressbar_title.Text = "label1";
            // 
            // Game_over_form
            // 
            this.ClientSize = new System.Drawing.Size(596, 461);
            this.Controls.Add(this.lbl_progressbar_title);
            this.Controls.Add(this.picBox_progressbar_score);
            this.Controls.Add(this.picBox_progressbar_highscore);
            this.Controls.Add(this.picBox_progessbar_score_max);
            this.Controls.Add(this.picBox_replay_button);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_highScore_Description);
            this.Controls.Add(this.lbl_highScore_title);
            this.Controls.Add(this.lbl_play_again_title);
            this.Controls.Add(this.picBox_description_theme);
            this.Controls.Add(this.picBox_title_theme);
            this.Name = "Game_over_form";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_title_theme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_description_theme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_replay_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progessbar_score_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progressbar_highscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progressbar_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void setup_parent_of_controls()
        {
            this.picBox_replay_button.Parent = this.picBox_title_theme;
        }
        private void setup_interface()
        {
            //setup language
            if(status.language == Language.Vietnamese)
            {
                lbl_play_again_title.Text = Vietnamese.dialog41;
                lbl_score.Text = Vietnamese.dialog38 + status.packedScore;
                lbl_error.Text = Vietnamese.dialog39 + status.errorCount;
                lbl_progressbar_title.Text = Vietnamese.dialog37 + status.highScore;
                if(status.packedScore >0)
                {
                    lbl_highScore_title.Text = Vietnamese.dialog24;
                    lbl_highScore_Description.Text = Vietnamese.dialog23;
                }
                if (status.packedScore >4 )
                {
                    lbl_highScore_title.Text = Vietnamese.dialog25;
                    lbl_highScore_Description.Text = Vietnamese.dialog30;
                }
                if (status.packedScore >9 )
                {
                    lbl_highScore_title.Text = Vietnamese.dialog26;
                    lbl_highScore_Description.Text = Vietnamese.dialog31;
                }
                if (status.packedScore >14)
                {
                    lbl_highScore_title.Text = Vietnamese.dialog27;
                    lbl_highScore_Description.Text = Vietnamese.dialog32;
                }
                if (status.packedScore >19)
                {
                    lbl_highScore_title.Text = Vietnamese.dialog28;
                    lbl_highScore_Description.Text = Vietnamese.dialog33;
                }
                if (status.packedScore >24)
                {
                    lbl_highScore_title.Text = Vietnamese.dialog29;
                    lbl_highScore_Description.Text = Vietnamese.dialog34;
                }
                if(status.packedScore > 29)
                {
                    lbl_highScore_title.Text = Vietnamese.dialog36;
                    lbl_highScore_Description.Text = Vietnamese.dialog35;
                }
            }

            //setup button
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            //setup custom progress bar
            int progressMaxScore = 29;
            decimal pcdDone_score = 0 ;
            decimal pcdDone_highscore;
            this.picBox_progressbar_score.BringToFront();
            this.lbl_progressbar_title.BringToFront();
            if(pcdDone_score > 29)
            {
                pcdDone_score = (decimal)(status.packedScore - progressMaxScore) / progressMaxScore;
            }
            else
            {
                pcdDone_score = (decimal)(status.packedScore) / progressMaxScore;
            }
            pcdDone_highscore = (decimal)status.highScore / progressMaxScore;
            picBox_progressbar_score.Width = Convert.ToInt32(pcdDone_score * picBox_progessbar_score_max.Width);
            picBox_progressbar_highscore.Width = Convert.ToInt32(pcdDone_highscore * picBox_progessbar_score_max.Width);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void picBox_replay_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
