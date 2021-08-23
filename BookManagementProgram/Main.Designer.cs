
namespace BookManagementProgram
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.home_reset_btn = new DevExpress.XtraBars.BarButtonItem();
            this.home_changePassword_btn = new DevExpress.XtraBars.BarButtonItem();
            this.home_close_btn = new DevExpress.XtraBars.BarButtonItem();
            this.user_reset_btn = new DevExpress.XtraBars.BarButtonItem();
            this.user_add_btn = new DevExpress.XtraBars.BarButtonItem();
            this.user_update_btn = new DevExpress.XtraBars.BarButtonItem();
            this.user_delete_btn = new DevExpress.XtraBars.BarButtonItem();
            this.user_search_btn = new DevExpress.XtraBars.BarButtonItem();
            this.book_reset_btn = new DevExpress.XtraBars.BarButtonItem();
            this.book_add_btn = new DevExpress.XtraBars.BarButtonItem();
            this.book_update_btn = new DevExpress.XtraBars.BarButtonItem();
            this.book_delete_btn = new DevExpress.XtraBars.BarButtonItem();
            this.book_search_btn = new DevExpress.XtraBars.BarButtonItem();
            this.rental_reset_btn = new DevExpress.XtraBars.BarButtonItem();
            this.overdue_reset_btn = new DevExpress.XtraBars.BarButtonItem();
            this.rental_add_btn = new DevExpress.XtraBars.BarButtonItem();
            this.rental_return_btn = new DevExpress.XtraBars.BarButtonItem();
            this.rental_log_btn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.home_chagePassword_btn = new DevExpress.XtraBars.BarButtonItem();
            this.home_page = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.home_main_group = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.home_other_group = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.user_page = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.user_main_group = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.book_page = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.book_main_group = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rental_page = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rental_main_group = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.home_reset_btn,
            this.home_changePassword_btn,
            this.home_close_btn,
            this.user_reset_btn,
            this.user_add_btn,
            this.user_update_btn,
            this.user_delete_btn,
            this.user_search_btn,
            this.book_reset_btn,
            this.book_add_btn,
            this.book_update_btn,
            this.book_delete_btn,
            this.book_search_btn,
            this.rental_reset_btn,
            this.overdue_reset_btn,
            this.rental_add_btn,
            this.rental_return_btn,
            this.rental_log_btn,
            this.barButtonItem1,
            this.home_chagePassword_btn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.home_page,
            this.user_page,
            this.book_page,
            this.rental_page});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(880, 152);
            // 
            // home_reset_btn
            // 
            this.home_reset_btn.Caption = "조회";
            this.home_reset_btn.Id = 1;
            this.home_reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("home_reset_btn.ImageOptions.Image")));
            this.home_reset_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("home_reset_btn.ImageOptions.LargeImage")));
            this.home_reset_btn.LargeWidth = 60;
            this.home_reset_btn.Name = "home_reset_btn";
            // 
            // home_changePassword_btn
            // 
            this.home_changePassword_btn.Caption = "비밀번호 변경";
            this.home_changePassword_btn.Id = 2;
            this.home_changePassword_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("home_changePassword_btn.ImageOptions.Image")));
            this.home_changePassword_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("home_changePassword_btn.ImageOptions.LargeImage")));
            this.home_changePassword_btn.LargeWidth = 60;
            this.home_changePassword_btn.Name = "home_changePassword_btn";
            this.home_changePassword_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.home_changePassword_btn_ItemClick);
            // 
            // home_close_btn
            // 
            this.home_close_btn.Caption = "종료";
            this.home_close_btn.Id = 3;
            this.home_close_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("home_close_btn.ImageOptions.Image")));
            this.home_close_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("home_close_btn.ImageOptions.LargeImage")));
            this.home_close_btn.LargeWidth = 60;
            this.home_close_btn.Name = "home_close_btn";
            this.home_close_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.home_close_btn_ItemClick);
            // 
            // user_reset_btn
            // 
            this.user_reset_btn.Caption = "회원조회";
            this.user_reset_btn.Hint = "사용자조회";
            this.user_reset_btn.Id = 4;
            this.user_reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_reset_btn.ImageOptions.Image")));
            this.user_reset_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("user_reset_btn.ImageOptions.LargeImage")));
            this.user_reset_btn.LargeWidth = 60;
            this.user_reset_btn.Name = "user_reset_btn";
            this.user_reset_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.user_reset_btn_ItemClick);
            // 
            // user_add_btn
            // 
            this.user_add_btn.Caption = "회원등록";
            this.user_add_btn.Id = 5;
            this.user_add_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_add_btn.ImageOptions.Image")));
            this.user_add_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("user_add_btn.ImageOptions.LargeImage")));
            this.user_add_btn.LargeWidth = 60;
            this.user_add_btn.Name = "user_add_btn";
            this.user_add_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.user_add_btn_ItemClick);
            // 
            // user_update_btn
            // 
            this.user_update_btn.Caption = "회원수정";
            this.user_update_btn.Id = 6;
            this.user_update_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_update_btn.ImageOptions.Image")));
            this.user_update_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("user_update_btn.ImageOptions.LargeImage")));
            this.user_update_btn.LargeWidth = 60;
            this.user_update_btn.Name = "user_update_btn";
            // 
            // user_delete_btn
            // 
            this.user_delete_btn.Caption = "회원삭제";
            this.user_delete_btn.Id = 7;
            this.user_delete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_delete_btn.ImageOptions.Image")));
            this.user_delete_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("user_delete_btn.ImageOptions.LargeImage")));
            this.user_delete_btn.LargeWidth = 60;
            this.user_delete_btn.Name = "user_delete_btn";
            // 
            // user_search_btn
            // 
            this.user_search_btn.Caption = "회원검색 (수정,삭제)";
            this.user_search_btn.Id = 8;
            this.user_search_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_search_btn.ImageOptions.Image")));
            this.user_search_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("user_search_btn.ImageOptions.LargeImage")));
            this.user_search_btn.LargeWidth = 60;
            this.user_search_btn.Name = "user_search_btn";
            this.user_search_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.user_search_btn_ItemClick);
            // 
            // book_reset_btn
            // 
            this.book_reset_btn.Caption = "도서 조회";
            this.book_reset_btn.Hint = "도서 조회";
            this.book_reset_btn.Id = 9;
            this.book_reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("book_reset_btn.ImageOptions.Image")));
            this.book_reset_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("book_reset_btn.ImageOptions.LargeImage")));
            this.book_reset_btn.LargeWidth = 60;
            this.book_reset_btn.Name = "book_reset_btn";
            this.book_reset_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.book_reset_btn_ItemClick);
            // 
            // book_add_btn
            // 
            this.book_add_btn.Caption = "도서 등록";
            this.book_add_btn.Id = 10;
            this.book_add_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("book_add_btn.ImageOptions.Image")));
            this.book_add_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("book_add_btn.ImageOptions.LargeImage")));
            this.book_add_btn.LargeWidth = 60;
            this.book_add_btn.Name = "book_add_btn";
            this.book_add_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.book_add_btn_ItemClick);
            // 
            // book_update_btn
            // 
            this.book_update_btn.Caption = "도서 수정";
            this.book_update_btn.Id = 11;
            this.book_update_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("book_update_btn.ImageOptions.Image")));
            this.book_update_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("book_update_btn.ImageOptions.LargeImage")));
            this.book_update_btn.LargeWidth = 60;
            this.book_update_btn.Name = "book_update_btn";
            // 
            // book_delete_btn
            // 
            this.book_delete_btn.Caption = "도서 삭제";
            this.book_delete_btn.Id = 12;
            this.book_delete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("book_delete_btn.ImageOptions.Image")));
            this.book_delete_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("book_delete_btn.ImageOptions.LargeImage")));
            this.book_delete_btn.LargeWidth = 60;
            this.book_delete_btn.Name = "book_delete_btn";
            // 
            // book_search_btn
            // 
            this.book_search_btn.Caption = "도서 조회 (수정,삭제)";
            this.book_search_btn.Id = 13;
            this.book_search_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("book_search_btn.ImageOptions.Image")));
            this.book_search_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("book_search_btn.ImageOptions.LargeImage")));
            this.book_search_btn.LargeWidth = 60;
            this.book_search_btn.Name = "book_search_btn";
            this.book_search_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.book_search_btn_ItemClick);
            // 
            // rental_reset_btn
            // 
            this.rental_reset_btn.Caption = "렌탈 조회";
            this.rental_reset_btn.Id = 14;
            this.rental_reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rental_reset_btn.ImageOptions.Image")));
            this.rental_reset_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rental_reset_btn.ImageOptions.LargeImage")));
            this.rental_reset_btn.LargeWidth = 60;
            this.rental_reset_btn.Name = "rental_reset_btn";
            // 
            // overdue_reset_btn
            // 
            this.overdue_reset_btn.Caption = "연체자 조회";
            this.overdue_reset_btn.Id = 15;
            this.overdue_reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("overdue_reset_btn.ImageOptions.Image")));
            this.overdue_reset_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("overdue_reset_btn.ImageOptions.LargeImage")));
            this.overdue_reset_btn.LargeWidth = 60;
            this.overdue_reset_btn.Name = "overdue_reset_btn";
            // 
            // rental_add_btn
            // 
            this.rental_add_btn.Caption = "렌탈등록";
            this.rental_add_btn.Id = 16;
            this.rental_add_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rental_add_btn.ImageOptions.Image")));
            this.rental_add_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rental_add_btn.ImageOptions.LargeImage")));
            this.rental_add_btn.LargeWidth = 60;
            this.rental_add_btn.Name = "rental_add_btn";
            // 
            // rental_return_btn
            // 
            this.rental_return_btn.Caption = "반납확인";
            this.rental_return_btn.Id = 17;
            this.rental_return_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rental_return_btn.ImageOptions.Image")));
            this.rental_return_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rental_return_btn.ImageOptions.LargeImage")));
            this.rental_return_btn.LargeWidth = 60;
            this.rental_return_btn.Name = "rental_return_btn";
            // 
            // rental_log_btn
            // 
            this.rental_log_btn.Caption = "기록조회";
            this.rental_log_btn.Id = 18;
            this.rental_log_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rental_log_btn.ImageOptions.LargeImage")));
            this.rental_log_btn.LargeWidth = 60;
            this.rental_log_btn.Name = "rental_log_btn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // home_chagePassword_btn
            // 
            this.home_chagePassword_btn.Caption = "비밀번호 변경";
            this.home_chagePassword_btn.Id = 20;
            this.home_chagePassword_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("home_chagePassword_btn.ImageOptions.Image")));
            this.home_chagePassword_btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("home_chagePassword_btn.ImageOptions.LargeImage")));
            this.home_chagePassword_btn.LargeWidth = 60;
            this.home_chagePassword_btn.Name = "home_chagePassword_btn";
            this.home_chagePassword_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.home_changePassword_btn_ItemClick);
            // 
            // home_page
            // 
            this.home_page.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.home_main_group,
            this.home_other_group});
            this.home_page.Name = "home_page";
            this.home_page.Text = "홈";
            // 
            // home_main_group
            // 
            this.home_main_group.ItemLinks.Add(this.home_reset_btn);
            this.home_main_group.Name = "home_main_group";
            this.home_main_group.Text = "메인";
            // 
            // home_other_group
            // 
            this.home_other_group.ItemLinks.Add(this.home_chagePassword_btn);
            this.home_other_group.ItemLinks.Add(this.home_close_btn);
            this.home_other_group.Name = "home_other_group";
            this.home_other_group.Text = "기타";
            // 
            // user_page
            // 
            this.user_page.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.user_main_group});
            this.user_page.Name = "user_page";
            this.user_page.Text = "회원 관리";
            this.user_page.Visible = false;
            // 
            // user_main_group
            // 
            this.user_main_group.ItemLinks.Add(this.user_reset_btn);
            this.user_main_group.ItemLinks.Add(this.user_add_btn);
            this.user_main_group.ItemLinks.Add(this.user_search_btn);
            this.user_main_group.Name = "user_main_group";
            this.user_main_group.Text = "메인";
            // 
            // book_page
            // 
            this.book_page.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.book_main_group});
            this.book_page.Name = "book_page";
            this.book_page.Text = "도서 관리";
            this.book_page.Visible = false;
            // 
            // book_main_group
            // 
            this.book_main_group.ItemLinks.Add(this.book_reset_btn);
            this.book_main_group.ItemLinks.Add(this.book_add_btn);
            this.book_main_group.ItemLinks.Add(this.book_search_btn);
            this.book_main_group.Name = "book_main_group";
            this.book_main_group.Text = "메인";
            // 
            // rental_page
            // 
            this.rental_page.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rental_main_group});
            this.rental_page.Name = "rental_page";
            this.rental_page.Text = "렌탈 & 반납";
            this.rental_page.Visible = false;
            // 
            // rental_main_group
            // 
            this.rental_main_group.ItemLinks.Add(this.rental_reset_btn);
            this.rental_main_group.ItemLinks.Add(this.overdue_reset_btn);
            this.rental_main_group.ItemLinks.Add(this.rental_add_btn);
            this.rental_main_group.ItemLinks.Add(this.rental_return_btn);
            this.rental_main_group.ItemLinks.Add(this.rental_log_btn);
            this.rental_main_group.Name = "rental_main_group";
            this.rental_main_group.Text = "메인";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 671);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage home_page;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup home_main_group;
        private DevExpress.XtraBars.Ribbon.RibbonPage user_page;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup user_main_group;
        private DevExpress.XtraBars.BarButtonItem home_reset_btn;
        private DevExpress.XtraBars.BarButtonItem home_changePassword_btn;
        private DevExpress.XtraBars.BarButtonItem home_close_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup home_other_group;
        private DevExpress.XtraBars.BarButtonItem user_reset_btn;
        private DevExpress.XtraBars.BarButtonItem user_add_btn;
        private DevExpress.XtraBars.BarButtonItem user_update_btn;
        private DevExpress.XtraBars.BarButtonItem user_delete_btn;
        private DevExpress.XtraBars.BarButtonItem user_search_btn;
        private DevExpress.XtraBars.BarButtonItem book_reset_btn;
        private DevExpress.XtraBars.BarButtonItem book_add_btn;
        private DevExpress.XtraBars.BarButtonItem book_update_btn;
        private DevExpress.XtraBars.BarButtonItem book_delete_btn;
        private DevExpress.XtraBars.BarButtonItem book_search_btn;
        private DevExpress.XtraBars.BarButtonItem rental_reset_btn;
        private DevExpress.XtraBars.BarButtonItem overdue_reset_btn;
        private DevExpress.XtraBars.BarButtonItem rental_add_btn;
        private DevExpress.XtraBars.BarButtonItem rental_return_btn;
        private DevExpress.XtraBars.BarButtonItem rental_log_btn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage book_page;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup book_main_group;
        private DevExpress.XtraBars.Ribbon.RibbonPage rental_page;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rental_main_group;
        private DevExpress.XtraBars.BarButtonItem home_chagePassword_btn;
    }
}