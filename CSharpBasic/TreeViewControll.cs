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
    public partial class TreeViewControll : Form
    {
        public TreeViewControll()
        {
            InitializeComponent();

            // TreView에 사용할 ImageList 정의
            ImageList imageList = new ImageList();
            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\jjh\Desktop\img\icon.ico"));
            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\jjh\Desktop\img\key.png"));
            treeView1.ImageList = imageList;

            // 첫번째 TreeView 아이템 - 서버
            TreeNode svrNode = new TreeNode("서버", 0, 0);
            svrNode.Nodes.Add("SE", "서울 서버", 0, 0);
            svrNode.Nodes.Add("DJ", "대전 서버", 0, 0);
            svrNode.Nodes.Add("BS", "부산 서버", 0, 0);

            // 두번째 TreeView 아이템 - 네트워크
            TreeNode netNode = new TreeNode("네트워크", 1, 1);
            netNode.Nodes.Add("T1", "T1 케이블", 1, 1);
            netNode.Nodes.Add("56K", "56K 모델", 1, 1);
            netNode.Nodes.Add("3G", "3G 무선", 1, 1);

            // 2개의 노드를 TreeView에 추가
            treeView1.Nodes.Add(svrNode);
            treeView1.Nodes.Add(netNode);

            // 모든 트리 노드를 보여준다
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                MessageBox.Show($"선택된 노드 키 : {nodeKey}");
            }
        }
    }
}
