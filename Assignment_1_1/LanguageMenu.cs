using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Assignment_1_1
{
    class LanguageMenu : Form
    {
        private PictureBox picBox_Vietnamese;
        private PictureBox picBox_English;
        private Language language;
        public LanguageMenu()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.picBox_English = new System.Windows.Forms.PictureBox();
            this.picBox_Vietnamese = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_English)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Vietnamese)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_English
            // 
            this.picBox_English.Image = global::Assignment_1_1.Properties.Resources.uk;
            this.picBox_English.Location = new System.Drawing.Point(12, 12);
            this.picBox_English.Name = "picBox_English";
            this.picBox_English.Size = new System.Drawing.Size(122, 63);
            this.picBox_English.TabIndex = 0;
            this.picBox_English.TabStop = false;
            this.picBox_English.Click += new System.EventHandler(this.picBox_English_Click);
            // 
            // picBox_Vietnamese
            // 
            this.picBox_Vietnamese.Image = global::Assignment_1_1.Properties.Resources.vietnam;
            this.picBox_Vietnamese.Location = new System.Drawing.Point(12, 99);
            this.picBox_Vietnamese.Name = "picBox_Vietnamese";
            this.picBox_Vietnamese.Size = new System.Drawing.Size(122, 63);
            this.picBox_Vietnamese.TabIndex = 1;
            this.picBox_Vietnamese.TabStop = false;
            this.picBox_Vietnamese.Click += new System.EventHandler(this.picBox_Vietnamese_Click);
            // 
            // LanguageMenu
            // 
            this.ClientSize = new System.Drawing.Size(312, 289);
            this.Controls.Add(this.picBox_Vietnamese);
            this.Controls.Add(this.picBox_English);
            this.Name = "LanguageMenu";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_English)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Vietnamese)).EndInit();
            this.ResumeLayout(false);

        }

        private void picBox_English_Click(object sender, EventArgs e)
        {
            language = Language.English;
            this.Close();
        }
        public Language send_back_answer()
        {
            return language;
        }

        private void picBox_Vietnamese_Click(object sender, EventArgs e)
        {
            language = Language.Vietnamese;
            this.Close();
        }
    }
}
