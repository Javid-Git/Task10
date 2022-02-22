using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email unvaninizi daxil edin");
            string mail = Console.ReadLine();
            Console.WriteLine("Sifrenizi daxil edin");
            string psswrd = Console.ReadLine();
            User user = new User(mail, psswrd);
            Console.WriteLine("Adinizi ve Soyadinizi daxil edin");
            user.Fullname = Console.ReadLine();
            user.PasswordChecker(psswrd);
            user.ShowInfo();
        }
    }
}
