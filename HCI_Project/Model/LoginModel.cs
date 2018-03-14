using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_Project
{
    public class LoginModel
    {
        public static Dictionary<String, User> Users;
        public static string Username;

        public LoginModel()
        {
            Users = UserFileManipulation.loadUsers();
            if (Users == null)
            {
                Users = new Dictionary<string, User>();
            }
        }

        public User addUser(String email, String username, String password)
        {
            if (Users.ContainsKey(username))
                return null;

            User u = new User(email, username, password);
            Users.Add(username, u);
            UserFileManipulation.saveUsers(Users);

            return u;
        }

        public static void updateUser(User u)
        {
            Users.Remove(u.getUsername());
            Users.Add(u.getUsername(), u);
        }

        public bool checkLoginData(String username, String password)
        {
            if (Users.ContainsKey(username))
            {
                return Users[username].EqualPassword(password);
            }

            return false;
        }

        public User getUser(String username)
        {
            if (Users.ContainsKey(username))
                return Users[username];
            else
                return null;
        }
    }
}
