using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata.Ecma335;

namespace UtilitiesLibrary
{
    public class PasswordValidation
    {
        public bool validatePassword(string password)
        {
            Regex passwordValidationRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!#$%&/¡*]).{8,}$");
            return passwordValidationRegex.IsMatch(password);
        }

        public bool passwordQuery(int line, string password)
        {
            var path = @"..\\..\\..\\..\\Users.txt";

            line += 3;

            Cryptography cryptography = new Cryptography();

            password = cryptography.encrypt(password);

            password = "  password: " + password;

            string lineText = File.ReadLines(path).Skip(line).Take(1).First();

            if (password == lineText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class UsernameValidation
    {
        public bool usernameQuery(string username)
        {
            var path = @"..\\..\\..\\..\\Users.txt";

            Cryptography cryptography = new Cryptography();

            username = cryptography.encrypt(username);

            string query = "  username: " + username;

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == query)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int getLine(string username)
        {
            var path = @"..\\..\\..\\..\\Users.txt";

            Cryptography cryptography = new Cryptography();

            username = cryptography.encrypt(username);

            username = "  username: " + username;

            int lineNum = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lineNum++;
                    if (line == username)
                        return lineNum;
                }
            }

            return -1;
        }
    }

    public class Cryptography
    {
        public string encrypt(string str)
        {
            string newStr = string.Empty;

            foreach (char c in str)
            {
                var asciiValue = (int)c;

                if (asciiValue <= 35)
                {
                    asciiValue -= 3;
                    asciiValue += 94;
                }
                else
                {
                    asciiValue -= 3;
                }

                newStr += Convert.ToChar(asciiValue);
            }

            return newStr;
        }

        public string decrypt(string str)
        {
            string newStr = string.Empty;

            foreach (char c in str)
            {
                var asciiValue = (int)c;

                if (asciiValue >= 124)
                {
                    asciiValue += 3;
                    asciiValue -= 94;
                }
                else
                {
                    asciiValue += 3;
                }

                newStr += Convert.ToChar(asciiValue);
            }

            return newStr;
        }
    }

    public class User
    {
        private string name;
        private string username;
        private string phone;
        private DateOnly birthDate;
        private string socialNetwork;
        private string password;

        public User(string name, string username, string phone, DateOnly birthDate,string socialNetwork, string password)
        {
            this.name = name;
            this.username = username;
            this.phone = phone;
            this.birthDate = birthDate;
            this.socialNetwork = socialNetwork;
            this.password = password;
        }

        public void writeData()
        {
            var path = @"..\\..\\..\\..\\Users.txt";

            var UserID = this.getUserID(path);
            var name = this.name;
            var username = this.username;
            var phone = this.phone;
            var birthDate = this.birthDate;
            var socialNetwork = this.socialNetwork;
            var password = this.password;

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    this.writeFormattedData(sw, UserID, name, username, phone, birthDate, socialNetwork, password);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    this.writeFormattedData(sw, UserID, name, username, phone, birthDate, socialNetwork, password);
                }

            }
        }

        public string getUserID(string path)
        {
            var lineCount = File.ReadLines(path).Count();
            var IDnumber = lineCount / 8;
            string UserID = "";
            UserID += IDnumber.ToString();
            while (UserID.Length < 4)
            {
                UserID = "0" + UserID;
            }
            return UserID;
        }

        public void writeFormattedData(StreamWriter sw, string UserID, string name, string username, string phone, DateOnly birthDate, string socialNetwork, string password)
        {
            sw.WriteLine(UserID + " {");
            sw.WriteLine("  name: " + name);
            sw.WriteLine("  username: " + username);
            sw.WriteLine("  phone: " + phone);
            sw.WriteLine("  birthDate: " + birthDate);
            sw.WriteLine("  socialNetwork: " + socialNetwork);
            sw.WriteLine("  password: " + password);
            sw.WriteLine("}");
        }
    }
}
