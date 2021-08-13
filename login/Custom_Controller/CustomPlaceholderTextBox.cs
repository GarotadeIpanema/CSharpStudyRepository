using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_WMS._0000_공통.Custom_Component
{
    public partial class CustomPlaceholderTextBox : TextBox
    {
        private string _placeholder = "아이디를 입력해주세요.";
        private Color _placeholderColor = Color.DarkGray;
        private Color _writeColor = Color.Black;

        public CustomPlaceholderTextBox()
        {
            InitializeComponent();

            //처음 공백 Placeholder 지정
            this.ForeColor = _placeholderColor;
            this.Text = _placeholder;
            //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
            this.GotFocus += RemovePlaceholder;
            this.LostFocus += SetPlaceholder;
        }

        // 플레이스 홀더 삭제
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == _placeholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = _writeColor; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt.Name.IndexOf("pw", StringComparison.OrdinalIgnoreCase) >= 0 || txt.Name.IndexOf("password", StringComparison.OrdinalIgnoreCase) > 0) this.PasswordChar = '*';
            }
        }

        // 플레이스 홀더 적용
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = _placeholderColor; //Placeholder 흐린 글씨
                txt.Text = _placeholder;
                if (txt.Name.IndexOf("pw", StringComparison.OrdinalIgnoreCase) >= 0 || txt.Name.IndexOf("password", StringComparison.OrdinalIgnoreCase) > 0) { this.PasswordChar = default(char); }
            }
        }

        public string Placeholder
        {
            get { return _placeholder; }
            set
            {
                _placeholder = value;
                this.Text = value;
            }
        }

        public Color PlaceholderColor
        {
            get { return _placeholderColor; }
            set { _placeholderColor = value; }
        }

        public Color WriteColor
        {
            get { return _writeColor; }
            set { _writeColor = value; }
        }
    }
}
