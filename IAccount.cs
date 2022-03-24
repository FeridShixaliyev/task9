using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
