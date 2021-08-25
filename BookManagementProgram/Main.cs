using BookManagementProgram.XtraForm;
using BookManagementProgram.Model;
using  BookManagementProgram.Repository;
using System;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using BookManagementProgram.UserControls;
using BookManagementProgram.BookControls;
using BookManagementProgram.RentalControls;
using DevExpress.XtraBars;

namespace BookManagementProgram
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private User user = BookUserRepository.user;
        private XtraTabbedMdiManager mdiManager;

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            switch (user.authorityNo)
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

        // 홈, 사용자, 도서, 렌탈, 연체자,렌탈기록 조회버튼
        private void MenuItemClickEvent(object sender, ItemClickEventArgs e)
        {
            MenuRun(e.Item.Hint, e.Item.Caption);
        }

        // 비밀번호 변경, 유저 등록, 유저 검색, 도서 추가, 도서 검색, 렌탈등록, 반납등록 버튼
        private void ShowDialog_Event(object sender, ItemClickEventArgs e)
        {
            switch (e.Item.Hint)
            {
                case "FindByPassword":
                    (new FindByPassword()).ShowDialog();
                    break;
                case "UserAddForm":
                    (new UserAddForm()).ShowDialog();
                    break;
                case "UserSearchForm":
                    (new UserSearchForm()).ShowDialog();
                    break;
                case "BookAddForm":
                    (new BookAddForm()).ShowDialog();
                    break;
                case "BookSearchForm":
                    (new BookSearchForm()).ShowDialog();
                    break;
                case "AddRentalForm":
                    (new AddRentalForm()).ShowDialog();
                    break;
                case "ReturnBookForm":
                    (new ReturnBookForm()).ShowDialog(); ;
                    break;
            }
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
        
        // 메인 폼 로드
        private void Main_Load(object sender, EventArgs e)
        {
            ChildFormAdd();

            MenuRun(home_btn.Hint, home_btn.Caption);
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
