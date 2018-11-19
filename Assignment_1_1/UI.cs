using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Language;
namespace Assignment_1_1
{
    class UI : Form
    {
        private Engine engine = new Engine();
        private PictureBox picBox_MultiLang;
        private PictureBox picBox_EyeDoctor;
        private PictureBox picBox_Bat;
        private PictureBox picBox_Mole;
        private PictureBox picBox_Dog;
        private PictureBox picBox_Cat;
        private PictureBox picBox_Tiger;
        private PictureBox picBox_Eagle;
        private PictureBox picBox_score;
        private PictureBox picBox_error;
        private PictureBox picBox_CircleTime;
        private Package status;
        private Label lbl_score_title;
        private Label lbl_error_title;
        private Label lbl_announcement;
        private Label lbl_highscore_title;
        private Label lbl_bat_highscore;
        private Label lbl_bat_score_range;
        private Label lbl_mole_score_range;
        private Label lbl_mole_highscore;
        private Label lbl_dog_score_range;
        private Label lbl_dog_highscore;
        private Label lbl_cat_score_range;
        private Label lbl_cat_highscore;
        private Label lbl_tiger_score_range;
        private Label lbl_tiger_highscore;
        private Label lbl_eagle_score_range;
        private Label lbl_eagle_highscore;
        private Label lbl_time;
        private Label lbl_play_area_title;
        private Label lbl_score;
        private Label lbl_error;
        private Label lbl_instruction_1;
        private Label lbl_instruction_title;
        private Label lbl_instruction_3;
        private Label lbl_instruction_2;
        private Label lbl_instruction_4;
        private Timer timer = new Timer();
        private Panel playArea = new Panel();
        private PictureBox picBox_progressbar_effect;
        private Panel panel_progressbar;
        private PictureBox[] pictureBoxes;
        public UI()
        {
            status = engine.send_result();
            InitializeComponent();
            loading_level();
            loading_language();
            
        }
        
        //fix the border style, i want border to be white
        //correction factor

