using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.Model
{
    class User
    {
        private string user_no;
        private string user_name;
        private string user_address;
        private string user_birth;
        private string user_id;
        private string user_pw;
        private string register_date;
        private string deregister_date;
        private int authority_no;
        private string authority_name;
        private int grade_no;
        private string grade_name;

        public string userNo { get { return user_no; } set { user_no = value; } }
        public string userName { get { return user_name; } set { user_name = value; } }
        public string userAddress { get { return user_address; } set { user_address = value; } }
        public string userBirth { get { return user_birth; } set { user_birth = value; } }
        public string userId { get { return user_id; } set { user_id = value; } }
        public string userPw { get { return user_pw; } set { user_pw = value; } }
        public string registerDate { get { return register_date; } set { register_date = value; } }
        public string deregisterDate { get { return deregister_date; } set { deregister_date = value; } }
        public int authorityNo { get { return authority_no; } set { authority_no = value; } }
        public string authorityName { get { return authority_name; } set { authority_name = value; } }
        public int gradeNo { get { return grade_no; } set { grade_no = value; } }
        public string gradeName { get { return grade_name; } set { grade_name = value; } }

        // 로그인 시 사용되는 생성자
        public User(string user_no, string user_name, string user_address, string user_birth, string user_id, string user_pw, string register_date, int authority_no, int grade_no)
        {
            this.user_no = user_no;
            this.user_name = user_name;
            this.user_address = user_address;
            this.user_birth = user_birth;
            this.user_id = user_id;
            this.user_pw = user_pw;
            this.register_date = register_date;
            this.authority_no = authority_no;
            this.grade_no = grade_no;
        }

        // 전체 사용자 조회때 사용되는 생성자
        public User(string user_no, string user_name, string user_address, string user_birth, string user_id, string user_pw, string register_date, string deregister_date, string authority_name, string grade_name)
        {
            this.user_no = user_no;
            this.user_name = user_name;
            this.user_address = user_address;
            this.user_birth = user_birth;
            this.user_id = user_id;
            this.user_pw = user_pw;
            this.register_date = register_date;
            this.deregister_date = deregister_date;
            this.authority_name = authority_name;
            this.grade_name = grade_name;
        }

        public User()
        {
        }
    }
}