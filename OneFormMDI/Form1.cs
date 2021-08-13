using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneFormMDI
{
    public partial class Form1 : Form
    {
        // 자식 폼 객체로 선언
        private ChildForm1 mChildForm1 = null;
        private ChildForm2 mChildForm2 = null;

        public Form1()
        {
            InitializeComponent();

            // MenuStrip Click 이벤트 선언
            this.폼1ToolStripMenuItem.Click += Form1ToolStrpMenuClick;
            this.폼2ToolStripMenuItem.Click += Form2ToolStrpMenuClick;
            this.창닫기ToolStripMenuItem.Click += ExitToolStrpMenuClick;
        }

        private Form ShowActiveForm(Form form, Type t)
        {
            if(form == null)
            {
                // Activator, 개체의 형식을 로컬 또는 원격으로 만들거나 기존 원격 개체에 대한 참조를 얻는 메서드를 포함
                // Activator.CreateInstance(t), 지정한 매개 변수와 가장 일치하는 생성자를 사용하여 지정한 유형의 인스턴스를 만듭니다.
                form = (Form)Activator.CreateInstance(t);
                // 이 폼의 현재 MDI(다중 문서 인터페이스) 부모 폼을 가져오거나 설정
                form.MdiParent = this;
                // 폼을 최소화하거나 최대화할지, 또는 보통 크기로 할지 여부를 나타내는 값을 가져오거나 설정
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                if(form.IsDisposed) // 컨트롤이 삭제되었는지를 나타내는 값을 가져옵니다
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                }
                else
                {
                    // 폼을 활성화하고 포커스를 제공
                    form.Activate();
                }
            }
            return form;
        }

        public void Form1ToolStrpMenuClick(object sender, EventArgs e)
        {
            // ActiveMdiChild, 현재 활성 상태인 MDI(다중 문서 인터페이스) 자식 창을 가져옵니다.
            if (ActiveMdiChild != null) // 자식폼이 열려있는지 확인
            {
                if(this.ActiveMdiChild != mChildForm1)// 현재 열려있는 자식이 폼1이 아니면
                {
                    ActiveMdiChild.Close(); // 활성화된 다른 자식 창 닫기
                }
                mChildForm1 = ShowActiveForm(mChildForm1, typeof(ChildForm1)) as ChildForm1; // 폼1 자식 인스턴스 생성
            }
            else
            {
                mChildForm1 = ShowActiveForm(mChildForm1, typeof(ChildForm1)) as ChildForm1; // 폼1 자식 인스턴스 생성
            }
        }

        public void Form2ToolStrpMenuClick(object sender, EventArgs e)
        {
            // ActiveMdiChild, 현재 활성 상태인 MDI(다중 문서 인터페이스) 자식 창을 가져옵니다.
            if (ActiveMdiChild != null) // 자식폼이 열려있는지 확인
            {
                if (this.ActiveMdiChild != mChildForm2)// 현재 열려있는 자식이 폼2가 아니면
                {
                    ActiveMdiChild.Close(); // 활성화된 다른 자식 창 닫기
                }
                mChildForm2 = ShowActiveForm(mChildForm2, typeof(ChildForm2)) as ChildForm2; // 폼2 자식 인스턴스 생성
            }
            else
            {
                mChildForm2 = ShowActiveForm(mChildForm2, typeof(ChildForm2)) as ChildForm2; // 폼2 자식 인스턴스 생성
            }
        }

        public void ExitToolStrpMenuClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