        //main function
        private void InitializeComponent()
        {
            this.picBox_CircleTime = new System.Windows.Forms.PictureBox();
            this.picBox_error = new System.Windows.Forms.PictureBox();
            this.picBox_score = new System.Windows.Forms.PictureBox();
            this.picBox_Eagle = new System.Windows.Forms.PictureBox();
            this.picBox_Tiger = new System.Windows.Forms.PictureBox();
            this.picBox_Cat = new System.Windows.Forms.PictureBox();
            this.picBox_Dog = new System.Windows.Forms.PictureBox();
            this.picBox_Mole = new System.Windows.Forms.PictureBox();
            this.picBox_Bat = new System.Windows.Forms.PictureBox();
            this.picBox_EyeDoctor = new System.Windows.Forms.PictureBox();
            this.picBox_MultiLang = new System.Windows.Forms.PictureBox();
            this.lbl_score_title = new System.Windows.Forms.Label();
            this.lbl_error_title = new System.Windows.Forms.Label();
            this.lbl_announcement = new System.Windows.Forms.Label();
            this.lbl_highscore_title = new System.Windows.Forms.Label();
            this.lbl_bat_highscore = new System.Windows.Forms.Label();
            this.lbl_bat_score_range = new System.Windows.Forms.Label();
            this.lbl_mole_score_range = new System.Windows.Forms.Label();
            this.lbl_mole_highscore = new System.Windows.Forms.Label();
            this.lbl_dog_score_range = new System.Windows.Forms.Label();
            this.lbl_dog_highscore = new System.Windows.Forms.Label();
            this.lbl_cat_score_range = new System.Windows.Forms.Label();
            this.lbl_cat_highscore = new System.Windows.Forms.Label();
            this.lbl_tiger_score_range = new System.Windows.Forms.Label();
            this.lbl_tiger_highscore = new System.Windows.Forms.Label();
            this.lbl_eagle_score_range = new System.Windows.Forms.Label();
            this.lbl_eagle_highscore = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_play_area_title = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_instruction_1 = new System.Windows.Forms.Label();
            this.lbl_instruction_title = new System.Windows.Forms.Label();
            this.lbl_instruction_3 = new System.Windows.Forms.Label();
            this.lbl_instruction_2 = new System.Windows.Forms.Label();
            this.lbl_instruction_4 = new System.Windows.Forms.Label();
            this.picBox_progressbar_effect = new System.Windows.Forms.PictureBox();
            this.panel_progressbar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CircleTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Eagle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Tiger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Mole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_EyeDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_MultiLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progressbar_effect)).BeginInit();
            this.panel_progressbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox_CircleTime
            // 
            this.picBox_CircleTime.Image = global::Assignment_1_1.Properties.Resources.circle;
            this.picBox_CircleTime.Location = new System.Drawing.Point(1060, 31);
            this.picBox_CircleTime.Name = "picBox_CircleTime";
            this.picBox_CircleTime.Size = new System.Drawing.Size(63, 64);
            this.picBox_CircleTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_CircleTime.TabIndex = 10;
            this.picBox_CircleTime.TabStop = false;
            // 
            // picBox_error
            // 
            this.picBox_error.BackColor = System.Drawing.Color.Red;
            this.picBox_error.Location = new System.Drawing.Point(991, 265);
            this.picBox_error.Name = "picBox_error";
            this.picBox_error.Size = new System.Drawing.Size(100, 50);
            this.picBox_error.TabIndex = 9;
            this.picBox_error.TabStop = false;
            // 
            // picBox_score
            // 
            this.picBox_score.BackColor = System.Drawing.Color.DodgerBlue;
            this.picBox_score.Location = new System.Drawing.Point(991, 179);
            this.picBox_score.Name = "picBox_score";
            this.picBox_score.Size = new System.Drawing.Size(100, 50);
            this.picBox_score.TabIndex = 8;
            this.picBox_score.TabStop = false;
            // 
            // picBox_Eagle
            // 
            this.picBox_Eagle.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Eagle.Image = global::Assignment_1_1.Properties.Resources.ac_6;
            this.picBox_Eagle.Location = new System.Drawing.Point(965, 644);
            this.picBox_Eagle.Name = "picBox_Eagle";
            this.picBox_Eagle.Size = new System.Drawing.Size(136, 139);
            this.picBox_Eagle.TabIndex = 7;
            this.picBox_Eagle.TabStop = false;
            // 
            // picBox_Tiger
            // 
            this.picBox_Tiger.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Tiger.Image = global::Assignment_1_1.Properties.Resources.ac_5;
            this.picBox_Tiger.Location = new System.Drawing.Point(796, 644);
            this.picBox_Tiger.Name = "picBox_Tiger";
            this.picBox_Tiger.Size = new System.Drawing.Size(136, 139);
            this.picBox_Tiger.TabIndex = 6;
            this.picBox_Tiger.TabStop = false;
            // 
            // picBox_Cat
            // 
            this.picBox_Cat.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Cat.Image = global::Assignment_1_1.Properties.Resources.ac_4;
            this.picBox_Cat.Location = new System.Drawing.Point(622, 644);
            this.picBox_Cat.Name = "picBox_Cat";
            this.picBox_Cat.Size = new System.Drawing.Size(136, 139);
            this.picBox_Cat.TabIndex = 5;
            this.picBox_Cat.TabStop = false;
            // 
            // picBox_Dog
            // 
            this.picBox_Dog.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Dog.Image = global::Assignment_1_1.Properties.Resources.ac_3;
            this.picBox_Dog.Location = new System.Drawing.Point(454, 644);
            this.picBox_Dog.Name = "picBox_Dog";
            this.picBox_Dog.Size = new System.Drawing.Size(136, 139);
            this.picBox_Dog.TabIndex = 4;
            this.picBox_Dog.TabStop = false;
            // 
            // picBox_Mole
            // 
            this.picBox_Mole.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Mole.Image = global::Assignment_1_1.Properties.Resources.ac_2;
            this.picBox_Mole.Location = new System.Drawing.Point(280, 644);
            this.picBox_Mole.Name = "picBox_Mole";
            this.picBox_Mole.Size = new System.Drawing.Size(136, 139);
            this.picBox_Mole.TabIndex = 3;
            this.picBox_Mole.TabStop = false;
            // 
            // picBox_Bat
            // 
            this.picBox_Bat.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Bat.Image = global::Assignment_1_1.Properties.Resources.ac_1;
            this.picBox_Bat.Location = new System.Drawing.Point(108, 644);
            this.picBox_Bat.Name = "picBox_Bat";
            this.picBox_Bat.Size = new System.Drawing.Size(136, 139);
            this.picBox_Bat.TabIndex = 2;
            this.picBox_Bat.TabStop = false;
            // 
            // picBox_EyeDoctor
            // 
            this.picBox_EyeDoctor.Image = global::Assignment_1_1.Properties.Resources.eye_doctor2;
            this.picBox_EyeDoctor.Location = new System.Drawing.Point(53, 40);
            this.picBox_EyeDoctor.Name = "picBox_EyeDoctor";
            this.picBox_EyeDoctor.Size = new System.Drawing.Size(460, 454);
            this.picBox_EyeDoctor.TabIndex = 1;
            this.picBox_EyeDoctor.TabStop = false;
            // 
            // picBox_MultiLang
            // 
            this.picBox_MultiLang.Image = global::Assignment_1_1.Properties.Resources.multlang;
            this.picBox_MultiLang.Location = new System.Drawing.Point(12, 12);
            this.picBox_MultiLang.Name = "picBox_MultiLang";
            this.picBox_MultiLang.Size = new System.Drawing.Size(34, 31);
            this.picBox_MultiLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_MultiLang.TabIndex = 0;
            this.picBox_MultiLang.TabStop = false;
            this.picBox_MultiLang.Click += new System.EventHandler(this.picBox_MultiLang_Click);
            // 
            // lbl_score_title
            // 
            this.lbl_score_title.AutoSize = true;
            this.lbl_score_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score_title.Location = new System.Drawing.Point(1025, 151);
            this.lbl_score_title.Name = "lbl_score_title";
            this.lbl_score_title.Size = new System.Drawing.Size(52, 18);
            this.lbl_score_title.TabIndex = 11;
            this.lbl_score_title.Text = "label1";
            // 
            // lbl_error_title
            // 
            this.lbl_error_title.AutoSize = true;
            this.lbl_error_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_title.Location = new System.Drawing.Point(1030, 240);
            this.lbl_error_title.Name = "lbl_error_title";
            this.lbl_error_title.Size = new System.Drawing.Size(52, 18);
            this.lbl_error_title.TabIndex = 12;
            this.lbl_error_title.Text = "label2";
            // 
            // lbl_announcement
            // 
            this.lbl_announcement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_announcement.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_announcement.Location = new System.Drawing.Point(108, 100);
            this.lbl_announcement.Name = "lbl_announcement";
            this.lbl_announcement.Size = new System.Drawing.Size(117, 78);
            this.lbl_announcement.TabIndex = 13;
            this.lbl_announcement.Text = "label3";
            // 
            // lbl_highscore_title
            // 
            this.lbl_highscore_title.AutoSize = true;
            this.lbl_highscore_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(143)))), ((int)(((byte)(216)))));
            this.lbl_highscore_title.Location = new System.Drawing.Point(108, 571);
            this.lbl_highscore_title.Name = "lbl_highscore_title";
            this.lbl_highscore_title.Size = new System.Drawing.Size(81, 29);
            this.lbl_highscore_title.TabIndex = 14;
            this.lbl_highscore_title.Text = "label4";
            // 
            // lbl_bat_highscore
            // 
            this.lbl_bat_highscore.AutoSize = true;
            this.lbl_bat_highscore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bat_highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_bat_highscore.Location = new System.Drawing.Point(91, 174);
            this.lbl_bat_highscore.Name = "lbl_bat_highscore";
            this.lbl_bat_highscore.Size = new System.Drawing.Size(50, 18);
            this.lbl_bat_highscore.TabIndex = 15;
            this.lbl_bat_highscore.Text = "label5";
            // 
            // lbl_bat_score_range
            // 
            this.lbl_bat_score_range.AutoSize = true;
            this.lbl_bat_score_range.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_bat_score_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_bat_score_range.Location = new System.Drawing.Point(102, 203);
            this.lbl_bat_score_range.Name = "lbl_bat_score_range";
            this.lbl_bat_score_range.Size = new System.Drawing.Size(50, 18);
            this.lbl_bat_score_range.TabIndex = 16;
            this.lbl_bat_score_range.Text = "label6";
            // 
            // lbl_mole_score_range
            // 
            this.lbl_mole_score_range.AutoSize = true;
            this.lbl_mole_score_range.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mole_score_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_mole_score_range.Location = new System.Drawing.Point(280, 203);
            this.lbl_mole_score_range.Name = "lbl_mole_score_range";
            this.lbl_mole_score_range.Size = new System.Drawing.Size(50, 18);
            this.lbl_mole_score_range.TabIndex = 18;
            this.lbl_mole_score_range.Text = "label7";
            // 
            // lbl_mole_highscore
            // 
            this.lbl_mole_highscore.AutoSize = true;
            this.lbl_mole_highscore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mole_highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_mole_highscore.Location = new System.Drawing.Point(261, 174);
            this.lbl_mole_highscore.Name = "lbl_mole_highscore";
            this.lbl_mole_highscore.Size = new System.Drawing.Size(50, 18);
            this.lbl_mole_highscore.TabIndex = 17;
            this.lbl_mole_highscore.Text = "label8";
            // 
            // lbl_dog_score_range
            // 
            this.lbl_dog_score_range.AutoSize = true;
            this.lbl_dog_score_range.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dog_score_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_dog_score_range.Location = new System.Drawing.Point(505, 817);
            this.lbl_dog_score_range.Name = "lbl_dog_score_range";
            this.lbl_dog_score_range.Size = new System.Drawing.Size(50, 18);
            this.lbl_dog_score_range.TabIndex = 20;
            this.lbl_dog_score_range.Text = "label9";
            // 
            // lbl_dog_highscore
            // 
            this.lbl_dog_highscore.AutoSize = true;
            this.lbl_dog_highscore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dog_highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_dog_highscore.Location = new System.Drawing.Point(448, 174);
            this.lbl_dog_highscore.Name = "lbl_dog_highscore";
            this.lbl_dog_highscore.Size = new System.Drawing.Size(59, 18);
            this.lbl_dog_highscore.TabIndex = 19;
            this.lbl_dog_highscore.Text = "label10";
            // 
            // lbl_cat_score_range
            // 
            this.lbl_cat_score_range.AutoSize = true;
            this.lbl_cat_score_range.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat_score_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_cat_score_range.Location = new System.Drawing.Point(669, 817);
            this.lbl_cat_score_range.Name = "lbl_cat_score_range";
            this.lbl_cat_score_range.Size = new System.Drawing.Size(58, 18);
            this.lbl_cat_score_range.TabIndex = 22;
            this.lbl_cat_score_range.Text = "label11";
            // 
            // lbl_cat_highscore
            // 
            this.lbl_cat_highscore.AutoSize = true;
            this.lbl_cat_highscore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat_highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_cat_highscore.Location = new System.Drawing.Point(606, 176);
            this.lbl_cat_highscore.Name = "lbl_cat_highscore";
            this.lbl_cat_highscore.Size = new System.Drawing.Size(59, 18);
            this.lbl_cat_highscore.TabIndex = 21;
            this.lbl_cat_highscore.Text = "label12";
            // 
            // lbl_tiger_score_range
            // 
            this.lbl_tiger_score_range.AutoSize = true;
            this.lbl_tiger_score_range.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiger_score_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_tiger_score_range.Location = new System.Drawing.Point(845, 817);
            this.lbl_tiger_score_range.Name = "lbl_tiger_score_range";
            this.lbl_tiger_score_range.Size = new System.Drawing.Size(59, 18);
            this.lbl_tiger_score_range.TabIndex = 24;
            this.lbl_tiger_score_range.Text = "label13";
            // 
            // lbl_tiger_highscore
            // 
            this.lbl_tiger_highscore.AutoSize = true;
            this.lbl_tiger_highscore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiger_highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_tiger_highscore.Location = new System.Drawing.Point(790, 174);
            this.lbl_tiger_highscore.Name = "lbl_tiger_highscore";
            this.lbl_tiger_highscore.Size = new System.Drawing.Size(59, 18);
            this.lbl_tiger_highscore.TabIndex = 23;
            this.lbl_tiger_highscore.Text = "label14";
            // 
            // lbl_eagle_score_range
            // 
            this.lbl_eagle_score_range.AutoSize = true;
            this.lbl_eagle_score_range.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eagle_score_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_eagle_score_range.Location = new System.Drawing.Point(1016, 817);
            this.lbl_eagle_score_range.Name = "lbl_eagle_score_range";
            this.lbl_eagle_score_range.Size = new System.Drawing.Size(59, 18);
            this.lbl_eagle_score_range.TabIndex = 26;
            this.lbl_eagle_score_range.Text = "label15";
            // 
            // lbl_eagle_highscore
            // 
            this.lbl_eagle_highscore.AutoSize = true;
            this.lbl_eagle_highscore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eagle_highscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.lbl_eagle_highscore.Location = new System.Drawing.Point(954, 176);
            this.lbl_eagle_highscore.Name = "lbl_eagle_highscore";
            this.lbl_eagle_highscore.Size = new System.Drawing.Size(59, 18);
            this.lbl_eagle_highscore.TabIndex = 25;
            this.lbl_eagle_highscore.Text = "label16";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("VNI-Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_time.Location = new System.Drawing.Point(1075, 45);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(85, 27);
            this.lbl_time.TabIndex = 27;
            this.lbl_time.Text = "label17";
            // 
            // lbl_play_area_title
            // 
            this.lbl_play_area_title.AutoSize = true;
            this.lbl_play_area_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_play_area_title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_play_area_title.Location = new System.Drawing.Point(494, 31);
            this.lbl_play_area_title.Name = "lbl_play_area_title";
            this.lbl_play_area_title.Size = new System.Drawing.Size(116, 33);
            this.lbl_play_area_title.TabIndex = 28;
            this.lbl_play_area_title.Text = "label18";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_score.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_score.Location = new System.Drawing.Point(1034, 193);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(74, 24);
            this.lbl_score.TabIndex = 29;
            this.lbl_score.Text = "label1";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Red;
            this.lbl_error.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_error.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_error.Location = new System.Drawing.Point(1034, 280);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(74, 24);
            this.lbl_error.TabIndex = 30;
            this.lbl_error.Text = "label2";
            // 
            // lbl_instruction_1
            // 
            this.lbl_instruction_1.AutoSize = true;
            this.lbl_instruction_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction_1.Location = new System.Drawing.Point(92, 901);
            this.lbl_instruction_1.Name = "lbl_instruction_1";
            this.lbl_instruction_1.Size = new System.Drawing.Size(46, 18);
            this.lbl_instruction_1.TabIndex = 32;
            this.lbl_instruction_1.Text = "label1";
            // 
            // lbl_instruction_title
            // 
            this.lbl_instruction_title.AutoSize = true;
            this.lbl_instruction_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_instruction_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(143)))), ((int)(((byte)(216)))));
            this.lbl_instruction_title.Location = new System.Drawing.Point(90, 858);
            this.lbl_instruction_title.Name = "lbl_instruction_title";
            this.lbl_instruction_title.Size = new System.Drawing.Size(81, 29);
            this.lbl_instruction_title.TabIndex = 31;
            this.lbl_instruction_title.Text = "label2";
            // 
            // lbl_instruction_3
            // 
            this.lbl_instruction_3.AutoSize = true;
            this.lbl_instruction_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction_3.Location = new System.Drawing.Point(92, 953);
            this.lbl_instruction_3.Name = "lbl_instruction_3";
            this.lbl_instruction_3.Size = new System.Drawing.Size(46, 18);
            this.lbl_instruction_3.TabIndex = 34;
            this.lbl_instruction_3.Text = "label4";
            // 
            // lbl_instruction_2
            // 
            this.lbl_instruction_2.AutoSize = true;
            this.lbl_instruction_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction_2.Location = new System.Drawing.Point(92, 927);
            this.lbl_instruction_2.Name = "lbl_instruction_2";
            this.lbl_instruction_2.Size = new System.Drawing.Size(54, 18);
            this.lbl_instruction_2.TabIndex = 33;
            this.lbl_instruction_2.Text = "label17";
            // 
            // lbl_instruction_4
            // 
            this.lbl_instruction_4.AutoSize = true;
            this.lbl_instruction_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction_4.Location = new System.Drawing.Point(92, 977);
            this.lbl_instruction_4.Name = "lbl_instruction_4";
            this.lbl_instruction_4.Size = new System.Drawing.Size(46, 18);
            this.lbl_instruction_4.TabIndex = 35;
            this.lbl_instruction_4.Text = "label1";
            // 
            // picBox_progressbar_effect
            // 
            this.picBox_progressbar_effect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.picBox_progressbar_effect.Location = new System.Drawing.Point(0, 0);
            this.picBox_progressbar_effect.Name = "picBox_progressbar_effect";
            this.picBox_progressbar_effect.Size = new System.Drawing.Size(0, 235);
            this.picBox_progressbar_effect.TabIndex = 36;
            this.picBox_progressbar_effect.TabStop = false;
            // 
            // panel_progressbar
            // 
            this.panel_progressbar.Controls.Add(this.picBox_progressbar_effect);
            this.panel_progressbar.Controls.Add(this.lbl_bat_highscore);
            this.panel_progressbar.Controls.Add(this.lbl_bat_score_range);
            this.panel_progressbar.Controls.Add(this.lbl_mole_highscore);
            this.panel_progressbar.Controls.Add(this.lbl_mole_score_range);
            this.panel_progressbar.Controls.Add(this.lbl_dog_highscore);
            this.panel_progressbar.Controls.Add(this.lbl_cat_highscore);
            this.panel_progressbar.Controls.Add(this.lbl_tiger_highscore);
            this.panel_progressbar.Controls.Add(this.lbl_eagle_highscore);
            this.panel_progressbar.Location = new System.Drawing.Point(53, 614);
            this.panel_progressbar.Name = "panel_progressbar";
            this.panel_progressbar.Size = new System.Drawing.Size(1143, 241);
            this.panel_progressbar.TabIndex = 37;
            // 
            // UI
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1417, 1021);
            this.Controls.Add(this.lbl_instruction_4);
            this.Controls.Add(this.lbl_instruction_3);
            this.Controls.Add(this.lbl_instruction_2);
            this.Controls.Add(this.lbl_instruction_1);
            this.Controls.Add(this.lbl_instruction_title);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_play_area_title);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_eagle_score_range);
            this.Controls.Add(this.lbl_tiger_score_range);
            this.Controls.Add(this.lbl_cat_score_range);
            this.Controls.Add(this.lbl_dog_score_range);
            this.Controls.Add(this.lbl_highscore_title);
            this.Controls.Add(this.lbl_announcement);
            this.Controls.Add(this.lbl_error_title);
            this.Controls.Add(this.lbl_score_title);
            this.Controls.Add(this.picBox_CircleTime);
            this.Controls.Add(this.picBox_error);
            this.Controls.Add(this.picBox_score);
            this.Controls.Add(this.picBox_Eagle);
            this.Controls.Add(this.picBox_Tiger);
            this.Controls.Add(this.picBox_Cat);
            this.Controls.Add(this.picBox_Dog);
            this.Controls.Add(this.picBox_Mole);
            this.Controls.Add(this.picBox_Bat);
            this.Controls.Add(this.picBox_EyeDoctor);
            this.Controls.Add(this.picBox_MultiLang);
            this.Controls.Add(this.panel_progressbar);
            this.Name = "UI";
            this.Text = "UI";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CircleTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Eagle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Tiger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Mole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_EyeDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_MultiLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_progressbar_effect)).EndInit();
            this.panel_progressbar.ResumeLayout(false);
            this.panel_progressbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Color[] colors = new Color[]
                {
                    SystemColors.ControlDark,
                    SystemColors.ControlLightLight
                };
            using (Pen pen = new Pen(colors[0]))
            {
                e.Graphics.DrawLine(pen, 537, 491, 1101, 491);
                e.Graphics.DrawLine(pen, 1101, 491, 1101, 40);
            }
            using (Pen pen = new Pen(colors[1]))
            {
                e.Graphics.DrawLine(pen, 537, 490, 1101, 490);
                e.Graphics.DrawLine(pen, 1100, 491, 1100, 40);
            }
            
        }
        
        private void loading_level()
        {
            pictureBoxes = new PictureBox[status.level * status.level];
            playArea.Size = new Size(400, 400);
            playArea.Location = new Point(525, 80);
            Controls.Add(playArea);
            byte index = 0;
            //blank = 10
            for (int row = 0; row < status.level; row++)
            {
                for (int column = 0; column < status.level; column++)
                {
                    
                    pictureBoxes[index] = new PictureBox();
                    pictureBoxes[index].BackColor = status.wrongColor;
                    pictureBoxes[index].Width = (playArea.Width - 10) / status.level;
                    pictureBoxes[index].Height = (playArea.Height - 10) / status.level;
                    pictureBoxes[index].Location = new Point(row * pictureBoxes[index].Height + 10, column * pictureBoxes[index].Width + 10);
                    pictureBoxes[index].Click += get_wrong_color;
                    pictureBoxes[index].BorderStyle = BorderStyle.FixedSingle;
                    playArea.Controls.Add(pictureBoxes[index]);
                    index++;
                }
            }
            Random r = new Random();
            int rd = r.Next(status.level *status.level-1);
            pictureBoxes[rd].BackColor = status.rightColor;
            pictureBoxes[rd].Click -= get_wrong_color;
            pictureBoxes[rd].Click += start_level;

            
        }
        private void loading_language()
        {
            if (status.language == Language.Vietnamese)
            {
                lbl_error_title.Text = Vietnamese.dialog3;
                lbl_score_title.Text = Vietnamese.dialog2;
                lbl_score.Text = status.packedScore.ToString();
                lbl_error.Text = status.errorCount.ToString();
                lbl_time.Text = status.timeLeft.ToString();
                lbl_announcement.Text = Vietnamese.dialog1;
                lbl_bat_highscore.Text = Vietnamese.dialog10;
                lbl_mole_highscore.Text = Vietnamese.dialog11;
                lbl_cat_highscore.Text = Vietnamese.dialog13;
                lbl_dog_highscore.Text = Vietnamese.dialog12;
                lbl_eagle_highscore.Text = Vietnamese.dialog15;
                lbl_tiger_highscore.Text = Vietnamese.dialog14;
                lbl_play_area_title.Text = Vietnamese.dialog1;
                lbl_highscore_title.Text = Vietnamese.dialog4;
                lbl_instruction_title.Text = Vietnamese.dialog5;
                lbl_instruction_1.Text = Vietnamese.dialog6;
                lbl_instruction_2.Text = Vietnamese.dialog7;
                lbl_instruction_3.Text = Vietnamese.dialog8;
                lbl_instruction_4.Text = Vietnamese.dialog9;
                lbl_mole_score_range.Text = Vietnamese.dialog17;
                lbl_bat_score_range.Text = Vietnamese.dialog16;
                lbl_dog_score_range.Text = Vietnamese.dialog18;
                lbl_cat_score_range.Text = Vietnamese.dialog19;
                lbl_tiger_score_range.Text = Vietnamese.dialog20;
                lbl_eagle_score_range.Text = Vietnamese.dialog21;

            }
            if (status.language == Language.English)
            {
                lbl_error_title.Text = English.dialog3;
                lbl_score_title.Text = English.dialog2;
                lbl_score.Text = status.packedScore.ToString();
                lbl_error.Text = status.errorCount.ToString();
                lbl_time.Text = status.timeLeft.ToString();
                lbl_announcement.Text = English.dialog1;
                lbl_bat_highscore.Text = English.dialog10;
                lbl_mole_highscore.Text = English.dialog11;
                lbl_cat_highscore.Text = English.dialog13;
                lbl_dog_highscore.Text = English.dialog12;
                lbl_eagle_highscore.Text = English.dialog15;
                lbl_tiger_highscore.Text = English.dialog14;
                lbl_play_area_title.Text = English.dialog1;
                lbl_highscore_title.Text = English.dialog4;
                lbl_instruction_title.Text = English.dialog5;
                lbl_instruction_1.Text = English.dialog6;
                lbl_instruction_2.Text = English.dialog7;
                lbl_instruction_3.Text = English.dialog8;
                lbl_instruction_4.Text = English.dialog9;
                lbl_mole_score_range.Text = English.dialog17;
                lbl_bat_score_range.Text = English.dialog16;
                lbl_dog_score_range.Text = English.dialog18;
                lbl_cat_score_range.Text = English.dialog19;
                lbl_tiger_score_range.Text = English.dialog20;
                lbl_eagle_score_range.Text = English.dialog21;
            }
        }
        private void get_wrong_color(object sender, EventArgs e)
        {
            if (status.level != 2)
            {
                engine.RequestHandler(RequestType.get_wrong_answer);
                status = engine.send_result();
                updateStatus();
            }
            
        }
        private void start_level(object sender, EventArgs e)
        {

            //setup timer
            timer.Dispose();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += onTick;
            timer.Start();

            //send request
            engine.RequestHandler(RequestType.next_level);

            //setup for play area
            playArea.Controls.Clear();
            status = engine.send_result();
            updateStatus();
            setup_progressBar_effect();
            loading_level();
        }
        private void onTick(object sender, EventArgs eventArgs)
        {
            engine.RequestHandler(RequestType.time_tick);
            status = engine.send_result();
            updateStatus();
            
            if (status.timeLeft <= 0 )
            {
                timer.Stop();
                lbl_time.Text = "0";
                engine.RequestHandler(RequestType.game_over);
            }

        }
        
        private void picBox_MultiLang_Click(object sender, EventArgs e)
        {
            engine.RequestHandler(RequestType.change_language);
            status = engine.send_result();
            loading_language();
        }

        
        //support Function
      

        private void updateStatus()
        {
            lbl_score.Text = status.packedScore.ToString();
            lbl_error.Text = status.errorCount.ToString();
            lbl_time.Text = status.timeLeft.ToString();
        }
        private void setup_progressBar_effect()
        {
            int scoreMax = 29;
            decimal pcdDone_score = (decimal)status.packedScore / scoreMax;
            picBox_progressbar_effect.SendToBack();
            picBox_progressbar_effect.Width = Convert.ToInt32(pcdDone_score * panel_progressbar.Width);
            if (status.packedScore > 0)
            {
                picBox_Bat.Image = Properties.Resources.ac_1_2;
            }
            if (status.packedScore > 4)
            {
                picBox_Mole.Image = Properties.Resources.ac_2_2;
            }
            if (status.packedScore > 9)
            {
                picBox_Dog.Image = Properties.Resources.ac_3_2;
            }
            if (status.packedScore > 14)
            {
                picBox_Cat.Image = Properties.Resources.ac_4_2;
            }
            if (status.packedScore > 19)
            {
                picBox_Tiger.Image = Properties.Resources.ac_5_2;
            }
            if (status.packedScore > 24)
            {
                picBox_Eagle.Image = Properties.Resources.ac_6_2;
            }

           
        }
    }
}
