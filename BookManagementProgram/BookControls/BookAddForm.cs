using BookManagementProgram.Model;
using BookManagementProgram.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram.BookControls
{
    public partial class BookAddForm : Form
    {
        BookRepository bookRepository = null;
        public BookAddForm()
        {
            InitializeComponent();

            bookRepository = new BookRepository();
            this.StartPosition = FormStartPosition.CenterParent;

            // 카테고리 콤보 박스
            book_category_cmb.DataSource = new BindingSource(bookRepository.GetCategoryList(), null);
            book_category_cmb.DisplayMember = "Key";
            book_category_cmb.ValueMember = "Value";
            // 위치 콤보 박스
            book_location_cmb.DataSource = new BindingSource(bookRepository.GetBookLocationList(), null);
            book_location_cmb.DisplayMember = "Key";
            book_location_cmb.ValueMember = "Value";
        }

        // 취소 버튼
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 도서 등록
        private void add_book_btn_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                Book book = CreateBookInstance();
                if (bookRepository.AddBook(book))
                {
                    MessageBox.Show("도서 등록에 성공하셨습니다.");
                    this.Close();
                    return;
                }
                MessageBox.Show("도서 등록에 실패하셨습니다.");
            }
        }


        // Book 객체 생성
        private Book CreateBookInstance()
        {
            Book book = new Book();
            book.bookTitle = book_title_txt.Text;
            book.bookWriter = book_writer_txt.Text;
            book.bookCategory_no = (int)book_category_cmb.SelectedValue;
            book.bookDescription = book_description_txt.Text;
            book.bookPrice = Convert.ToInt32(book_price_txt.Text);
            book.bookCompany = book_company_txt.Text;
            book.bookDate = book_date_txt.Text;
            book.bookPages = Convert.ToInt32(book_pages_txt.Text);
            book.bookOriginalImagePath = book_image_txt.Text;
            book.bookSavenameImaegPath = SaveBookImageFIle();
            book.bookLocationNo = (int)book_location_cmb.SelectedValue;
            book.bookRentalNo = 1;

            return book;
        }

        // 텍스트박스 입력 확인
        private bool CheckInput()
        {
            bool check = false;

            if (string.IsNullOrEmpty(book_title_txt.Text))
            {
                MessageBox.Show("책 제목을 입력해주세요.");
                book_title_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_writer_txt.Text))
            {
                MessageBox.Show("책 저자를 입력해주세요.");
                book_writer_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_description_txt.Text))
            {
                MessageBox.Show("도서 설명을 입력해주세요.");
                book_description_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_price_txt.Text) || CheckNumeric(book_price_txt.Text))
            {
                MessageBox.Show("가격을 입력해주세요.");
                book_price_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_company_txt.Text))
            {
                MessageBox.Show("출판사를 입력해주세요.");
                book_company_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_date_txt.Text) || CheckDatePattern(book_date_txt.Text))
            {
                MessageBox.Show("출판날짜를 입력해주세요.(2021.01.01)");
                book_date_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_pages_txt.Text) || CheckNumeric(book_pages_txt.Text))
            {
                MessageBox.Show("총 페이지 수를 입력해주세요.");
                book_pages_txt.Focus();
            }
            else if (string.IsNullOrEmpty(book_image_txt.Text))
            {
                MessageBox.Show("이미지를 선택해주세요.");
                book_image_btn.Focus();
            }
            else
            {
                check = true;
            }

            return check;
        }


        // 출판일 확인 정규식
        private bool CheckDatePattern(string date)
        {
            string pattern = @"^(1[0-9][0-9][0-9]|20\d{2})\.(0[0-9]|1[0-2])\.(0[1-9]|[1-2][0-9]|3[0-1])$";
            if (!Regex.IsMatch(date, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 숫자인지 확인
        private bool CheckNumeric(string value)
        {
            int result = -1;
            if(Int32.TryParse(value, out result))
            {
                if(result > 0)
                {
                    return false;
                }
            }
            return true;
        }

        // 책 이미지 불러오기 버튼
        private void book_image_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "이미지 불러오기";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            book_image_txt.Text = string.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                book_image_txt.Text = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // 이미지 파일 저장
        private string SaveBookImageFIle()
        {
            string dir = @"C:\Users\jjh\Desktop\mms\BookManagerForm\BookImages";
            Image image = Image.FromFile(book_image_txt.Text);
            bool bExist = true;
            int fileCount = 0;
            string fileName = string.Empty;
            string dirMapPath = string.Empty;

            if (image != null)
            {
                fileName = book_image_txt.Text.Split('\\').Last();
                string strName = fileName.Substring(0, fileName.LastIndexOf("."));
                string strExt = fileName.Substring(fileName.LastIndexOf("."));
                while (bExist)
                {
                    dirMapPath = dir;
                    string pathCombine = System.IO.Path.Combine(dirMapPath, fileName);
                    if (System.IO.File.Exists(pathCombine))
                    {
                        fileCount++;
                        fileName = $"{strName}({fileCount}){strExt}";
                    }
                    else
                    {
                        bExist = false;
                    }
                }
                image.Save($@"{dir}\{fileName}");
                MessageBox.Show("이미지 저장이 되었습니다");
            }
            return $@"{dir}\{fileName}";
        }
    }
}
