using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class ListViewController : Form
    {
        public ListViewController()
        {
            InitializeComponent();
            Details.Checked = true;

            // 현재 디렉토리 내의 파일리스트 얻기
            string currDir = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(currDir);
            FileInfo[] files = di.GetFiles();

            // 리스트 뷰 아이템을업데이트 하기 시작
            // 업데이트가 끝날 대까지 UI 갱신 중지
            listView1.BeginUpdate();

            // 뷰모드 지정
            listView1.View = View.Details;

            // 아이콘을 위해 이미지 지정
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList2;

            foreach(var fi in files)
            {
                // 각 파일별로 ListViewItem 객체를 하나씩 만듦
                // 파일명, 사이즈, 날짜 정보를 추가
                ListViewItem lvi = new ListViewItem(fi.Name);
                lvi.SubItems.Add(fi.Length.ToString());
                lvi.SubItems.Add(fi.LastWriteTime.ToString());
                lvi.ImageIndex = 0;

                // ListViewItem 객체를 Items 속성에 추가
                listView1.Items.Add(lvi);
            }

            // 컬럼명과 컬럼사이즈 지정
            listView1.Columns.Add("파일명", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("사이즈", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("날짜", 150, HorizontalAlignment.Left);

            // 리스트뷰를 Refresh하여 보여줌
            listView1.EndUpdate();
        }

        // View 모드 지정

        private void Details_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void List_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void Title_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void LargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void SmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
    }
}
