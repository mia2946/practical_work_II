using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Users
{
    public class User
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int totalOperations { get; set; }
        
        private static int ID_USER = 0;


        public User() { 
            idUser = ID_USER++;
        }

        public User(int idUser, string name, string username, string password, string email)
        {
            this.idUser = idUser;
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.totalOperations = 0;
        }

        public User(string name, string username, string password, string email, int operations)
        {
            idUser = ID_USER++;
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.totalOperations = operations;
        }
        public User(string name, string username, string password, string email)
        {
            idUser = ID_USER++;
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.totalOperations = 0;
        }

        public User(User u)
        {
            idUser = ID_USER++;
            this.name = u.name;
            this.username = u.username;
            this.password = u.password;
            this.email = u.email;
            this.totalOperations = 0;
        }

        public static string validateFormMessages(string name, string username, string password, string email)
        {
            bool hasNumber = false;
            bool hasSpecialChar = false;

            //Check name validations
            foreach (char c in name)
            {

                if ('0' <= c && c <= '9')
                {
                    hasNumber = true;
                }
                if ("@#|!$%&/()=?¿-_:;,.<>".Contains(c))
                {
                    hasSpecialChar = true;
                }
            }
            if (hasNumber)
            {
                return "Field 'name' must not have digits.";
            }
            if (hasSpecialChar)
            {
                return "Field 'name' must not have special characters.";
            }

            //Check username validations
            if (username.Trim() == "")
            {
                return "Field 'username' must not be empty.";
            }
            if (username.Contains(";"))
            {
                return "Username cannot have any semicolons ';'.";
            }

            //Check password validations
            string passwordMessage = validatePasswordMessage(password);
            if(passwordMessage != "")
            {
                return passwordMessage;
            }

            //Check email validations
            if (!email.Contains("@"))
            {
                return "Email must have '@' character.";
            }
            if (email.Contains(";"))
            {
                return "Email cannot have any semicolons ';'.";
            }

            return "";
        }

        public static string validatePasswordMessage(string password)
        {
            bool hasUppercase = false;
            bool hasLowerCase = false;
            bool hasNumber = false;
            bool hasSpecialChar = false;
            bool hasSemicolon = false;
            hasNumber = false;
            hasSpecialChar = false;
            if (password.Length >= 8)
            {
                foreach (char c in password)
                {
                    if ('A' <= c && c <= 'Z')
                    {
                        hasUppercase = true;
                    }
                    if ('a' <= c && c <= 'z')
                    {
                        hasLowerCase = true;
                    }
                    if ('0' <= c && c <= '9')
                    {
                        hasNumber = true;
                    }
                    if ("@#|!$%&/()=?¿-_:,.<>".Contains(c))
                    {
                        hasSpecialChar = true;
                    }
                    if (c == ';')
                    {
                        hasSemicolon = true;
                    }
                }
                if (!hasUppercase)
                {
                    return "Password must have al least 1 uppercase character.";
                }
                if (!hasLowerCase)
                {
                    return "Password must have al least 1 lowercase character.";
                }
                if (!hasNumber)
                {
                    return "Password must have al least 1 digit number.";
                }
                if (!hasSpecialChar)
                {
                    return "Password must have al least 1 special character.";
                }
                if (hasSemicolon)
                {
                    return "Password cannot have any semicolons ';'.";
                }
            }
            else
            {
                return "Password must have al least 8 characters.";
            }

            return "";

        }


        public void ChangePassword(string password, string passwordRepeat)
        {
            if (password.Equals(passwordRepeat))
            {
                this.password = password;
            }
        }

        public static User CreateUserFromString(string lineCSV, string separator)
        {
            string[] fields;
            fields = lineCSV.Split(separator);

            try
            {
                return new User(fields[0], fields[1], fields[2], fields[3], int.Parse(fields[4]) );
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string toStringCSV(string separator)
        {
            return this.name + separator +
                   this.username + separator +
                   this.password + separator +
                   this.email + separator +
                   this.totalOperations;
        }

    }
}
