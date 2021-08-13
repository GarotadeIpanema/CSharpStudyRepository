using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otherMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AlarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("알람 발생");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            // 마우스 우측 버튼이 눌린 경우에 컨텍스트 메뉴 실행
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();

                MenuItem menuItem = new MenuItem("알람 발생");
                menuItem.Click += AlarmToolStripMenuItem_Click; // 메뉴에서 등록한 알람 이벤트 처리기 등록
                contextMenu.MenuItems.Add(menuItem);

                menuItem = new MenuItem("종료");
                menuItem.Click += ExitToolStripMenuItem_Click; // 메뉴에서 등록한 종료 이벤트 처리기 등록
                contextMenu.MenuItems.Add(menuItem);

                contextMenu.Show(this, e.Location);
            }
        }
    }
}
