using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk.Model
{
    class Menu
    {
        // 메뉴 이름
        public string Name { get; set; }

        // 메뉴 가격
        public int Price { get; set; }

        // 주문 수량
        public int Each { get; set; }

        // 개체 출력 양식
        public override string ToString()
        {
            return $"{Name} : {Price} : {Each}개";
        }
    }
}
