using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class ListViewDragAndDrop : Form
    {
        public ListViewDragAndDrop()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.Items.Add("abc");
            listView1.Items.Add("aaa");
            listView1.Items.Add("bbb");
        }
        // ListView, TreeView 등의 일부 컨트롤은 ItemDrag라는 특변한 커스텀 이벤트를 가지고 있다
        // 이 이벤트의 핸들러에서 DoDragDrop()메서드를 호출하여 드래고앤드롭을 시작한다
        // 타겟 컨트롤의 DragDrop 이벤트 핸들러에서는 e.Data.GetData(typeof(ListViewItem))와 같이하여 ListViewItem을 얻어낼 수 있다

        // Drop Source : ItemDrag 이벤트 핸들러에서 DoDragDrop 호출
        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        // Drag Target : DragEnter 핸들러에서 해당 소스가 ListViewItem인지 체크
        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Drop Target : DragDrop 핸들러에서 복사 실행
        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                // 드래그된 소스 ListViewItem
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;

                // ListViewItem를 Clone하여 추가
                // 하나의 ListViewItem은 복수개의 ListVIew에 동시에 추가될 수 없으므로, ListViewItem을 CLone해서 추가한것
                //listView2.Items.Add(item);
                listView2.Items.Add(item.Clone() as ListViewItem);
                
            }
        }
    }
}
