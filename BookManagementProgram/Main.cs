using BookManagementProgram.XtraForm;
using BookManagementProgram.Model;
using  BookManagementProgram.Repository;
using System;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using System.Reflection;
using BookManagementProgram.UserControls;
using BookManagementProgram.BookControls;
using BookManagementProgram.RentalControls;

namespace BookManagementProgram
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        User user = BookUserRepository.user;
        XtraTabbedMdiManager mdiManager;

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
        // 유저 페이지 유저 조회 버튼
        private void user_reset_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuRun("UserSelectForm", user_reset_btn.Hint);
        }

        // 폼 종료
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // 폼 종료 버튼
        private void home_close_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        // 비밀번호 변경 버튼
        private void home_changePassword_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new FindByPassword()).ShowDialog();
        }

        // 유저 페이지 유저 등록 버튼
        private void user_add_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new UserAddForm()).ShowDialog();
        }

        // 유저 페이지 유저 검색 버튼
        private void user_search_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new UserSearchForm()).ShowDialog();
        }

        // 도서 페이지 유저 조회 버튼
        private void book_reset_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuRun("BookSelectForm", book_reset_btn.Hint);
        }

        // 도서 추가 버튼
        private void book_add_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new BookAddForm()).ShowDialog();
        }

        // 도서 조회 버튼
        private void book_search_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new BookSearchForm()).ShowDialog();
        }
        // 렌탈 조회 버튼
        private void rental_reset_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuRun("SelectRentalForm", rental_reset_btn.Hint);
        }

        // 연체자 조회 버튼
        private void overdue_reset_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuRun("SelectDelinquentForm", rental_return_btn.Hint);
        }
        // 렌탈 등록버튼
        private void rental_add_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new AddRentalForm()).ShowDialog();
        }
        // 반납 확인 버튼
        private void rental_return_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new ReturnBookForm()).ShowDialog();
        }
        // 렌탈 히스토리 폼
        private void rental_log_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuRun("SelectRentalHistory", rental_log_btn.Hint);
        }
        // 홈버튼
        private void home_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuRun("MainPageForm", home_btn.Hint);
        }

        // 메인 폼 로드
        private void Main_Load(object sender, EventArgs e)
        {
            ChildFormAdd();

            MenuRun("MainPageForm", home_btn.Hint);
        }

        // MID Child Form추가
        private void ChildFormAdd()
        {
            mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;
            mdiManager.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            mdiManager.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            mdiManager.PageAdded += MdiManager_ChildFormAdd;
            mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
        }


        // MDI 설정
        private void MdiManager_ChildFormAdd(object sender, MdiTabPageEventArgs e)
        {
            XtraMdiTabPage page = e.Page;
        }

        // 첫 로드할때 보여줄 메인 페이지
        private void Home()
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "HOME")  //Notice
                {
                    item.Close();
                }
            }

            Assembly asm = Assembly.GetExecutingAssembly();

            Form frm = (Form)asm.CreateInstance(string.Format("{0}.{1}", "BookManagementProgram.MainControls", "MainPageForm"));

            if (frm != null)
            {
                frm.Text = "메인화면";
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
        }


        // 메뉴 아이템에 따라 MID Child 생성
        private void MenuRun(string Menu, string FormTitle)
        {
            string nameSpace;

            foreach (Form item in this.MdiChildren)
            {
                if (Menu == item.Name)
                {
                    item.Close();
                }
            }

            Form frm = null;
            if (Menu.Equals("UserSelectForm"))
            {
                nameSpace = "BookManagementProgram.UserControls";
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("BookManagementProgram");
                frm = (Form)assembly.CreateInstance(string.Format("{0}.{1}", nameSpace, Menu));
            }
            else if(Menu.Equals("BookSelectForm"))
            {
                nameSpace = "BookManagementProgram.BookControls";
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("BookManagementProgram");
                frm = (Form)assembly.CreateInstance(string.Format("{0}.{1}", nameSpace, Menu));
            }
            else if (Menu.Equals("SelectRentalForm"))
            {
                nameSpace = "BookManagementProgram.RentalControls";
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("BookManagementProgram");
                frm = (Form)assembly.CreateInstance(string.Format("{0}.{1}", nameSpace, Menu));
            }
            else if (Menu.Equals("SelectDelinquentForm"))
            {
                nameSpace = "BookManagementProgram.RentalControls";
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("BookManagementProgram");
                frm = (Form)assembly.CreateInstance(string.Format("{0}.{1}", nameSpace, Menu));
            }
            else if (Menu.Equals("SelectRentalHistory"))
            {
                nameSpace = "BookManagementProgram.RentalControls";
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("BookManagementProgram");
                frm = (Form)assembly.CreateInstance(string.Format("{0}.{1}", nameSpace, Menu));
            }
            else if (Menu.Equals("MainPageForm"))
            {
                nameSpace = "BookManagementProgram.MainControls";
                System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("BookManagementProgram");
                frm = (Form)assembly.CreateInstance(string.Format("{0}.{1}", nameSpace, Menu));
            }

            if (frm != null)
            {
                frm.Text = FormTitle;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("개발중이거나 존재하지 않는 화면입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
    }
}
