using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM2.Model
{
    static class DB
    {
        public static Dictionary<string, string> TestDB = new Dictionary<string, string>()
            {
                { "User1", "User1"},
                { "User2", "User2"},
                { "User3", "User3"},
                { "User4", "User4"},
                { "User5", "User5"}
            };
    }
    internal class User
    {
        public void SignIn(string login, string password) {
            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                if (login == "Admin" && password == "Admin")
                {
                    MessageBox.Show("You've autorised as an admin. Welcome!");
                }
                else if (DB.TestDB.ContainsKey(login) && DB.TestDB.ContainsValue(password))
                {
                    MessageBox.Show("You've autorised as a user. Welcome!");
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            else
            {
                MessageBox.Show("Заповніть обидва поля");
            }
        }

    }
}
