using BookManagementProgram.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.Repository
{
    interface IBookRentalRepository
    {
        DataTable GetAllRental(); // 렌탈 리스트
        DataTable GetAllDelinquent(); // 연체자 리스트
        DataTable GetBookInfo(string bookNo); // 도서정보 검색
        DataTable GetUserInfo(string userNo);// 사용자정보 검색
        bool AddBook(Rental rental); // 렌탈정보등록
        DataTable CheckRentalBook(string bookNo); // 반납 도서 확인
        bool ReturnBook(string userNo, string bookNo);// 반납 정보 등록
        DataTable GetRentalHistory(); // 전체 렌탈 기록 조회
    }
}
