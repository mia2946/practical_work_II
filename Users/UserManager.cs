using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PracticalWorkII.Users
{
    public class UserManager
    {
        public List<User> users { get; set; }

        private static UserManager instance = null;

        public static UserManager getInstance()
        {
            if(instance == null)
            {
                instance = new UserManager();
            }
            return instance;
        }


        private UserManager()
        {
           users = FileManager.ReadUsersFromFile();
        }

        public string AddUser(User user)
        {
            foreach(User currentUser in users)
            {
                if(currentUser.username.Equals(user.username) ||
                   currentUser.email.Equals(user.email))
                {
                    return "The username or email already exists.";
                }
            }

            users.Add(user);
            return "";
        }

        public User FindUserByUsernameAndPassword(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.username.Equals(username) && user.password.Equals(password))
                {
                    return user;
                }
            }
            return null;
        }

        public User FindUserByUsernameOrEmail(string usernameOremail)
        {
            foreach (User user in users)
            {
                if (user.username.Equals(usernameOremail) || user.email.Equals(usernameOremail))
                {
                    return user;
                }
            }
            return null;
        }



        public static bool CheckPasswordMatch(string password, string passwordRepeat)
        {
            return password.Equals(passwordRepeat);
        }

    }
}
