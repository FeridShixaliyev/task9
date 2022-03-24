using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Fullname = "Ferid Sixaliyev";
            user.Email = "ferid-sixaliyev@mail.ru";
            
            user.ShowInfo();
            Console.WriteLine($"Password checking...{ user.PasswordChecker("Ferid1524")}");


        }
    }
}
