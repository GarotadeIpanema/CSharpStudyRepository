using BookManagementProgram.LOGIN;
using BookManagementProgram.Model;
using  BookManagementProgram.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram
{
    public partial class Main : Form
    {
        User user = BookUserRepository.user;

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            switch(user.authorityNo)
            {
                case 0:
                    user_page.Visible = true;
                    book_page.Visible = true;
                    rental_page.Visible = true;
                    break;
                case 1:
                    book_page.Visible = true;
                    rental_page.Visible = true;
                    break;
                case 2:
                    rental_page.Visible = true;
                    break;
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void home_close_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void home_changePassword_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new FindByPassword()).ShowDialog();
        }
    }
}
