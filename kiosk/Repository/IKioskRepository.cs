using kiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.Repository
{
    interface IKioskRepository
    {
        // 주문
        void AddMenu(string name, int price);
        // 계산
        int Billing();
        // 주문한 메뉴 확인
        List<Menu> SelectOrders();
        // 주문한 갯수
        int CountingMenu();

        // 초기화
        void Reset();
    }
}
