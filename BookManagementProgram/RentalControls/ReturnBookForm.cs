using BookManagementProgram.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram.RentalControls
{
    public partial class ReturnBookForm : Form
    {
        BookRentalRepository rentalRepository = null;

        public ReturnBookForm()
        {
            InitializeComponent();
            rentalRepository = new BookRentalRepository();
        }

        // 취소 버튼
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        // 반납 버튼
        private void return_btn_Click(object sender, EventArgs e)
        {
            if (rentalRepository.ReturnBook(
                    user_no_txt.Text
                    , book_no_txt.Text
                ))
            {
                MessageBox.Show("정상적으로 반납되었습니다.");
                this.Close();
                return;
            }
            MessageBox.Show("반납에 실패하였습니다");
        }

        // 조회 버튼
        private void select_rental_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = rentalRepository.CheckRentalBook(book_no_txt.Text);
            if(dt == null)
            {
                MessageBox.Show("도서 번호를 확인해주세요.");
                book_no_txt.Focus();
                return;
            }

            book_no_txt.ReadOnly = true;
            user_no_txt.Text = dt.Rows[0]["user_no"].ToString();
            user_name_txt.Text = dt.Rows[0]["user_name"].ToString();
            book_name_txt.Text = dt.Rows[0]["book_title"].ToString();
            rental_date_txt.Text = dt.Rows[0]["rental_date"].ToString();
            today_txt.Text = DateTime.Now.ToString("yyyy.MM.dd");
        }
    }
}
