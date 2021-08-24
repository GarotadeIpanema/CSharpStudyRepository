namespace BookManagementProgram.Model
{
    class Book
    {
        private int book_no; // 책 번호
        private string book_title; // 책 제목
        private string book_writer;  // 저자
        private int book_category_no;  // 카테고리
        private string book_category_name;  // 카테고리
        private string book_description;  // 설명
        private int book_price;  // 가격
        private string book_company;  // 출판사
        private string book_date;  // 출판일
        private int book_pages; // 총 페이지 수
        private string book_originalImagePath; // 파일 원래 이름
        private string book_savenameImaegPath;  // 파일 저장 이름
        private int book_rentalcounts;  // 책 렌탈한 수
        private int book_location_no; // 책 위치
        private string book_location_name; // 책 위치
        private int book_rental_no;  // 책 렌탈 상태
        private string book_rental_name;  // 책 렌탈 상태

        public int bookNo { get { return book_no; } set { book_no = value; } }
        public string bookTitle { get { return book_title; } set { book_title = value; } }
        public string bookWriter { get { return book_writer; } set { book_writer = value; } }
        public int bookCategory_no { get { return book_category_no; } set { book_category_no = value; } }
        public string bookCategory_name { get { return book_category_name; } set { book_category_name = value; } }
        public string bookDescription { get { return book_description; } set { book_description = value; } }
        public int bookPrice { get { return book_price; } set { book_price = value; } }
        public string bookCompany { get { return book_company; } set { book_company = value; } }
        public string bookDate { get { return book_date; } set { book_date = value; } }
        public int bookPages { get { return book_pages; } set { book_pages = value; } }
        public string bookOriginalImagePath { get { return book_originalImagePath; } set { book_originalImagePath = value; } }
        public string bookSavenameImaegPath { get { return book_savenameImaegPath; } set { book_savenameImaegPath = value; } }
        public int bookRentalcounts { get { return book_rentalcounts; } set { book_rentalcounts = value; } }
        public int bookLocationNo { get { return book_location_no; } set { book_location_no = value; } }
        public string bookLocationName { get { return book_location_name; } set { book_location_name = value; } }
        public int bookRentalNo { get { return book_rental_no; } set { book_rental_no = value; } }
        public string bookRental_name { get { return book_rental_name; } set { book_rental_name = value; } }

        // 전체 도서 리스트 조회 시 사용할 생성자
        public Book(int book_no, string book_title, string book_writer, string book_category_name, string book_description, int book_price, string book_company, string book_date, int book_pages, string book_originalImagePath, string book_savenameImaegPath, int book_rentalcounts, string book_location_name, string book_rental_name)
        {
            this.book_no = book_no;
            this.book_title = book_title;
            this.book_writer = book_writer;
            this.book_category_name = book_category_name;
            this.book_description = book_description;
            this.book_price = book_price;
            this.book_company = book_company;
            this.book_date = book_date;
            this.book_pages = book_pages;
            this.book_originalImagePath = book_originalImagePath;
            this.book_savenameImaegPath = book_savenameImaegPath;
            this.book_rentalcounts = book_rentalcounts;
            this.book_location_name = book_location_name;
            this.book_rental_name = book_rental_name;
        }

        public Book()
        {
        }
    }
}
