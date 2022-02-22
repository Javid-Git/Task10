using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    interface IAccount
    {
        public bool PasswordChecker(string a);
        public void ShowInfo();
    }
}
