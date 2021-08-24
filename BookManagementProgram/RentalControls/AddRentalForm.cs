using BookManagementProgram.Model;
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
    public partial class AddRentalForm : Form
    {
        DataTable dt = null;
        BookRentalRepository rentalRepository = new BookRentalRepository();

        public AddRentalForm()
        {
            InitializeComponent();

            rental_date_txt.Text = DateTime.Now.ToString("yyyy.MM.dd");
            return_date_txt.Text = DateTime.Now.AddDays(7).ToString("yyyy.MM.dd");
        }

        // 도서 조회버튼
        private void book_select_btn_Click(object sender, EventArgs e)
        {
            if(dt != null) dt = null;
            dt = rentalRepository.GetBookInfo(book_no_txt.Text);
            if(dt == null)
            {
                MessageBox.Show("없는 도서이거나 이미 렌탈된 도서 입니다");
                book_no_txt.Focus();
                return;
            }
            book_no_txt.ReadOnly = true;
            book_title_txt.Text = dt.Rows[0]["book_title"].ToString();
            book_writer_txt.Text = dt.Rows[0]["book_writer"].ToString();
            book_description_txt.Text = dt.Rows[0]["book_description"].ToString();
            pictureBox1.Load(dt.Rows[0]["book_saveImagePath"].ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            rental_bookno_txt.Text = book_no_txt.Text;

        }
        // 사용자 조회
        private void user_select_btn_Click(object sender, EventArgs e)
        {
            if (dt != null) dt = null;
            dt = rentalRepository.GetUserInfo(user_no_txt.Text);
            if (dt == null)
            {
                MessageBox.Show("번호를 확인해주세요.");
                user_no_txt.Focus();
                return;
            }
            user_no_txt.ReadOnly = true;
            user_name_txt.Text = dt.Rows[0]["user_name"].ToString();
            user_id_txt.Text = dt.Rows[0]["user_id"].ToString();
            user_grade_txt.Text = dt.Rows[0]["grade_name"].ToString();
            user_registerdate_txt.Text = dt.Rows[0]["register_date"].ToString();
            user_address_txt.Text = dt.Rows[0]["user_address"].ToString();

            rental_userno_txt.Text = user_no_txt.Text;
        }
        // 취소 버튼
        private void cancle_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 렌탈 등록 버튼
        private void rental_btn_Click(object sender, EventArgs e)
        {
            if(rentalRepository.AddBook(new Rental(
                Convert.ToInt32(rental_userno_txt.Text)
                , Convert.ToInt32(rental_bookno_txt.Text)
                , book_title_txt.Text
                )))
            {
                MessageBox.Show("정상적으로 등록되었습니다.");
                this.Close();
                return;
            }

            MessageBox.Show("등록에 실패하였습니다.");
        }
    }
}
