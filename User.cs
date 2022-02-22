using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class User : IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string a)
        {
            bool check = true;
            while (check)
            {
                if (a.Length > 7)
                {
                    bool CheckUpper = false;
                    bool CheckLower = false;
                    bool CheckDigit = false;
                    foreach (char item in a)
                    {
                        if (Char.IsUpper(item))
                        {
                            CheckUpper = true;
                        }
                        else if (Char.IsLower(item))
                        {
                            CheckLower = true;
                        }
                        else if (Char.IsDigit(item))
                        {
                            CheckDigit = true;
                        }
                        if (CheckUpper && CheckLower && CheckDigit)
                        {
                            return check;
                        }
                    }
                    if (!CheckUpper || !CheckLower || !CheckDigit)
                    {
                        Console.WriteLine("Shifre en azi 1 reqem 1 boyuk ve 1 kicik herflerden ibaret olmalidir! Bir daha sinayin");
                        a = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Shifreniz 8 simvoldan artiq olmalidir! Bir daha sinayin");
                    a = Console.ReadLine();
                }

            }
            return !check;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n************User haqqinda melumat************\nAd ve Soyad: {Fullname}\nEmail: {Email}");
        }
    }
}
