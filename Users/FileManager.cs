using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Users
{
    public class FileManager
    {
        private static string HEADERS = "name;username;password;email;operations";
        public static string INPUT_FILEPATH = "../../../Users/list-of-users.csv";
        public static string OUTPUT_FILEPATH = "../../../Users/list-of-users.csv";
        public static List<User> ReadUsersFromFile()
        {
            List<User> listUsers = new List<User>();

            if (!File.Exists(INPUT_FILEPATH))
            {
                Console.WriteLine($"ERROR: file {INPUT_FILEPATH} not found.");
                return listUsers;
            }

            // Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader(INPUT_FILEPATH))
            {
                string? lineCSV;

                lineCSV = file.ReadLine(); //skip headers line

                while ((lineCSV = file.ReadLine()) != null)
                {
                    User newUser = User.CreateUserFromString(lineCSV, ";");
                    listUsers.Add(newUser);
                }
                file.Close();
            }

            return listUsers;
        }

        public static string WriteUsersToFile(List<User> listUsers)
        {
             if(listUsers == null)
            {
                return "";
            }

            if (!File.Exists(OUTPUT_FILEPATH))
            {
                return $"ERROR: file {OUTPUT_FILEPATH} not found.";
            }

            // Read file using StreamWriter. Writes file line by line
            using (StreamWriter file = new StreamWriter(OUTPUT_FILEPATH))
            {
                string? lineCSV;
                file.WriteLine(HEADERS);

                foreach (User user in listUsers)
                {
                    file.WriteLine(user.toStringCSV(";"));                
                }
                file.Close();
            }

            return "";
        }


    }
}
