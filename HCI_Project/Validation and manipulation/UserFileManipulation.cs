using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;

namespace HCI_Project
{
    public class UserFileManipulation
    {
        public static Dictionary<String, User> loadUsers(){

            Dictionary<String, User> users = null;

            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                FileInfo fi = new System.IO.FileInfo(@"./../../Data/User Data/Users.dat");

                using (var binaryFile = fi.OpenRead())
                {
                    users = (Dictionary<String, User>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception e)
            {

            }


            return users;

        }

        public static void saveUsers(Dictionary<String, User> users){

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileInfo fi = new System.IO.FileInfo(@"./../../Data/User Data/Users.dat");

            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, users);
                binaryFile.Flush();
            }
        }

    }
}
