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

namespace BookManagementProgram.MainControls
{
    public partial class MainPageForm : Form
    {
        BookRepository bookRepository = null;
        public MainPageForm()
        {
            InitializeComponent();
            bookRepository = new BookRepository();

            DataTable dt = bookRepository.GetRandomBook();
            if(dt != null)
            {
                pictureBox1.Load(dt.Rows[0]["book_saveImagePath"].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                book_no_txt.Text = dt.Rows[0]["book_no"].ToString();
                book_title_txt.Text = dt.Rows[0]["book_title"].ToString();
                book_writer_txt.Text = dt.Rows[0]["book_writer"].ToString();
                book_category_txt.Text = dt.Rows[0]["category_name"].ToString();
                book_description_txt.Text = dt.Rows[0]["book_description"].ToString();
                book_rentalcount_txt.Text = dt.Rows[0]["book_rentalcounts"].ToString();
            }
            
        }
    }
}
