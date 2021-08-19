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
        private string authority_name;
        private string grade_name;

        public string userNo { get { return user_no; } set { user_no = value; } }
        public string userName { get { return user_name; } set { user_name = value; } }
        public string userAddress { get { return user_address; } set { user_address = value; } }
        public string userBirth { get { return user_birth; } set { user_birth = value; } }
        public string userId { get { return user_id; } set { user_id = value; } }
        public string userPw { get { return user_pw; } set { user_pw = value; } }
        public string registerDate { get { return register_date; } set { register_date = value; } }
        public string authorityNo { get { return authority_name; } set { authority_name = value; } }
        public string gradeNo { get { return grade_name; } set { grade_name = value; } }

        public User(string user_no, string user_name, string user_address, string user_birth, string user_id, string user_pw, string register_date, string authority_name, string grade_name)
        {
            this.user_no = user_no;
            this.user_name = user_name;
            this.user_address = user_address;
            this.user_birth = user_birth;
            this.user_id = user_id;
            this.user_pw = user_pw;
            this.register_date = register_date;
            this.authority_name = authority_name;
            this.grade_name = grade_name;
        }

        public User()
        {
        }
    }
}