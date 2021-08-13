using popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          

            // this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Gradient);
        }

        // 그라데이션
        // image_pn 그라디언트 효과 메소드
        private void Panel_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = System.Drawing.ColorTranslator.FromHtml("#e0c3fc");
            Color middleColor = System.Drawing.ColorTranslator.FromHtml("#8ec5fc");
            Color endColor = Color.FromArgb(0, 0, 0);

            LinearGradientBrush linearGradientBrush 
                = new LinearGradientBrush(this.ClientRectangle, System.Drawing.Color.Black, System.Drawing.Color.Black, 0, false);

            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Positions = new[] { 0, 1 / 2f, 1 };
            colorBlend.Colors = new[] { startColor, middleColor, endColor };

            linearGradientBrush.InterpolationColors = colorBlend;
            linearGradientBrush.RotateTransform(45);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);

        }

        // 비밀번호 보이기
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (password_visible_chk.Checked)
                pw_custom_txt.PasswordChar = default(char);
            else
                pw_custom_txt.PasswordChar = '*';
        }

        private void id_custom_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (id_custom_txt.Text.Length >= 20)
            {
                MessageBox.Show("20자 까지만 작성 가능합니다.");
            }
        }

        private void id_custom_txt_TextChanged(object sender, EventArgs e)
        {
            if (id_custom_txt.Text.Length > 19) MessageBox.Show("20자 까지 작성 가능합니다.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LoginIDSetting)
            {
                id_custom_txt.Text = Properties.Settings.Default.LoginIDSave;
                id_save_chk.Checked = true;
            }
                
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (id_save_chk.Checked) SaveID();
            else NotSaveID();

            Application.Exit();
        }

        private static void NotSaveID()
        {
            Properties.Settings.Default.LoginIDSetting = false;
            Properties.Settings.Default.Save();
        }

        private void SaveID()
        {
            Properties.Settings.Default.LoginIDSave = id_custom_txt.Text;
            Properties.Settings.Default.LoginIDSetting = true;
            Properties.Settings.Default.Save();
        }

        private void customRoundButton1_Click(object sender, EventArgs e)
        {
            if (id_save_chk.Checked) SaveID();
            else NotSaveID();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            (new FindById()).ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            (new FindByPWMS()).ShowDialog();
        }
    }
}
