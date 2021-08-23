using BookManagementProgram.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.Repository
{
    interface IBookRepository
    {
        DataTable GetAllBooks();

        Dictionary<string, object> GetCategoryList();
        Dictionary<string, object> GetBookLocationList();
        Dictionary<string, object> GetBookRentalStateList();

        bool AddBook(Book book);

        Book GetBookByNumber(string bookNo);

        bool DeleteBookByNumber(string bookNo);

        bool UpdateBookInfo(Book book);
    }
}
