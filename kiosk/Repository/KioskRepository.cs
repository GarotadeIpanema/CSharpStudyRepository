using kiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.Repository
{
    class KioskRepository : IKioskRepository
    {
        // 주문한 메뉴 개체 인스턴스
        public static List<Menu> menus = new List<Menu>();

        // 주문
        public void AddMenu(string name, int price)
        {
            menus.Add(new Menu { Name = name, Price = price, Each = 1 });
            // 중복 제거, 특정 기준으로 그룹화를 시켜준 다음 그룹 중 첫번째 값만 리스트 형식으로 리턴
            // object가 아닌 literal value List 였다면 .Distinct().ToList() 사용
            menus = menus
                            .GroupBy(item => item.Name)
                            .Select(item => new Menu { Name = item.First().Name, Price = item.First().Price, Each = (item.First().Each - 1) + item.Count()})
                            .ToList();
        }

        // 계산
        public int Billing()
        {
            return menus.Sum((menu) => (menu.Price * menu.Each));
        }


        // 주문한 메뉴 확인
        public List<Menu> SelectOrders()
        {
            return menus;
        }

        // 주문한 갯수
        public int CountingMenu()
        {
            return menus.Sum(menu => menu.Each);
        }

        // 초기화
        public void Reset()
        {
            menus.Clear();
        }
    }
}
