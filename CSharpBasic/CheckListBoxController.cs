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
    public partial class CheckListBoxController : Form
    {
        public CheckListBoxController()
        {
            InitializeComponent();

            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("한국");
            checkedListBox1.Items.Add("미국");
            checkedListBox1.Items.Add("영국");
            checkedListBox1.Items.Add("중국");
            checkedListBox1.Items.Add("일본");
            checkedListBox1.Items.Add("베트남");
            checkedListBox1.Items.Add("터키");
            checkedListBox1.Items.Add("싱가포르");
            checkedListBox1.Items.Add("캐나다");
            checkedListBox1.Items.Add("호주");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // https://docs.microsoft.com/ko-kr/dotnet/csharp/how-to/concatenate-multiple-strings (문자열 연결)

            List<object> items = checkedListBox1.CheckedItems.OfType<object>().ToList();
            // var str = items.Aggregate((partialPhrase, word) => $"{partialPhrase} {word}");
            // var str = string.Concat(items);
            var str = string.Join(" ", items);
            
            MessageBox.Show(str.ToString());
        }
    }
}
