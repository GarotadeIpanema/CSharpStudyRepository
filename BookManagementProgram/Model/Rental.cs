using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.Model
{
    class Rental
    {

        private int user_no;
        private string user_name;
        private int book_no;
        private string book_title;
        private string rental_date;
        private string return_date;

        public int userNo { get { return user_no; } set { user_no = value; } }
        public string userName { get { return user_name; } set { user_name = value; } }
        public int bookNo { get { return book_no; } set { book_no = value; } }
        public string bookTitle { get { return book_title; } set { book_title = value; } }
        public string rentalDate { get { return rental_date; } set { rental_date = value; } }
        public string returnDate { get { return return_date; } set { return_date = value; } }

        public Rental(int user_no, string user_name, int book_no, string book_title, string rental_date, string return_date)
        {
            this.user_no = user_no;
            this.user_name = user_name;
            this.book_no = book_no;
            this.book_title = book_title;
            this.rental_date = rental_date;
            this.return_date = return_date;
        }

        // 렌탈 등록할 때 사용되는 생성자
        public Rental(int user_no, int book_no, string book_title)
        {
            this.user_no = user_no;
            this.book_no = book_no;
            this.book_title = book_title;
        }

        public Rental()
        {
        }
    }
}
