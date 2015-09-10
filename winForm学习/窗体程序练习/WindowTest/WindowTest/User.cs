using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowTest
{
    /// <summary>
    /// 实体类
    /// </summary>
    class User
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string loginName;

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string realName;

        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }
    }
}
