using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_Project
{
    [Serializable]
    public class User
    {
        private string Email
        {
            get;
            set;
        }

        private string Username
        {
            get;
            set;
        }

        private string Password
        {
            get;
            set;
        }

        private Map map;

        public User(String e, String u, String p)
        {
            this.Email = e;
            this.Password = p;
            this.Username = u;
            map = new Map();
        }

        public bool EqualPassword(String p)
        {
            return Password.Equals(p);
        }

        public Map getUserMap()
        {
            return map;
        }

        public void setUserMap(Map m)
        {
            map = m;
        }

        public String getUsername()
        {
            return Username;
        }
    }
}
