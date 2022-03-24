using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class User:IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;

        public bool PasswordChecker(string password)
        {
                bool countupper = false;
                bool countlower = false;
                bool countdigit = false;
            for (int i = 0; i < password.Length; i++)
            {
                /*bool countlength = false;*///passwordun uzunlugunu yoxlamaq ucun elave etdiyim bir countdir
                if (char.IsLower(password[i]))
                {
                    countlower= true;
                }
                
                else if (char.IsUpper(password[i]))
                {
                    countupper = true;
                }

                else if (char.IsDigit(password[i]))
                {
                    countdigit = true;
                }

                //else if (password.Length > 7)
                //{
                //    countlength = true;
                //}
                if (countdigit && countlower && countupper   )
                {
                    return true;
                }
            }
                return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Info:\nFullname >> {Fullname}\nEmail >> {Email}");
            
        }

    }
}
