using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popup
{
    public partial class FindById : Form
    {
        public FindById()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void find_by_id_btn_Click(object sender, EventArgs e)
        {
            if (com_code_txt.Text.Trim().Equals(""))
            {
                MessageBox.Show("이름을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                com_code_txt.Focus();
                return;
            }

            if (emp_id.Text.Trim().Equals(""))
            {
                MessageBox.Show("회사코드를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emp_id.Focus();
                return;
            }
        }
    }
}
