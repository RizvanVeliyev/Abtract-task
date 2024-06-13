using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{

    class User : Account
    {
        private static int idCounter = 1;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (PasswordChecker(value))
                    password = value;
                else
                    Console.WriteLine("yalnis sifre"); 
            }
        }

        public User(string fullname, string email, string password)
        {
            this.Id = idCounter++;
            this.Fullname = fullname;
            this.Email = email;
            this.Password = password; 
        }

        public override bool PasswordChecker(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                if (char.IsLower(c))
                    hasLower = true;
                if (char.IsDigit(c))
                    hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}
